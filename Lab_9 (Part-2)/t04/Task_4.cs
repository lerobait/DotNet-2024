using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Task_4 : Form
    {
        private int state = 0; // Позиція прапора Японії

        public Task_4()
        {
            InitializeComponent(); 
            timer.Start(); // Запуск таймера
        }

        private void PictureBoxUkraine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Отримання графічного об'єкта

            // Малювання прапора України
            int flagWidth = pictureBoxUkraine.Width;
            int flagHeight = pictureBoxUkraine.Height;

            g.FillRectangle(Brushes.Blue, new Rectangle(0, 0, flagWidth, flagHeight / 2)); // Синя частина
            g.FillRectangle(Brushes.Yellow, new Rectangle(0, flagHeight / 2, flagWidth, flagHeight / 2)); // Жовта частина
        }

        private void PictureBoxJapan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Отримання графічного об'єкта

            // Малювання прапора Японії
            int flagWidth = pictureBoxJapan.Width;
            int flagHeight = pictureBoxJapan.Height;

            g.FillRectangle(Brushes.White, new Rectangle(0, 0, flagWidth, flagHeight)); // Білий фон

            int circleDiameter = Math.Min(flagWidth, flagHeight) / 2; // Діаметр кола
            int x = (flagWidth - circleDiameter) / 2; // Координата X центру
            int y = (flagHeight - circleDiameter) / 2; // Координата Y центру
            g.FillEllipse(Brushes.Red, x, y, circleDiameter, circleDiameter); // Червоне коло
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            state = (state + 1) % 2; // Перемикання стану

            switch (state)
            {
                case 0: // Прапор Японії ліворуч від України
                    pictureBoxJapan.Location = new Point(
                        pictureBoxUkraine.Left - pictureBoxJapan.Width - 10,
                        pictureBoxUkraine.Top
                    );
                    break;

                case 1: // Прапор Японії зверху від України
                    pictureBoxJapan.Location = new Point(
                        pictureBoxUkraine.Left,
                        pictureBoxUkraine.Top - pictureBoxJapan.Height - 10
                    );
                    break;
            }

            pictureBoxJapan.Refresh(); // Оновлення прапора Японії
        }
    }
}
