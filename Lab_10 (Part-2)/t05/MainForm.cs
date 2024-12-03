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

        private List<Transport> filteredTransports; // Фільтр Транспорт
        private List<Route> filteredRoutes; // Фільтр Маршрути
        private List<RouteRegister> filteredRouteRegisters; // Фільтр Реєстри

        private Dictionary<string, Control> filterControls; // Контролі фільтрів

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database();

            // Підписка на події
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged; 
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged; 
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged; 
            this.Load += MainForm_Load; // Завантаження форми
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
                transports = db.GetTransports(); // Отримати транспорти
                routes = db.GetRoutes(); // Отримати маршрути
                routeRegisters = db.GetRouteRegisters(); // Отримати реєстри
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void InitializeFilters()
        {
            filterControls = new Dictionary<string, Control>(); // Створити словник
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); 
        }

        private void UpdateView()
        {
            panelFilters.Controls.Clear(); // Очистити панель
            filterControls.Clear(); // Очистити контролі

            if (radioButtonTransport.Checked)
            {
                filteredTransports = new List<Transport>(transports); // Фільтр Транспорт
                dataGridView.DataSource = filteredTransports; // Відобразити транспорти
                CreateFilters(typeof(Transport)); 
            }
            else if (radioButtonRoute.Checked)
            {
                filteredRoutes = new List<Route>(routes); // Фільтр Маршрути
                dataGridView.DataSource = filteredRoutes; // Відобразити маршрути
                CreateFilters(typeof(Route)); 
            }
            else if (radioButtonRouteRegister.Checked)
            {
                filteredRouteRegisters = new List<RouteRegister>(routeRegisters); // Фільтр Реєстри
                dataGridView.DataSource = filteredRouteRegisters; // Відобразити реєстри
                CreateFilters(typeof(RouteRegister)); 
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Розмір колонок
        }

        private void CreateFilters(Type type)
        {
            int x = 0; // Початкова позиція X
            int columnCount = dataGridView.Columns.Count; // Кількість колонок
            for (int i = 0; i < columnCount; i++)
            {
                DataGridViewColumn column = dataGridView.Columns[i]; // Колонка
                string propertyName = column.DataPropertyName; // Властивість

                Control filterControl; // Контроль фільтра

                // Визначення типу поля
                var propInfo = type.GetProperty(propertyName); 
                if (propInfo.PropertyType == typeof(string))
                {
                    // ComboBox для тексту
                    ComboBox comboBox = new ComboBox();
                    comboBox.Name = "filter_" + propertyName; 
                    comboBox.Width = column.Width; 
                    comboBox.Left = column.DisplayIndex * column.Width; // Позиція X
                    comboBox.Top = 0; // Позиція Y
                    comboBox.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown; // Стиль
                    comboBox.TextChanged += FilterControl_ValueChanged; // Подія зміни
                    panelFilters.Controls.Add(comboBox); 
                    filterControl = comboBox; // Призначення контролю

                    // Заповнення значень
                    var values = GetDistinctValues(type, propertyName); // Унікальні значення
                    comboBox.Items.AddRange(values.ToArray()); // Додати елементи
                }
                else
                {
                    // TextBox для чисел
                    TextBox textBox = new TextBox();
                    textBox.Name = "filter_" + propertyName;
                    textBox.Width = column.Width; 
                    textBox.Left = column.DisplayIndex * column.Width; // Позиція X
                    textBox.Top = 0; // Позиція Y
                    textBox.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
                    textBox.TextChanged += FilterControl_ValueChanged; // Подія зміни
                    panelFilters.Controls.Add(textBox); 
                    filterControl = textBox; // Призначити контролю
                }

                filterControls[propertyName] = filterControl; // Додати до словника
            }
        }

        private List<string> GetDistinctValues(Type type, string propertyName)
        {
            if (type == typeof(Transport))
            {
                return transports.Select(t => t.GetType().GetProperty(propertyName).GetValue(t)?.ToString())
                                 .Distinct()
                                 .OrderBy(v => v)
                                 .ToList(); // Унікальні транспорти
            }
            else if (type == typeof(Route))
            {
                return routes.Select(r => r.GetType().GetProperty(propertyName).GetValue(r)?.ToString())
                             .Distinct()
                             .OrderBy(v => v)
                             .ToList(); // Унікальні маршрути
            }
            else if (type == typeof(RouteRegister))
            {
                return routeRegisters.Select(rr => rr.GetType().GetProperty(propertyName).GetValue(rr)?.ToString())
                                     .Distinct()
                                     .OrderBy(v => v)
                                     .ToList(); // Унікальні реєстри
            }
            else
            {
                return new List<string>(); // Порожній список
            }
        }

        private void FilterControl_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Застосувати фільтри
        }

        private void ApplyFilters()
        {
            if (radioButtonTransport.Checked)
            {
                IEnumerable<Transport> query = transports; // Запит транспорти

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // Властивість
                    Control control = kvp.Value; // Контроль
                    string filterValue = ""; // Значення фільтра

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // Отримати текст
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // Отримати текст
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

                filteredTransports = query.ToList(); // Результат фільтрації
                dataGridView.DataSource = null; // Очистити джерело
                dataGridView.DataSource = filteredTransports; // Відобразити
            }
            else if (radioButtonRoute.Checked)
            {
                IEnumerable<Route> query = routes; // Запит маршрути

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // Властивість
                    Control control = kvp.Value; // Контроль
                    string filterValue = ""; // Значення фільтра

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // Отримати текст
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // Отримати текст
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

                filteredRoutes = query.ToList(); // Результат фільтрації
                dataGridView.DataSource = null; // Очистити джерело
                dataGridView.DataSource = filteredRoutes; // Відобразити
            }
            else if (radioButtonRouteRegister.Checked)
            {
                IEnumerable<RouteRegister> query = routeRegisters; // Запит реєстри

                foreach (var kvp in filterControls)
                {
                    string propertyName = kvp.Key; // Властивість
                    Control control = kvp.Value; // Контроль
                    string filterValue = ""; // Значення фільтра

                    if (control is TextBox textBox)
                    {
                        filterValue = textBox.Text; // Отримати текст
                    }
                    else if (control is ComboBox comboBox)
                    {
                        filterValue = comboBox.Text; // Отримати текст
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

                filteredRouteRegisters = query.ToList(); // Результат фільтрації
                dataGridView.DataSource = null; // Очистити джерело
                dataGridView.DataSource = filteredRouteRegisters; // Відобразити
            }
        }
    }
}
