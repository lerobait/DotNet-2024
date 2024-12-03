using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Task_4 : Form
    {
        private int state = 0; // ������� ������� ����

        public Task_4()
        {
            InitializeComponent(); 
            timer.Start(); // ������ �������
        }

        private void PictureBoxUkraine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // ��������� ���������� ��'����

            // ��������� ������� ������
            int flagWidth = pictureBoxUkraine.Width;
            int flagHeight = pictureBoxUkraine.Height;

            g.FillRectangle(Brushes.Blue, new Rectangle(0, 0, flagWidth, flagHeight / 2)); // ���� �������
            g.FillRectangle(Brushes.Yellow, new Rectangle(0, flagHeight / 2, flagWidth, flagHeight / 2)); // ����� �������
        }

        private void PictureBoxJapan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // ��������� ���������� ��'����

            // ��������� ������� ����
            int flagWidth = pictureBoxJapan.Width;
            int flagHeight = pictureBoxJapan.Height;

            g.FillRectangle(Brushes.White, new Rectangle(0, 0, flagWidth, flagHeight)); // ����� ���

            int circleDiameter = Math.Min(flagWidth, flagHeight) / 2; // ĳ����� ����
            int x = (flagWidth - circleDiameter) / 2; // ���������� X ������
            int y = (flagHeight - circleDiameter) / 2; // ���������� Y ������
            g.FillEllipse(Brushes.Red, x, y, circleDiameter, circleDiameter); // ������� ����
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            state = (state + 1) % 2; // ����������� �����

            switch (state)
            {
                case 0: // ������ ���� ������ �� ������
                    pictureBoxJapan.Location = new Point(
                        pictureBoxUkraine.Left - pictureBoxJapan.Width - 10,
                        pictureBoxUkraine.Top
                    );
                    break;

                case 1: // ������ ���� ������ �� ������
                    pictureBoxJapan.Location = new Point(
                        pictureBoxUkraine.Left,
                        pictureBoxUkraine.Top - pictureBoxJapan.Height - 10
                    );
                    break;
            }

            pictureBoxJapan.Refresh(); // ��������� ������� ����
        }
    }
}
