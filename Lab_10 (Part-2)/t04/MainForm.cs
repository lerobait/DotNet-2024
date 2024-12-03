using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 
using Task_4.Models; 

namespace Task_4
{
    public partial class MainForm : Form
    {
        private Database db; // База даних
        private List<Transport> transports; // Транспорт
        private List<Route> routes; // Маршрути
        private List<RouteRegister> routeRegisters; // Реєстри

        // Сортування стану
        private Dictionary<string, bool> sortDirections;

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database(); 

            // Ініціалізація сортування
            sortDirections = new Dictionary<string, bool>();

            // Підписка на події
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged; // Транспорт
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged; // Маршрут
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged; // Реєстр
            dataGridView.ColumnHeaderMouseClick += DataGridView_ColumnHeaderMouseClick; // Сортування
            this.Load += MainForm_Load; // Завантаження форми
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
                transports = db.GetTransports(); // Отримати транспорти
                routes = db.GetRoutes(); // Отримати маршрути
                routeRegisters = db.GetRouteRegisters(); // Отримати реєстри
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Повідомлення про помилку
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); // Оновити вигляд
        }

        private void UpdateView()
        {
            if (radioButtonTransport.Checked)
            {
                dataGridView.DataSource = transports; // Відобразити транспорти
            }
            else if (radioButtonRoute.Checked)
            {
                dataGridView.DataSource = routes; // Відобразити маршрути
            }
            else if (radioButtonRouteRegister.Checked)
            {
                dataGridView.DataSource = routeRegisters; // Відобразити реєстри
            }

            // Очистити сортування
            sortDirections.Clear();
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridView.Columns[e.ColumnIndex].DataPropertyName; // Отримати колонку

            if (!sortDirections.ContainsKey(columnName))
            {
                sortDirections[columnName] = true; // Зростання
            }
            else
            {
                sortDirections[columnName] = !sortDirections[columnName]; // Зміна напрямку
            }

            SortData(columnName, sortDirections[columnName]); // Сортувати дані
        }

        private void SortData(string columnName, bool ascending)
        {
            if (radioButtonTransport.Checked)
            {
                if (ascending)
                {
                    transports.Sort((x, y) => CompareProperty(x, y, columnName)); // Сортування
                }
                else
                {
                    transports.Sort((x, y) => CompareProperty(y, x, columnName)); // Сортування
                }

                dataGridView.DataSource = null; // Оновити
                dataGridView.DataSource = transports; // Відобразити
            }
            else if (radioButtonRoute.Checked)
            {
                if (ascending)
                {
                    routes.Sort((x, y) => CompareProperty(x, y, columnName)); // Сортування
                }
                else
                {
                    routes.Sort((x, y) => CompareProperty(y, x, columnName)); // Сортування
                }

                dataGridView.DataSource = null; // Оновити
                dataGridView.DataSource = routes; // Відобразити
            }
            else if (radioButtonRouteRegister.Checked)
            {
                if (ascending)
                {
                    routeRegisters.Sort((x, y) => CompareProperty(x, y, columnName)); // Сортування
                }
                else
                {
                    routeRegisters.Sort((x, y) => CompareProperty(y, x, columnName)); // Сортування
                }

                dataGridView.DataSource = null; // Оновити
                dataGridView.DataSource = routeRegisters; // Відобразити
            }
        }

        private int CompareProperty<T>(T x, T y, string propertyName)
        {
            var prop = typeof(T).GetProperty(propertyName); // Отримати властивість
            var valueX = prop.GetValue(x); // Значення X
            var valueY = prop.GetValue(y); // Значення Y

            return Comparer<object>.Default.Compare(valueX, valueY); // Порівняти
        }
    }
}
