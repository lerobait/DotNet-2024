using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 
using Task_7.Models;
using System.Globalization; 

namespace Task_7
{
    public partial class MainForm : Form
    {
        private Database db; // Підключення до бази
        private List<Transport> transports; // Транспортні засоби
        private List<Route> routes; // Маршрути
        private List<RouteRegister> routeRegisters; // Реєстри маршрутів

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database(); 

            // Підписка на події
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged;
            comboBoxMode.SelectedIndexChanged += ComboBoxMode_SelectedIndexChanged;
            buttonCalculate.Click += ButtonCalculate_Click;

            // Початкові налаштування
            comboBoxMode.SelectedIndex = 0;
            LoadData(); // Завантаження даних
            InitializeStatisticsComboBox(); // Налаштування статистики
            UpdateView(); // Оновлення інтерфейсу
        }

        // Завантаження даних з бази
        private void LoadData()
        {
            try
            {
                transports = db.GetTransports();
                routes = db.GetRoutes();
                routeRegisters = db.GetRouteRegisters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробка зміни радіокнопок
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InitializeStatisticsComboBox();
            UpdateView();
        }

        // Обробка зміни режиму в комбобоксі
        private void ComboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeStatisticsComboBox();
            UpdateView();
        }

        // Налаштування комбобоксу статистики
        private void InitializeStatisticsComboBox()
        {
            comboBoxStatistics.Items.Clear();

            if (comboBoxMode.SelectedItem?.ToString() == "Статистика")
            {
                // Показати елементи статистики
                labelStatistics.Visible = true;
                comboBoxStatistics.Visible = true;
                buttonCalculate.Visible = true;
                labelResult.Visible = true;

                // Додати варіанти залежно від вибору категорії
                if (radioButtonTransport.Checked)
                {
                    comboBoxStatistics.Items.AddRange(new string[]
                    {
                        "Середня вартість проїзду",
                        "Транспорт з максимальною вартістю",
                        "Транспорт з мінімальною вартістю"
                    });
                }
                else if (radioButtonRoute.Checked)
                {
                    comboBoxStatistics.Items.AddRange(new string[]
                    {
                        "Середня довжина маршруту",
                        "Маршрут з максимальною довжиною",
                        "Маршрут з мінімальною довжиною"
                    });
                }
                else if (radioButtonRouteRegister.Checked)
                {
                    comboBoxStatistics.Items.AddRange(new string[]
                    {
                        "Загальна кількість рейсів",
                        "Найраніший час відправлення",
                        "Найпізніший час прибуття"
                    });
                }

                if (comboBoxStatistics.Items.Count > 0)
                    comboBoxStatistics.SelectedIndex = 0;
            }
            else
            {
                // Сховати елементи статистики
                labelStatistics.Visible = false;
                comboBoxStatistics.Visible = false;
                buttonCalculate.Visible = false;
                labelResult.Visible = false;
            }
        }

        // Оновлення відображення форми
        private void UpdateView()
        {
            if (comboBoxMode.SelectedItem == null) return;

            string mode = comboBoxMode.SelectedItem.ToString();

            if (mode == "Перегляд даних")
            {
                dataGridView.Visible = true;
                labelResult.Visible = false;

                // Відобразити відповідні дані
                if (radioButtonTransport.Checked)
                    dataGridView.DataSource = transports;
                else if (radioButtonRoute.Checked)
                    dataGridView.DataSource = routes;
                else if (radioButtonRouteRegister.Checked)
                    dataGridView.DataSource = routeRegisters;
            }
            else if (mode == "Статистика")
            {
                dataGridView.Visible = false;
                labelResult.Visible = true;
                labelResult.Text = "Результат:";
            }
        }

        // Обробка натискання кнопки розрахунку
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxStatistics.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть статистичну характеристику.");
                return;
            }

            string selectedStatistic = comboBoxStatistics.SelectedItem.ToString();

            // Виклик відповідного методу обробки
            if (radioButtonTransport.Checked)
                ProcessTransportStatistics(selectedStatistic);
            else if (radioButtonRoute.Checked)
                ProcessRouteStatistics(selectedStatistic);
            else if (radioButtonRouteRegister.Checked)
                ProcessRouteRegisterStatistics(selectedStatistic);
        }

        // Статистика для транспорту
        private void ProcessTransportStatistics(string statistic)
        {
            switch (statistic)
            {
                case "Середня вартість проїзду":
                    decimal avgFare = db.GetAverageFare();
                    labelResult.Text = $"Середня вартість проїзду: {avgFare.ToString("C", CultureInfo.GetCultureInfo("uk-UA"))}";
                    break;
                case "Транспорт з максимальною вартістю":
                    var maxTransport = db.GetTransportWithMaxFare();
                    labelResult.Text = maxTransport != null
                        ? $"Макс. транспорт: {maxTransport.Type} - {maxTransport.Fare.ToString("C", CultureInfo.GetCultureInfo("uk-UA"))}"
                        : "Дані відсутні.";
                    break;
                case "Транспорт з мінімальною вартістю":
                    var minTransport = db.GetTransportWithMinFare();
                    labelResult.Text = minTransport != null
                        ? $"Мін. транспорт: {minTransport.Type} - {minTransport.Fare.ToString("C", CultureInfo.GetCultureInfo("uk-UA"))}"
                        : "Дані відсутні.";
                    break;
            }
        }

        // Статистика для маршрутів
        private void ProcessRouteStatistics(string statistic)
        {
            switch (statistic)
            {
                case "Середня довжина маршруту":
                    decimal avgLength = db.GetAverageRouteLength();
                    labelResult.Text = $"Середня довжина маршруту: {avgLength} км";
                    break;
                case "Маршрут з максимальною довжиною":
                    var maxRoute = db.GetRouteWithMaxLength();
                    labelResult.Text = maxRoute != null
                        ? $"Макс. маршрут: {maxRoute.Length} км ({maxRoute.StartPoint} - {maxRoute.EndPoint})"
                        : "Дані відсутні.";
                    break;
                case "Маршрут з мінімальною довжиною":
                    var minRoute = db.GetRouteWithMinLength();
                    labelResult.Text = minRoute != null
                        ? $"Мін. маршрут: {minRoute.Length} км ({minRoute.StartPoint} - {minRoute.EndPoint})"
                        : "Дані відсутні.";
                    break;
            }
        }

        // Статистика для реєстрів маршрутів
        private void ProcessRouteRegisterStatistics(string statistic)
        {
            switch (statistic)
            {
                case "Загальна кількість рейсів":
                    int totalTrips = db.GetTotalTrips();
                    labelResult.Text = $"Загальна кількість рейсів: {totalTrips}";
                    break;
                case "Найраніший час відправлення":
                    TimeSpan earliest = db.GetEarliestDepartureTime();
                    labelResult.Text = $"Найраніший час відправлення: {earliest}";
                    break;
                case "Найпізніший час прибуття":
                    TimeSpan latest = db.GetLatestArrivalTime();
                    labelResult.Text = $"Найпізніший час прибуття: {latest}";
                    break;
            }
        }

        private void labelStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
