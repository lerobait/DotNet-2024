using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Task_6 : Form
    {
        private Random random = new Random(); // Генератор випадкових чисел
        private double[] currencyValues; // Массив валютних значень

        public Task_6()
        {
            InitializeComponent();    
            GenerateRandomValues(); 
        }

        private void GenerateRandomValues()
        {
            // Генерація 15-20 випадкових значень [30.00, 32.00]
            int count = random.Next(15, 21);
            currencyValues = new double[count];
            for (int i = 0; i < count; i++)
                currencyValues[i] = Math.Round(30.00 + random.NextDouble() * 2.00, 2);
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Графічний об'єкт
            g.Clear(Color.White); // Очищення

            // Знаходимо min/max значення
            double max = Math.Ceiling(currencyValues[0]);
            double min = Math.Floor(currencyValues[0]);
            foreach (var value in currencyValues)
            {
                if (value > max) max = Math.Ceiling(value);
                if (value < min) min = Math.Floor(value);
            }

            // Висота і ширина графіка
            int chartHeight = panelChart.Height - 100;
            int chartWidth = panelChart.Width - 100;

            // Малюємо осі
            g.DrawLine(Pens.Black, 50, 50, 50, panelChart.Height - 50); // Вертикальна
            g.DrawLine(Pens.Black, 50, panelChart.Height - 50, panelChart.Width - 50, panelChart.Height - 50); // Горизонтальна

            // Розмітка осі Y
            int stepY = chartHeight / 10;
            for (int i = 0; i <= 10; i++)
            {
                double value = min + (max - min) * i / 10.0;
                int y = (int)(panelChart.Height - 50 - i * stepY);
                g.DrawLine(Pens.Gray, 45, y, 50, y);
                g.DrawString(value.ToString("F2"), new Font("Arial", 8), Brushes.Black, 5, y - 8);
            }

            // Обчислення точок графіка
            Point[] points = new Point[currencyValues.Length];
            int stepX = chartWidth / (currencyValues.Length - 1);

            for (int i = 0; i < currencyValues.Length; i++)
            {
                int x = 50 + i * stepX;
                int y = (int)(panelChart.Height - 50 - (currencyValues[i] - min) / (max - min) * chartHeight);
                points[i] = new Point(x, y);
                g.DrawString(currencyValues[i].ToString("F2"), new Font("Arial", 8), Brushes.Black, x - 15, y - 20);
            }

            // Лінія графіка
            Pen pen = new Pen(Color.Gray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            g.DrawLines(pen, points);

            // Точки графіка
            foreach (var point in points)
                g.FillRectangle(Brushes.Black, point.X - 2, point.Y - 2, 4, 4);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Оновлення даних і графіка
            GenerateRandomValues();
            panelChart.Invalidate();
        }
    }
}
