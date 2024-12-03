using System;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            // Таймер на 3 секунди
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Зупинка таймера
            (sender as System.Windows.Forms.Timer).Stop();
            // Відкриття LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            // Приховуємо цю форму
            this.Hide();
        }
    }
}
