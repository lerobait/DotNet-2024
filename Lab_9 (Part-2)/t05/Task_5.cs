using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Task_5 : Form
    {
        public Task_5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рамка форми
            Pen turquoisePen = new Pen(Color.Turquoise, 5);
            g.DrawRectangle(turquoisePen, 10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);

            // Білий прямокутник
            Brush whiteBrush = new SolidBrush(Color.White);
            Rectangle whiteRect = new Rectangle(30, 80, this.ClientSize.Width - 60, this.ClientSize.Height - 130);
            g.FillRectangle(whiteBrush, whiteRect);

            // Текст "Гучномовець"
            string title = "Гучномовець";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Brush titleBrush = new SolidBrush(Color.Black);
            SizeF titleSize = g.MeasureString(title, titleFont);
            float titleX = (this.ClientSize.Width - titleSize.Width) / 2; // Центр тексту
            float titleY = whiteRect.Y - titleSize.Height - 30;           // Позиція тексту
            g.DrawString(title, titleFont, titleBrush, titleX, titleY);

            // Гучномовець
            Pen grayPen = new Pen(Color.Gray, 5);

            // Розміри
            int squareWidth = 60;  // Квадрат ширина
            int squareHeight = 60; // Квадрат висота
            int lineLength = 40;   // Довжина проводів
            int trapezoidOffset = 40; // Трапеція зміщення

            // Центрування
            int squareX = whiteRect.X + (whiteRect.Width - squareWidth - lineLength - trapezoidOffset) / 2 + lineLength;
            int squareY = whiteRect.Y + (whiteRect.Height - squareHeight) / 2;

            // Квадрат
            g.DrawRectangle(grayPen, squareX, squareY, squareWidth, squareHeight);

            // Проводка
            g.DrawLine(grayPen, squareX - lineLength, squareY + 15, squareX, squareY + 15); // Верхня
            g.DrawLine(grayPen, squareX - lineLength, squareY + squareHeight - 15, squareX, squareY + squareHeight - 15); // Нижня

            // Трапеція
            Point[] trapezoidPoints = {
                new Point(squareX + squareWidth, squareY),                // Верхній правий
                new Point(squareX + squareWidth + trapezoidOffset, squareY - 30),      // Верхній трапеції
                new Point(squareX + squareWidth + trapezoidOffset, squareY + squareHeight + 30), // Нижній трапеції
                new Point(squareX + squareWidth, squareY + squareHeight) // Нижній правий
            };
            g.DrawPolygon(grayPen, trapezoidPoints);
        }
    }
}
