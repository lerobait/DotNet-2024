using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Task_9 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Ball[] balls;
        private Random random = new Random();
        private const int BallCount = 5; // ʳ������ ������

        public Task_9()
        {
            InitializeComponent();
            InitializeBalls();
            InitializeTimer();
        }

        private void InitializeBalls()
        {
            balls = new Ball[BallCount];         // ����� ������
            for (int i = 0; i < BallCount; i++)
            {
                int diameter = 40; // ��������� ������ ������
                balls[i] = new Ball(
                    x: random.Next(50, ClientSize.Width - 50),
                    y: random.Next(50, ClientSize.Height - 50),
                    diameter: diameter,
                    color: Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)),
                    dx: random.Next(-10, 11),
                    dy: random.Next(-10, 11)
                );
            }
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 20 // �������� �������
            };
            timer.Tick += UpdateBalls;   // ������� ��� �������
            timer.Start();               // ������ �������
        }

        private void UpdateBalls(object sender, EventArgs e)
        {
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].Move(ClientSize);                    // ��� ������
                for (int j = i + 1; j < balls.Length; j++)    // �������� �������
                {
                    balls[i].CheckCollision(balls[j]);
                }
            }
            Invalidate();                                     // ��������� �����
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                 // ��������� �������� �����
            foreach (var ball in balls)
            {
                ball.Draw(e.Graphics);       // ��������� ������
            }
        }
    }

    public class Ball
    {
        public double X { get; set; }     // ���������� X
        public double Y { get; set; }     // ���������� Y
        public int Diameter { get; }      // ĳ����� ������
        public Color Color { get; }       // ���� ������
        public double Dx { get; set; }    // �������� X
        public double Dy { get; set; }    // �������� Y

        private static Random random = new Random();

        public Ball(double x, double y, int diameter, Color color, double dx, double dy)
        {
            X = x;                   // ���������� X
            Y = y;                   // ���������� Y
            Diameter = diameter;     // ĳ�����
            Color = color;           // ����
            Dx = dx;                 // ���������� Dx
            Dy = dy;                 // ���������� Dy
        }

        public void Move(Size clientSize)
        {
            X += Dx;                        // ���������� X
            Y += Dy;                        // ���������� Y

            // ³�������� �� �����
            if (X <= 0)
            {
                Dx = Math.Abs(Dx);          // ³�������� �� ���
                X = 0;
            }
            else if (X + Diameter >= clientSize.Width)
            {
                Dx = -Math.Abs(Dx);                             // ³�������� �� �����
                X = clientSize.Width - Diameter;
            }

            if (Y <= 0)
            {
                Dy = Math.Abs(Dy);                              // ³�������� �� �����
                Y = 0;
            }
            else if (Y + Diameter >= clientSize.Height)
            {
                Dy = -Math.Abs(Dy);                              // ³�������� �� ����
                Y = clientSize.Height - Diameter;
            }
        }

        public void CheckCollision(Ball other)
        {
            double dx = (X + Diameter / 2.0) - (other.X + other.Diameter / 2.0);
            double dy = (Y + Diameter / 2.0) - (other.Y + other.Diameter / 2.0);
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance < Diameter)
            {
                // ��������� ���������
                double overlap = Diameter - distance;
                double correctionX = (overlap * dx) / distance / 2.0;
                double correctionY = (overlap * dy) / distance / 2.0;

                X += correctionX;              // �������� X
                Y += correctionY;              // �������� Y
                other.X -= correctionX;        
                other.Y -= correctionY;

                // ���� ��������
                double nx = dx / distance;
                double ny = dy / distance;

                // �����. � �������� ������
                double p = 2 * (Dx * nx + Dy * ny - other.Dx * nx - other.Dy * ny) / 2; // ������ �������� �������� �������� ����

                
                Dx = Dx - p * nx;                  // �������� ���� �����
                Dy = Dy - p * ny;
                other.Dx = other.Dx + p * nx;
                other.Dy = other.Dy + p * ny;

                // ��������� �����������
                Dx += (random.NextDouble() - 0.5) * 0.1;
                Dy += (random.NextDouble() - 0.5) * 0.1;
                other.Dx += (random.NextDouble() - 0.5) * 0.1;
                other.Dy += (random.NextDouble() - 0.5) * 0.1;
            }
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, (float)X, (float)Y, Diameter, Diameter);
            }
        }
    }
}
