using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Task_7 : Form
    {
        public Task_7()
        {
            InitializeComponent();
            GenerateTextGraph();   // ��������� ���������� �������
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;  // ��������� ��'���
            g.Clear(Color.White);     // ��������

            // ��������� ����
            double xMin = 0, xMax = 20;
            double yMin = -2, yMax = 2;
            double scaleX = (graphPanel.Width - 150) / (xMax - xMin); // ���. ������ ��� �� X
            double scaleY = (graphPanel.Height - 60) / (yMax - yMin); // ��������� �������
            int xOffset = 50; // ³����� ����
            int yOffset = (int)(yMax * scaleY + 30); // ������� ��� �� Y

            // ������� ��
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, xOffset, yOffset, graphPanel.Width - 70, yOffset); // ��������� ��� X
            g.DrawLine(axisPen, xOffset, 10, xOffset, graphPanel.Height - 25); // ³�� Y (� �������� ������)

            // ϳ����� ��� ����
            Font axisFont = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;

            // ϳ���� �� X
            g.DrawString("X", axisFont, textBrush, graphPanel.Width - 80, yOffset + 10); 

            // ϳ���� �� Y
            g.DrawString("Y", axisFont, textBrush, xOffset - 25, 10); 

            // ������� ���� �� �� X
            for (double x = xMin; x <= xMax; x += 2)
            {
                int screenX = xOffset + (int)((x - xMin) * scaleX);
                g.DrawLine(Pens.Black, screenX, yOffset - 5, screenX, yOffset + 5); // �������� �����
                g.DrawString(x.ToString("0"), axisFont, textBrush, screenX - 10, yOffset + 10); // �����
            }

            // ������� ���� �� �� Y
            for (double y = yMin; y <= yMax; y += 1)
            {
                int screenY = (int)(yOffset - y * scaleY);
                g.DrawLine(Pens.Black, xOffset - 5, screenY, xOffset + 5, screenY); // �������� �����
                g.DrawString(y.ToString("0"), axisFont, textBrush, xOffset - 30, screenY - 8); // �����
            }

            // ������� ������
            Pen graphPen = new Pen(Color.Blue, 2);
            for (double x = xMin; x < xMax; x += 0.01)
            {
                double y1 = CalculateY(x);
                double y2 = CalculateY(x + 0.01);
                int screenX1 = xOffset + (int)((x - xMin) * scaleX);
                int screenY1 = (int)(yOffset - y1 * scaleY);
                int screenX2 = xOffset + (int)(((x + 0.01) - xMin) * scaleX);
                int screenY2 = (int)(yOffset - y2 * scaleY);
                g.DrawLine(graphPen, screenX1, screenY1, screenX2, screenY2);
            }
        }

        private void GenerateTextGraph()
        {
            textBoxOutput.Clear();
            textBoxOutput.AppendText("|         x         |              y           |\n");
            textBoxOutput.AppendText("|-------------|------------------|\n");
            for (double x = 0; x <= 20; x += 0.25)
            {
                double y = CalculateY(x);
                textBoxOutput.AppendText($"| {x,7:0.00}        | {y,15:0.0000}      |\n");
            }
        }

        private double CalculateY(double x)
        {
            // ������� ��� ���������� Y
            if (x % 4 < 1)
                return 2 * (x % 4) - 1; // ������ �������
            else if (x % 4 < 3)
                return 1 - Math.Sqrt(1 - Math.Pow((x % 4) - 2, 2)); // ������ �������
            else
                return 7 - 2 * (x % 4); // ����� �������
        }
    }
}
