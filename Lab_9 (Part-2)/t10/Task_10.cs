using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Task_10 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Ball[] balls;
        private Random random = new Random();

        // Поля налаштувань
        private int ballCount = 5;
        private int ballDiameter = 40;
        private int speed = 10;
        private List<Color> ballColors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple };

        public Task_10()
        {
            InitializeComponent(); 
            InitializeBalls();    
            InitializeTimer();    
        }

        private void InitializeBalls()
        {
            if (ballColors.Count < ballCount)
            {
                // Додавання кольорів
                while (ballColors.Count < ballCount)
                {
                    Color newColor = GetRandomColor();
                    if (!ballColors.Contains(newColor))
                    {
                        ballColors.Add(newColor);
                    }
                }
            }
            else if (ballColors.Count > ballCount)
            {
                // Вибір кольорів
                ballColors = ballColors.OrderBy(x => random.Next()).Take(ballCount).ToList();
            }

            balls = new Ball[ballCount];
            List<Color> shuffledColors = new List<Color>(ballColors);
            shuffledColors = shuffledColors.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < ballCount; i++)
            {
                // Створення кульки
                int diameter = ballDiameter;
                Color color = shuffledColors[i];
                double dx = GetRandomSpeed();
                double dy = GetRandomSpeed();
                if (dx == 0) dx = 1;
                if (dy == 0) dy = 1;

                balls[i] = new Ball(
                    x: random.Next(50, this.ClientSize.Width - 50 - ballDiameter),
                    y: random.Next(50, this.ClientSize.Height - 50 - ballDiameter),
                    diameter: diameter,
                    color: color,
                    dx: dx,
                    dy: dy,
                    speed: speed
                );
            }
        }

        private double GetRandomSpeed()
        {
            // Швидкість кульки
            double s = 0;
            while (s == 0)
            {
                s = random.NextDouble() * (speed - 1) + 1;
                if (random.Next(2) == 0)
                    s = -s;
            }
            return s;
        }

        private Color GetRandomColor()
        {
            // Випадковий колір
            Color newColor;
            do
            {
                newColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
            while (ballColors.Contains(newColor));
            return newColor;
        }

        private void InitializeTimer()
        {
            // Налаштування таймера
            timer = new System.Windows.Forms.Timer
            {
                Interval = 20
            };
            timer.Tick += UpdateBalls;
            timer.Start();
        }

        private void UpdateBalls(object sender, EventArgs e)
        {
            // Оновлення кульок
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].Move(this.ClientSize);
                for (int j = i + 1; j < balls.Length; j++)
                {
                    balls[i].CheckCollision(balls[j]);
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Малювання кульок
            base.OnPaint(e);
            foreach (var ball in balls)
            {
                ball.Draw(e.Graphics);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            // Завантаження форми
            base.OnLoad(e);
            Button btnSettings = new Button
            {
                Text = "Налаштування",
                Location = new Point(this.ClientSize.Width - 120, 10),
                Size = new Size(100, 30),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnSettings.Click += BtnSettings_Click;
            Controls.Add(btnSettings);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // Обробка кнопки
            timer.Stop();
            using (SettingsForm settingsForm = new SettingsForm(ballCount, ballDiameter, speed, ballColors))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    ballCount = settingsForm.BallCount;
                    ballDiameter = settingsForm.Diameter;
                    speed = settingsForm.Speed;
                    ballColors = settingsForm.Colors.Distinct().ToList();
                    InitializeBalls();
                }
            }
            timer.Start();
        }

        private class Ball
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Diameter { get; }
            public Color Color { get; }
            public double Dx { get; set; }
            public double Dy { get; set; }

            private static Random random = new Random();
            private double speed;

            public Ball(int x, int y, int diameter, Color color, double dx, double dy, double speed)
            {
                // Конструктор
                X = x;
                Y = y;
                Diameter = diameter;
                Color = color;
                Dx = dx;
                Dy = dy;
                this.speed = speed;
            }

            public void Move(Size clientSize)
            {
                // Рух кульки
                X += (int)Math.Round(Dx);
                Y += (int)Math.Round(Dy);

                if (X <= 0 || X + Diameter >= clientSize.Width)
                {
                    Dx = -Dx;
                    X = Math.Max(0, Math.Min(X, clientSize.Width - Diameter));
                }
                if (Y <= 0 || Y + Diameter >= clientSize.Height)
                {
                    Dy = -Dy;
                    Y = Math.Max(0, Math.Min(Y, clientSize.Height - Diameter));
                }
            }

            public void CheckCollision(Ball other)
            {
                // Перевірка зіткнення
                double dx = (X + Diameter / 2.0) - (other.X + other.Diameter / 2.0);
                double dy = (Y + Diameter / 2.0) - (other.Y + other.Diameter / 2.0);
                double distance = Math.Sqrt(dx * dx + dy * dy);

                if (distance < Diameter)
                {
                    double overlap = Diameter - distance;
                    double correctionX = (overlap * dx) / distance / 2.0;
                    double correctionY = (overlap * dy) / distance / 2.0;

                    X += (int)Math.Round(correctionX);
                    Y += (int)Math.Round(correctionY);
                    other.X -= (int)Math.Round(correctionX);
                    other.Y -= (int)Math.Round(correctionY);

                    double nx = dx / distance;
                    double ny = dy / distance;

                    double tx = -ny;
                    double ty = nx;

                    double v1n = Dx * nx + Dy * ny;
                    double v1t = Dx * tx + Dy * ty;
                    double v2n = other.Dx * nx + other.Dy * ny;
                    double v2t = other.Dx * tx + other.Dy * ty;

                    double v1nAfter = v2n;
                    double v2nAfter = v1n;

                    Dx = v1nAfter * nx + v1t * tx;
                    Dy = v1nAfter * ny + v1t * ty;
                    other.Dx = v2nAfter * nx + v2t * tx;
                    other.Dy = v2nAfter * ny + v2t * ty;

                    AdjustSpeed();
                    other.AdjustSpeed();
                }
            }

            private void AdjustSpeed()
            {
                // Швидкість після зіткнення
                double currentSpeed = Math.Sqrt(Dx * Dx + Dy * Dy);
                if (currentSpeed < 1.0)
                {
                    if (currentSpeed == 0)
                    {
                        double angle = random.NextDouble() * 2 * Math.PI;
                        Dx = 1.0 * Math.Cos(angle);
                        Dy = 1.0 * Math.Sin(angle);
                    }
                    else
                    {
                        double scale = 1.0 / currentSpeed;
                        Dx *= scale;
                        Dy *= scale;
                    }
                }
            }

            public void Draw(Graphics g)
            {
                // Малювання кульки
                using (Brush brush = new SolidBrush(Color))
                {
                    g.FillEllipse(brush, X, Y, Diameter, Diameter);
                }
            }
        }
    }
}
