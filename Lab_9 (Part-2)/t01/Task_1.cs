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
            Graphics g = e.Graphics; // ��������� ����. ��'����

            // ������ PictureBox
            int pictureBoxWidth = pictureBox1.ClientSize.Width;
            int pictureBoxHeight = pictureBox1.ClientSize.Height;

            // ����� ������� 
            int flagWidth = pictureBoxWidth / 4;
            int flagHeight = pictureBoxHeight / 4;

            // ���������� ������� 
            int x = pictureBoxWidth - flagWidth - 10;
            int y = pictureBoxHeight - flagHeight - 10;

            // ��������� ������� ������
            g.FillRectangle(Brushes.Blue, new Rectangle(x, y, flagWidth, flagHeight / 2)); // ���� �������
            g.FillRectangle(Brushes.Yellow, new Rectangle(x, y + flagHeight / 2, flagWidth, flagHeight / 2)); // ����� �������
        }
    }
}
