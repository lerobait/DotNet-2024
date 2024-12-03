using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditEmailForm : Form
    {
        private string username;

        // Ініціалізація форми
        public EditEmailForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentEmail(); // Завантаження поточного email
        }

        // Завантаження email користувача
        private void LoadCurrentEmail()
        {
            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == username)
                    {
                        emailTextBox.Text = parts[1];
                        break;
                    }
                }
            }
        }

        // Перевірка унікальності email
        private bool IsEmailTaken(string email)
        {
            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 2 && parts[1] == email && parts[0] != username)
                    {
                        return true; // Email вже існує і належить іншому користувачеві
                    }
                }
            }
            return false; // Email унікальний
        }

        // Збереження нового email
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newEmail = emailTextBox.Text.Trim();

            // Перевірка валідності email
            if (!Regex.IsMatch(newEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Невірний формат email.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка унікальності email
            if (IsEmailTaken(newEmail))
            {
                MessageBox.Show("Цей email вже використовується іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == username)
                    {
                        parts[1] = newEmail; // Оновлення email
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Email успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
