using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditPhoneForm : Form
    {
        private string username;

        // Ініціалізація форми
        public EditPhoneForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadCurrentPhone(); // Завантаження поточного номера телефону
        }

        // Завантаження телефону
        private void LoadCurrentPhone()
        {
            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == username) // Пошук даних користувача
                    {
                        phoneTextBox.Text = parts[2]; // Встановлення номера телефону
                        break;
                    }
                }
            }
        }

        // Перевірка унік. номера телефону
        private bool IsPhoneTaken(string phone)
        {
            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3 && parts[2] == phone && parts[0] != username)
                    {
                        return true; // Номер телефону вже використовується
                    }
                }
            }
            return false; // Номер телефону унікальний
        }

        // Збереження нового номера
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newPhone = phoneTextBox.Text.Trim();

            // Перевірка формату номера
            if (!Regex.IsMatch(newPhone, @"^\+?\d{10,15}$"))
            {
                MessageBox.Show("Некоректний формат номера телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка унікальності номера
            if (IsPhoneTaken(newPhone))
            {
                MessageBox.Show("Цей номер телефону вже використовується іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Оновлення номера у файлі
            string filePath = "userdata.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == username) // Пошук користувача
                    {
                        parts[2] = newPhone; // Оновлення номера 
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Номер телефону успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
