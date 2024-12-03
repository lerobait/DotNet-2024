using System;
using System.IO;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageReceiveForm : Form
    {
        private string username; 

        public MessageReceiveForm(string username)
        {
            InitializeComponent();
            this.username = username; 
            LoadMessages(); 
        }

        private void LoadMessages()
        {
            string filePath = $"messages_{username}.txt"; // Шлях до файлу
            if (File.Exists(filePath)) // Якщо файл існує
            {
                string[] allMessages = File.ReadAllText(filePath)
                                           .Split(new[] { "-----" }, StringSplitOptions.RemoveEmptyEntries); // Розділення повідомлень
                foreach (string message in allMessages) // Перебір повідомлень
                {
                    string[] lines = message.Trim().Split('\n'); // Розбивка на рядки
                    if (lines.Length > 1) // Якщо є тема
                    {
                        string theme = lines[1].Replace("Theme: ", "").Trim(); // Виділення теми
                        messagesListBox.Items.Add(theme); // Додати в список
                        messagesListBox.Tag = allMessages; // Зберегти повідомлення
                    }
                }
            }
            else
            {
                messagesListBox.Items.Add("No messages."); // Якщо файлу немає
            }
        }

        private void MessagesListBox_DoubleClick(object sender, EventArgs e)
        {
            // Якщо вибрано повідомлення
            if (messagesListBox.SelectedItem != null && messagesListBox.SelectedItem.ToString() != "No messages.")
            {
                int index = messagesListBox.SelectedIndex; // Індекс вибраного
                string[] messages = (string[])messagesListBox.Tag; // Отримати повідомлення
                string selectedMessage = messages[index]; // Вибране повідомлення

                // Відкрити форму деталей
                MessageDetailForm detailForm = new MessageDetailForm(selectedMessage);
                detailForm.ShowDialog();
            }
        }
    }
}
