using System; 
using System.Collections.Generic;
using System.Windows.Forms;
using Task_3.Models; 

namespace Task_3
{
    public partial class MainForm : Form
    {
        private Database db; 
        private List<Transport> transports; 
        private List<Route> routes; 
        private List<RouteRegister> routeRegisters; 

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database(); 

            // Додавання елементів
            if (comboBoxMode.Items.Count == 0)
            {
                comboBoxMode.Items.Add("Формуляр"); 
                comboBoxMode.Items.Add("Таблиця"); 
            }

            comboBoxMode.SelectedIndex = 0; // Вибір за замовчуванням

            // Підписка на події
            comboBoxMode.SelectedIndexChanged += comboBoxMode_SelectedIndexChanged; // Зміна режиму
            radioButtonTransport.CheckedChanged += radioButton_CheckedChanged; // Транспорт
            radioButtonRoute.CheckedChanged += radioButton_CheckedChanged; // Маршрут
            radioButtonRouteRegister.CheckedChanged += radioButton_CheckedChanged; // Реєстр
            this.Load += MainForm_Load; 
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

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView(); // Оновити вигляд
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); // Оновити вигляд
        }

        private void UpdateView()
        {
            if (comboBoxMode.SelectedItem == null)
                return; // Вихід якщо нічого не вибрано

            string mode = comboBoxMode.SelectedItem.ToString(); // Отримати режим

            if (mode == "Таблиця")
            {
                textBoxForm.Visible = false; // Сховати формуляр
                dataGridView.Visible = true; // Показати таблицю

                if (radioButtonTransport.Checked)
                {
                    dataGridView.DataSource = transports; // Показати транспорти
                }
                else if (radioButtonRoute.Checked)
                {
                    dataGridView.DataSource = routes; // Показати маршрути
                }
                else if (radioButtonRouteRegister.Checked)
                {
                    dataGridView.DataSource = routeRegisters; // Показати реєстри
                }
            }
            else if (mode == "Формуляр")
            {
                dataGridView.Visible = false; 
                textBoxForm.Visible = true; 
                textBoxForm.Clear(); // Очистити формуляр

                if (radioButtonTransport.Checked)
                {
                    foreach (var transport in transports)
                    {
                        textBoxForm.AppendText(transport.ToForm() + "\n\n"); // Додати транспорт
                    }
                }
                else if (radioButtonRoute.Checked)
                {
                    foreach (var route in routes)
                    {
                        textBoxForm.AppendText(route.ToForm() + "\n\n"); // Додати маршрут
                    }
                }
                else if (radioButtonRouteRegister.Checked)
                {
                    foreach (var rr in routeRegisters)
                    {
                        textBoxForm.AppendText(rr.ToForm() + "\n\n"); // Додати реєстр
                    }
                }
            }
        }
    }
}
