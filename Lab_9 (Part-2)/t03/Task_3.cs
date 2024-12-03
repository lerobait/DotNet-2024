using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Task_3 : Form
    {
        public Task_3()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Отримання графічного об'єкта

            // Малювання прапора України
            int flagWidth = pictureBox1.Width;
            int flagHeight = pictureBox1.Height;

            g.FillRectangle(Brushes.Blue, new Rectangle(0, 0, flagWidth, flagHeight / 2)); // Верхня синя частина
            g.FillRectangle(Brushes.Yellow, new Rectangle(0, flagHeight / 2, flagWidth, flagHeight / 2)); // Нижня жовта частина
        }

        private void pictureBoxJapan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Отримання графічного об'єкта

            // Малювання прапора Японії
            int flagWidth = pictureBoxJapan.Width;
            int flagHeight = pictureBoxJapan.Height;

            g.FillRectangle(Brushes.White, new Rectangle(0, 0, flagWidth, flagHeight)); // Білий фон

            // Червоне коло в центрі
            int circleDiameter = Math.Min(flagWidth, flagHeight) / 2;
            int x = (flagWidth - circleDiameter) / 2;
            int y = (flagHeight - circleDiameter) / 2;
            g.FillEllipse(Brushes.Red, x, y, circleDiameter, circleDiameter); // Червоне коло
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxJapan.Visible = true; // Показати прапор Японії
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBoxJapan.Visible = false; // Сховати прапор Японії
            }
        }
    }
}
