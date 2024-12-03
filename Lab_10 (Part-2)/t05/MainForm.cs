using System; 
using System.Collections.Generic; 
using System.Data; 
using System.Linq; 
using System.Windows.Forms; 
using Task_5.Models; 

namespace Task_5
{
    public partial class MainForm : Form
    {
        private Database db; 
        private List<Transport> transports; 
        private List<Route> routes; 
        private List<RouteRegister> routeRegisters; 

        private List<Transport> filteredTransports; // Գ���� ���������
        private List<Route> filteredRoutes; // Գ���� ��������
        private List<RouteRegister> filteredRouteRegisters; // Գ���� ������

        private Dictionary<string, Control> filterControls; // ������� �������

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database();

            // ϳ������ �� ��䳿
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged; 
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged; 
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged; 
            this.Load += MainForm_Load; // ������������ �����
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            InitializeFilters(); 
            UpdateView(); 
        }

        private void LoadData()
        {
            try
            {
                transports = db.GetTransports(); // �������� ����������
                routes = db.GetRoutes(); // �������� ��������
                routeRegisters = db.GetRouteRegisters(); // �������� ������
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� ����������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void InitializeFilters()
        {
            filterControls = new Dictionary<string, Control>(); // �������� �������
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); 
        }

        private void UpdateView()
        {
            panelFilters.Controls.Clear(); // �������� ������
            filterControls.Clear(); // �������� �������

            if (radioButtonTransport.Checked)
            {
                filteredTransports = new List<Transport>(transports); // Գ���� ���������
                dataGridView.DataSource = filteredTransports; // ³��������� ����������
                CreateFilters(typeof(Transport)); 
            }
            else if (radioButtonRoute.Checked)
            {
                filteredRoutes = new List<Route>(routes); // Գ���� ��������
                dataGridView.DataSource = filteredRoutes; // ³��������� ��������
                CreateFilters(typeof(Route)); 
            }
            else if (radioButtonRouteRegister.Checked)
            {
                filteredRouteRegisters = new List<RouteRegister>(routeRegisters); // Գ���� ������
                dataGridView.DataSource = filteredRouteRegisters; // ³��������� ������
                CreateFilters(typeof(RouteRegister)); 
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ����� �������
        }

        private void CreateFilters(Type type)
        {
            int x = 0; // ��������� ������� X
            int columnCount = dataGridView.Columns.Count; // ʳ������ �������
            for (int i = 0; i < columnCount; i++)
            {
                DataGridViewColumn column = dataGridView.Columns[i]; // �������
                string propertyName = column.DataPropertyName; // ����������

                Control filterControl; // �������� �������

                // ���������� ���� ����
                var propInfo = type.GetProperty(propertyName); 
                if (propInfo.PropertyType == typeof(string))
                {
                    // ComboBox ��� ������
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = "filter_" + propertyName; 
                    comboBox.Width = column.Width; 
                    comboBox.Left = column.DisplayIndex * column.Width; // ������� X
                    comboBox.Top = 0; // ������� Y
                    comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown; // �����
                    comboBox.TextChanged += FilterControl_ValueChanged; // ���� ����
                    panelFilters.Controls.Add(comboBox); 
                    filterControl = comboBox; // ����������� ��������

                    // ���������� �������
                    var values = GetDistinctValues(type, propertyName); // ������� ��������
                    comboBox.Items.AddRange(values.ToArray()); // ������ ��������
                }
                else
                {
                    // TextBox ��� �����
                    TextBox textBox = new TextBox();
                    textBox.Name = "filter_" + propertyName;
                    textBox.Width = column.Width; 
                    textBox.Left = column.DisplayIndex * column.Width; // ������� X
                    textBox.Top = 0; // ������� Y
                    textBox.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
                    textBox.TextChanged += FilterControl_ValueChanged; // ���� ����
                    panelFilters.Controls.Add(textBox); 
                    filterControl = textBox; // ���������� ��������
                }

                filterControls[propertyName] = filterControl; // ������ �� ��������
            }
        }

        private List<string> GetDistinctValues(Type type, string propertyName)
        {
            if (type == typeof(Transport))
            {
                return transports.Select(t => t.GetType().GetProperty(propertyName).GetValue(t)?.ToString())
                                 .Distinct()
                                 .OrderBy(v => v)
                                 .ToList(); // ������� ����������
            }
            else if (type == typeof(Route))
            {
                return routes.Select(r => r.GetType().GetProperty(propertyName).GetValue(r)?.ToString())
                             .Distinct()
                             .OrderBy(v => v)
                             .ToList(); // ������� ��������
            }
            else if (type == typeof(RouteRegister))
            {
                return routeRegisters.Select(rr => rr.GetType().GetProperty(propertyName).GetValue(rr)?.ToString())
                                     .Distinct()
                                     .OrderBy(v => v)
                                     .ToList(); // ������� ������
            }
            else
            {
                return new List<string>(); // ������� ������
            }
        }

        private void FilterControl_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // ����������� �������
        }

        private void ApplyFilters()
        {
            if (radioButtonTransport.Checked)
            {
                IEnumerable<Transport> query = transports; // ����� ����������

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // ����������
                    Control control = kvp.Value; // ��������
                    string filterValue = ""; // �������� �������

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // �������� �����
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // �������� �����
                    }

                    if (!string.IsNullOrEmpty(filterValue))
                    {
                        query = query.Where(t =>
                        {
                            var propertyValue = t.GetType()
                                                 .GetProperty(propertyName)
                                                 ?.GetValue(t)
                                                 ?.ToString();

                            return propertyValue?.Contains(filterValue, StringComparison.OrdinalIgnoreCase) == true;
                        });
                    }
                }

                filteredTransports = query.ToList(); // ��������� ����������
                dataGridView.DataSource = null; // �������� �������
                dataGridView.DataSource = filteredTransports; // ³���������
            }
            else if (radioButtonRoute.Checked)
            {
                IEnumerable<Route> query = routes; // ����� ��������

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // ����������
                    Control control = kvp.Value; // ��������
                    string filterValue = ""; // �������� �������

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // �������� �����
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // �������� �����
                    }

                    if (!string.IsNullOrEmpty(filterValue))
                    {
                        query = query.Where(r =>
                        {
                            var propertyValue = r.GetType()
                                                 .GetProperty(propertyName)
                                                 ?.GetValue(r)
                                                 ?.ToString();

                            return propertyValue?.Contains(filterValue, StringComparison.OrdinalIgnoreCase) == true;
                        });
                    }
                }

                filteredRoutes = query.ToList(); // ��������� ����������
                dataGridView.DataSource = null; // �������� �������
                dataGridView.DataSource = filteredRoutes; // ³���������
            }
            else if (radioButtonRouteRegister.Checked)
            {
                IEnumerable<RouteRegister> query = routeRegisters; // ����� ������

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // ����������
                    Control control = kvp.Value; // ��������
                    string filterValue = ""; // �������� �������

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // �������� �����
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // �������� �����
                    }

                    if (!string.IsNullOrEmpty(filterValue))
                    {
                        query = query.Where(rr =>
                        {
                            var propertyValue = rr.GetType()
                                                  .GetProperty(propertyName)
                                                  ?.GetValue(rr)
                                                  ?.ToString();

                            return propertyValue?.Contains(filterValue, StringComparison.OrdinalIgnoreCase) == true;
                        });
                    }
                }

                filteredRouteRegisters = query.ToList(); // ��������� ����������
                dataGridView.DataSource = null; // �������� �������
                dataGridView.DataSource = filteredRouteRegisters; // ³���������
            }
        }
    }
}
