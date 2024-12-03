using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class EditPasswordForm : Form
    {
        private string username;

        // Ініціалізація форми
        public EditPasswordForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        // Обробка натискання кнопки Зберегти
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // Перевірка полів на коректність
            string errorMessage = ValidateFields(currentPassword, newPassword, confirmPassword);

            if (string.IsNullOrEmpty(errorMessage))
            {
                // Оновлення пароля у файлі
                if (UpdatePasswordInFile("users.txt", username, currentPassword, newPassword))
                {
                    MessageBox.Show("Пароль успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірний поточний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Перевірка введених даних
        private string ValidateFields(string currentPassword, string newPassword, string confirmPassword)
        {
            string error = "";

            if (string.IsNullOrEmpty(currentPassword))
                error += "Введіть поточний пароль.\n";

            if (!Regex.IsMatch(newPassword, @"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{12,}$"))
                error += "Новий пароль має бути мінімум 12 символів і включати літери, цифри та спеціальні символи.\n";

            if (newPassword != confirmPassword)
                error += "Нові паролі не співпадають.\n";

            return error;
        }

        // Оновлення пароля у файлі
        private bool UpdatePasswordInFile(string filePath, string username, string currentPassword, string newPassword)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                bool isUpdated = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == username)
                    {
                        if (parts[1] == currentPassword) // Перевірка поточного пароля
                        {
                            parts[1] = newPassword; // Оновлення пароля
                            lines[i] = string.Join(",", parts);
                            isUpdated = true;
                            break;
                        }
                        else
                        {
                            return false; // Невірний поточний пароль
                        }
                    }
                }
                if (isUpdated)
                {
                    File.WriteAllLines(filePath, lines);
                    return true;
                }
            }
            return false;
        }
    }
}
