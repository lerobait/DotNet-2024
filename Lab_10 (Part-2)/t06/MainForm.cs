using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task_6.Models;

namespace Task_6
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

            // Підписка на події
            comboBoxMode.SelectedIndexChanged += ComboBoxMode_SelectedIndexChanged; // Зміна режиму
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged;
            buttonAction.Click += ButtonAction_Click; // Кнопка дія
            dataGridView.SelectionChanged += DataGridView_SelectionChanged; // Вибір рядка

            comboBoxMode.SelectedIndex = 0; // Вибір за замовчуванням
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(); // Завантажити дані
            UpdateView(); // Оновити вигляд
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

        private void UpdateView()
        {
            ClearInputFields(); // Очистити поля

            if (radioButtonTransport.Checked)
            {
                dataGridView.DataSource = transports; // Відобразити транспорти
                CreateInputFields(typeof(Transport)); // Поля вводу
            }
            else if (radioButtonRoute.Checked)
            {
                dataGridView.DataSource = routes; // Відобразити маршрути
                CreateInputFields(typeof(Route));
            }
            else if (radioButtonRouteRegister.Checked)
            {
                dataGridView.DataSource = routeRegisters; // Відобразити реєстри
                CreateInputFields(typeof(RouteRegister));
            }

            UpdateButtonText(); // Оновити кнопку
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Авто розмір колонок
        }

        private void CreateInputFields(Type type)
        {
            panelInputs.Controls.Clear();
            int x = 0; // Позиція X
            int y = 0; // Позиція Y
            int spacing = 10; // Відступ

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Label lbl = new Label
                {
                    Text = prop.Name,
                    Location = new System.Drawing.Point(x, y), // Розташування
                    Width = 100
                };
                panelInputs.Controls.Add(lbl); // Додати мітку

                Control inputControl;

                if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(string))
                {
                    TextBox textBox = new TextBox
                    {
                        Name = "input_" + prop.Name,
                        Location = new System.Drawing.Point(x + 110, y), // Розташування
                        Width = 150
                    };

                    // Якщо це поле ID і режим - "Додавання", дозволяємо вводити, інакше робимо поле тільки для читання
                    if (prop.Name.EndsWith("ID") && comboBoxMode.SelectedItem.ToString() != "Додавання")
                    {
                        textBox.ReadOnly = true;
                    }

                    panelInputs.Controls.Add(textBox);
                    inputControl = textBox;
                }
                else if (prop.PropertyType == typeof(TimeSpan))
                {
                    DateTimePicker timePicker = new DateTimePicker
                    {
                        Name = "input_" + prop.Name,
                        Location = new System.Drawing.Point(x + 110, y), // Розташування
                        Width = 150,
                        Format = DateTimePickerFormat.Time, // Формат часу
                        ShowUpDown = true // Стиль
                    };
                    panelInputs.Controls.Add(timePicker); // Додати вибір часу
                    inputControl = timePicker;
                }
                else
                {
                    continue; // Пропустити невідомий тип
                }

                y += inputControl.Height + spacing; // Збільшити Y
            }
        }

        private void UpdateButtonText()
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // Отримати режим
            buttonAction.Text = mode;
        }

        private void ComboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonText();
            ClearInputFields();
            UpdateView();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // Отримати режим

            try
            {
                if (mode == "Додавання")
                {
                    AddRecord(); // Додати запис
                }
                else if (mode == "Редагування")
                {
                    EditRecord(); // Редагувати запис
                }
                else if (mode == "Видалення")
                {
                    DeleteRecord(); // Видалити запис
                }

                LoadData();
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecord()
        {
            if (radioButtonTransport.Checked)
            {
                Transport transport = new Transport(); // Новий транспорт
                FillObjectFromInputs(transport); // Заповнити дані
                db.AddTransport(transport);
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = new Route(); // Новий маршрут
                FillObjectFromInputs(route);
                db.AddRoute(route);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = new RouteRegister(); // Новий реєстр
                FillObjectFromInputs(routeRegister);
                db.AddRouteRegister(routeRegister);
            }
        }

        private void EditRecord()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть запис для редагування.");
                return;
            }

            if (radioButtonTransport.Checked)
            {
                Transport transport = (Transport)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний транспорт
                FillObjectFromInputs(transport); // Заповнити дані
                db.UpdateTransport(transport);
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = (Route)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний маршрут
                FillObjectFromInputs(route);
                db.UpdateRoute(route);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = (RouteRegister)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний реєстр
                FillObjectFromInputs(routeRegister);
                db.UpdateRouteRegister(routeRegister);
            }
        }

        private void DeleteRecord()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть запис для видалення."); // Повідомлення
                return;
            }

            if (radioButtonTransport.Checked)
            {
                Transport transport = (Transport)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний транспорт
                db.DeleteTransport(transport.TransportID); // Видалити з бази
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = (Route)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний маршрут
                db.DeleteRoute(route.RouteID);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = (RouteRegister)dataGridView.SelectedRows[0].DataBoundItem; // Вибраний реєстр
                db.DeleteRouteRegister(routeRegister.RouteRegisterID);
            }
        }

        private void FillObjectFromInputs<T>(T obj)
        {
            var type = typeof(T); // Тип об'єкта
            var properties = type.GetProperties(); // Властивості

            foreach (var prop in properties)
            {
                var control = panelInputs.Controls["input_" + prop.Name]; // Контроль вводу

                if (control == null)
                    continue; // Пропустити

                if (control is TextBox textBox)
                {
                    string value = textBox.Text; // Отримати текст

                    if (prop.PropertyType == typeof(int))
                    {
                        if (int.TryParse(value, out int intValue))
                        {
                            prop.SetValue(obj, intValue); // Встановити int
                        }
                        else
                        {
                            throw new Exception($"Невірний формат для {prop.Name}. Очікується ціле число.");
                        }
                    }
                    else if (prop.PropertyType == typeof(decimal))
                    {
                        if (decimal.TryParse(value, out decimal decimalValue))
                        {
                            prop.SetValue(obj, decimalValue); // Встановити decimal
                        }
                        else
                        {
                            throw new Exception($"Невірний формат для {prop.Name}. Очікується число.");
                        }
                    }
                    else if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(obj, value); // Встановити string
                    }
                }
                else if (control is DateTimePicker timePicker)
                {
                    if (prop.PropertyType == typeof(TimeSpan))
                    {
                        prop.SetValue(obj, timePicker.Value.TimeOfDay); // Встановити TimeSpan
                    }
                }
            }
        }

        private void ClearInputFields()
        {
            foreach (Control control in panelInputs.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Очистити текстове поле
                }
                else if (control is DateTimePicker timePicker)
                {
                    timePicker.Value = DateTime.Now; // Скинути час
                }
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // Отримати режим
            if ((mode == "Редагування" || mode == "Видалення") && dataGridView.SelectedRows.Count > 0)
            {
                LoadSelectedRecordIntoInputs(); // Завантажити запис
            }
        }

        private void LoadSelectedRecordIntoInputs()
        {
            object selectedItem = dataGridView.SelectedRows[0].DataBoundItem; // Вибраний запис
            var type = selectedItem.GetType(); // Тип запису
            var properties = type.GetProperties(); // Властивості

            foreach (var prop in properties)
            {
                var control = panelInputs.Controls["input_" + prop.Name]; // Контроль вводу

                if (control == null)
                    continue; // Пропустити

                var value = prop.GetValue(selectedItem); // Значення властивості

                if (control is TextBox textBox)
                {
                    textBox.Text = value?.ToString(); // Встановити текст
                }
                else if (control is DateTimePicker timePicker)
                {
                    if (value is TimeSpan timeSpan)
                    {
                        timePicker.Value = DateTime.Today.Add(timeSpan); // Встановити час
                    }
                }
            }
        }

        private void buttonAction_Click_1(object sender, EventArgs e)
        {

        }
    }
}
