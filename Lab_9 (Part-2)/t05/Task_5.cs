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

            // ����� �����
            Pen turquoisePen = new Pen(Color.Turquoise, 5);
            g.DrawRectangle(turquoisePen, 10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);

            // ����� �����������
            Brush whiteBrush = new SolidBrush(Color.White);
            Rectangle whiteRect = new Rectangle(30, 80, this.ClientSize.Width - 60, this.ClientSize.Height - 130);
            g.FillRectangle(whiteBrush, whiteRect);

            // ����� "�����������"
            string title = "�����������";
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Brush titleBrush = new SolidBrush(Color.Black);
            SizeF titleSize = g.MeasureString(title, titleFont);
            float titleX = (this.ClientSize.Width - titleSize.Width) / 2; // ����� ������
            float titleY = whiteRect.Y - titleSize.Height - 30;           // ������� ������
            g.DrawString(title, titleFont, titleBrush, titleX, titleY);

            // �����������
            Pen grayPen = new Pen(Color.Gray, 5);

            // ������
            int squareWidth = 60;  // ������� ������
            int squareHeight = 60; // ������� ������
            int lineLength = 40;   // ������� �������
            int trapezoidOffset = 40; // �������� �������

            // �����������
            int squareX = whiteRect.X + (whiteRect.Width - squareWidth - lineLength - trapezoidOffset) / 2 + lineLength;
            int squareY = whiteRect.Y + (whiteRect.Height - squareHeight) / 2;

            // �������
            g.DrawRectangle(grayPen, squareX, squareY, squareWidth, squareHeight);

            // ��������
            g.DrawLine(grayPen, squareX - lineLength, squareY + 15, squareX, squareY + 15); // ������
            g.DrawLine(grayPen, squareX - lineLength, squareY + squareHeight - 15, squareX, squareY + squareHeight - 15); // �����

            // ��������
            Point[] trapezoidPoints = {
                new Point(squareX + squareWidth, squareY),                // ������ ������
                new Point(squareX + squareWidth + trapezoidOffset, squareY - 30),      // ������ ��������
                new Point(squareX + squareWidth + trapezoidOffset, squareY + squareHeight + 30), // ����� ��������
                new Point(squareX + squareWidth, squareY + squareHeight) // ����� ������
            };
            g.DrawPolygon(grayPen, trapezoidPoints);
        }
    }
}
