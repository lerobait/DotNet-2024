using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 
using Task_4.Models; 

namespace Task_4
{
    public partial class MainForm : Form
    {
        private Database db; // ���� �����
        private List<Transport> transports; // ���������
        private List<Route> routes; // ��������
        private List<RouteRegister> routeRegisters; // ������

        // ���������� �����
        private Dictionary<string, bool> sortDirections;

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database(); 

            // ����������� ����������
            sortDirections = new Dictionary<string, bool>();

            // ϳ������ �� ��䳿
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged; // ���������
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged; // �������
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged; // �����
            dataGridView.ColumnHeaderMouseClick += DataGridView_ColumnHeaderMouseClick; // ����������
            this.Load += MainForm_Load; // ������������ �����
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
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
                MessageBox.Show($"������� ��� ����������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error); // ����������� ��� �������
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); // ������� ������
        }

        private void UpdateView()
        {
            if (radioButtonTransport.Checked)
            {
                dataGridView.DataSource = transports; // ³��������� ����������
            }
            else if (radioButtonRoute.Checked)
            {
                dataGridView.DataSource = routes; // ³��������� ��������
            }
            else if (radioButtonRouteRegister.Checked)
            {
                dataGridView.DataSource = routeRegisters; // ³��������� ������
            }

            // �������� ����������
            sortDirections.Clear();
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView.Columns[e.ColumnIndex].DataPropertyName; // �������� �������

            if (!sortDirections.ContainsKey(columnName))
            {
                sortDirections[columnName] = true; // ���������
            }
            else
            {
                sortDirections[columnName] = !sortDirections[columnName]; // ���� ��������
            }

            SortData(columnName, sortDirections[columnName]); // ��������� ���
        }

        private void SortData(string columnName, bool ascending)
        {
            if (radioButtonTransport.Checked)
            {
                if (ascending)
                {
                    transports.Sort((x, y) => CompareProperty(x, y, columnName)); // ����������
                }
                else
                {
                    transports.Sort((x, y) => CompareProperty(y, x, columnName)); // ����������
                }

                dataGridView.DataSource = null; // �������
                dataGridView.DataSource = transports; // ³���������
            }
            else if (radioButtonRoute.Checked)
            {
                if (ascending)
                {
                    routes.Sort((x, y) => CompareProperty(x, y, columnName)); // ����������
                }
                else
                {
                    routes.Sort((x, y) => CompareProperty(y, x, columnName)); // ����������
                }

                dataGridView.DataSource = null; // �������
                dataGridView.DataSource = routes; // ³���������
            }
            else if (radioButtonRouteRegister.Checked)
            {
                if (ascending)
                {
                    routeRegisters.Sort((x, y) => CompareProperty(x, y, columnName)); // ����������
                }
                else
                {
                    routeRegisters.Sort((x, y) => CompareProperty(y, x, columnName)); // ����������
                }

                dataGridView.DataSource = null; // �������
                dataGridView.DataSource = routeRegisters; // ³���������
            }
        }

        private int CompareProperty<T>(T x, T y, string propertyName)
        {
            var prop = typeof(T).GetProperty(propertyName); // �������� ����������
            var valueX = prop.GetValue(x); // �������� X
            var valueY = prop.GetValue(y); // �������� Y

            return Comparer<object>.Default.Compare(valueX, valueY); // ��������
        }
    }
}
