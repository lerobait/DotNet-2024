using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Task_8 : Form
    {
        public Task_8()
        {
            InitializeComponent(); 
        }

        private void Form8_Paint(object sender, PaintEventArgs e)
        {
            // Дані для діаграми
            string[] peaks = { "Говерла", "Бребенескул", "Піп Іван", "Петрос", "Гутин-Томнатик", "Ребра" };
            float[] heights = { 2061, 2032, 2022, 2020, 2016, 2001 };
            float totalHeight = 0;

            foreach (var height in heights)
                totalHeight += height; // Загальна висота

            float startAngle = 0; // Початковий кут
            Color[] colors = { Color.Green, Color.Yellow, Color.Blue, Color.Red, Color.Purple, Color.Brown };

            // Малюємо сектори
            Graphics g = e.Graphics;
            Rectangle chartArea = new Rectangle(150, 100, 300, 300);
            for (int i = 0; i < peaks.Length; i++)
            {
                float sweepAngle = heights[i] / totalHeight * 360; // Кут сектора
                using (Brush brush = new SolidBrush(colors[i]))
                {
                    g.FillPie(brush, chartArea, startAngle, sweepAngle);
                }
                startAngle += sweepAngle;
            }

            // Легенда
            int legendX = 500, legendY = 120;
            for (int i = 0; i < peaks.Length; i++)
            {
                float percentage = (heights[i] / totalHeight) * 100; // Відсоток
                using (Brush brush = new SolidBrush(colors[i]))
                {
                    g.FillRectangle(brush, legendX, legendY + i * 30, 30, 20); // Кольоровий прямокутник
                }
                g.DrawRectangle(Pens.Black, legendX, legendY + i * 30, 30, 20);
                g.DrawString($"{peaks[i]} - {percentage:F2}% ({heights[i]} м)", new Font("Arial", 10), Brushes.Black, legendX + 40, legendY + i * 30);
            }

            // Заголовок
            g.DrawString("Розподіл висот Горних вершин України", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(180, 50));
        }
    }
}
