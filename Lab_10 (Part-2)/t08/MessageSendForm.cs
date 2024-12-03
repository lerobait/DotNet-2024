using System;
using System.IO;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageSendForm : Form
    {
        private string senderUsername;

        public MessageSendForm(string senderUsername)
        {
            InitializeComponent();
            this.senderUsername = senderUsername;
        }

        // Відправка повідомлення
        private void SendButton_Click(object sender, EventArgs e)
        {
            string recipient = toTextBox.Text.Trim();
            string theme = themeTextBox.Text.Trim();
            string text = messageTextBox.Text.Trim();

            // Перевірка заповнення
            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(theme) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка отримувача
            if (!UserExists(recipient))
            {
                MessageBox.Show("Отримувач не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження у файл
            string filePath = $"messages_{recipient}.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"From: {senderUsername}");
                sw.WriteLine($"Theme: {theme}");
                sw.WriteLine($"Text: {text}");
                sw.WriteLine($"Date: {DateTime.Now}");
                sw.WriteLine("-----");
            }

            MessageBox.Show("Повідомлення відправлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Перевірка існування користувача
        private bool UserExists(string username)
        {
            string filePath = "users.txt";
            if (File.Exists(filePath))
            {
                string[] userLines = File.ReadAllLines(filePath);
                foreach (string line in userLines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
