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
        private const int BallCount = 5; // Кількість кульок

        public Task_9()
        {
            InitializeComponent();
            InitializeBalls();
            InitializeTimer();
        }

        private void InitializeBalls()
        {
            balls = new Ball[BallCount];         // Масив кульок
            for (int i = 0; i < BallCount; i++)
            {
                int diameter = 40; // Однаковий діаметр кульок
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
                Interval = 20 // Інтервал таймера
            };
            timer.Tick += UpdateBalls;   // Обробка тіку таймера
            timer.Start();               // Запуск таймера
        }

        private void UpdateBalls(object sender, EventArgs e)
        {
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].Move(ClientSize);                    // Рух кульок
                for (int j = i + 1; j < balls.Length; j++)    // Перевірка зіткнень
                {
                    balls[i].CheckCollision(balls[j]);
                }
            }
            Invalidate();                                     // Оновлення форми
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                 // Малювання базового стану
            foreach (var ball in balls)
            {
                ball.Draw(e.Graphics);       // Малювання кульки
            }
        }
    }

    public class Ball
    {
        public double X { get; set; }     // Координата X
        public double Y { get; set; }     // Координата Y
        public int Diameter { get; }      // Діаметр кульки
        public Color Color { get; }       // Колір кульки
        public double Dx { get; set; }    // Швидкість X
        public double Dy { get; set; }    // Швидкість Y

        private static Random random = new Random();

        public Ball(double x, double y, int diameter, Color color, double dx, double dy)
        {
            X = x;                   // Початковий X
            Y = y;                   // Початковий Y
            Diameter = diameter;     // Діаметр
            Color = color;           // Колір
            Dx = dx;                 // Початковий Dx
            Dy = dy;                 // Початковий Dy
        }

        public void Move(Size clientSize)
        {
            X += Dx;                        // Переміщення X
            Y += Dy;                        // Переміщення Y

            // Відбивання від стінок
            if (X <= 0)
            {
                Dx = Math.Abs(Dx);          // Відбивання від лівої
                X = 0;
            }
            else if (X + Diameter >= clientSize.Width)
            {
                Dx = -Math.Abs(Dx);                             // Відбивання від правої
                X = clientSize.Width - Diameter;
            }

            if (Y <= 0)
            {
                Dy = Math.Abs(Dy);                              // Відбивання від верху
                Y = 0;
            }
            else if (Y + Diameter >= clientSize.Height)
            {
                Dy = -Math.Abs(Dy);                              // Відбивання від низу
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
                // Уникнення залипання
                double overlap = Diameter - distance;
                double correctionX = (overlap * dx) / distance / 2.0;
                double correctionY = (overlap * dy) / distance / 2.0;

                X += correctionX;              // Корекція X
                Y += correctionY;              // Корекція Y
                other.X -= correctionX;        
                other.Y -= correctionY;

                // Зміна напрямку
                double nx = dx / distance;
                double ny = dy / distance;

                // Швидк. в напрямку нормалі
                double p = 2 * (Dx * nx + Dy * ny - other.Dx * nx - other.Dy * ny) / 2; // Масова рівновага припускає однакову масу

                
                Dx = Dx - p * nx;                  // Швидкість після удару
                Dy = Dy - p * ny;
                other.Dx = other.Dx + p * nx;
                other.Dy = other.Dy + p * ny;

                // Додавання випадковості
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
