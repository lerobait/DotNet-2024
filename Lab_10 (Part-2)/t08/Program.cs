using System;
using System.Windows.Forms;

namespace Lab__12
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Запускаємо форму-заставку
            Application.Run(new SplashForm());
        }
    }
}
