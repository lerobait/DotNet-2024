using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditNameForm : Form
    {
        private string username;
        public string NewUsername { get; private set; }

        // Ініціалізація форми
        public EditNameForm(string username)
        {
            InitializeComponent();
            this.username = username;
            nameTextBox.Text = username; // Заповнення поточного імені
        }

        // Збереження нового імені
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newUsername = nameTextBox.Text.Trim();

            // Перевірка валідності нового імені
            if (!Regex.IsMatch(newUsername, @"^[a-zA-Z0-9]{1,15}$"))
            {
                MessageBox.Show("Невірне ім'я. Використовуйте тільки літери та цифри (макс. 15 символів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка на збіг з поточним ім'ям
            if (username == newUsername)
            {
                MessageBox.Show("Нове ім'я співпадає з поточним.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            // Перевірка на зайнятість імені
            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Ім'я вже зайняте. Оберіть інше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Оновлення даних у файлах
            UpdateUsernameInFile("users.txt", username, newUsername);
            UpdateUsernameInFile("userdata.txt", username, newUsername);

            // Перейменування файлу повідомлень
            string oldMessageFile = $"messages_{username}.txt";
            string newMessageFile = $"messages_{newUsername}.txt";
            if (File.Exists(oldMessageFile))
            {
                File.Move(oldMessageFile, newMessageFile);
            }

            MessageBox.Show("Ім'я успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.NewUsername = newUsername; // Збереження нового імені
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Оновлення імені у файлі
        private void UpdateUsernameInFile(string filePath, string oldUsername, string newUsername)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == oldUsername)
                    {
                        parts[0] = newUsername;
                        lines[i] = string.Join(",", parts);
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
        }

        // Перевірка, чи зайняте ім'я
        private bool IsUsernameTaken(string newUsername)
        {
            string filePath = "users.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == newUsername)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
