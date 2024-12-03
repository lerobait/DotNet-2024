using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Отримання граф. об'єкта

            // Розміри PictureBox
            int pictureBoxWidth = pictureBox1.ClientSize.Width;
            int pictureBoxHeight = pictureBox1.ClientSize.Height;

            // Розмір прапора 
            int flagWidth = pictureBoxWidth / 4;
            int flagHeight = pictureBoxHeight / 4;

            // Координати прапора 
            int x = pictureBoxWidth - flagWidth - 10;
            int y = pictureBoxHeight - flagHeight - 10;

            // Малювання прапора України
            g.FillRectangle(Brushes.Blue, new Rectangle(x, y, flagWidth, flagHeight / 2)); // Синя частина
            g.FillRectangle(Brushes.Yellow, new Rectangle(x, y + flagHeight / 2, flagWidth, flagHeight / 2)); // Жовта частина
        }
    }
}
