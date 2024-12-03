using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class ProfileForm : Form
    {
        private string username;

        // Ініціалізація форми
        public ProfileForm(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData(); // Завантаження даних
            StyleComponents(); // Стилізація
        }

        // Завантаження даних з файлу
        private void LoadUserData()
        {
            string filePath = "userdata.txt";
            if (System.IO.File.Exists(filePath))
            {
                string[] userLines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in userLines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 3 && parts[0] == username)
                    {
                        nameLabel.Text = parts[0];
                        emailLabel.Text = parts[1];
                        phoneLabel.Text = parts[2];
                        break;
                    }
                }
            }
        }

        // Налаштування стилю кнопок
        private void StyleComponents()
        {
            RoundButtonEdges(editNameButton, 15);
            RoundButtonEdges(editEmailButton, 15);
            RoundButtonEdges(editPhoneButton, 15);
            RoundButtonEdges(editPasswordButton, 15);
            RoundButtonEdges(sendMessageButton, 15);
            RoundButtonEdges(receiveMessageButton, 15);
            RoundButtonEdges(logoutButton, 15);

            sendMessageButton.BackColor = Color.MediumSeaGreen;
            sendMessageButton.ForeColor = Color.White;
            sendMessageButton.FlatStyle = FlatStyle.Flat;
            sendMessageButton.FlatAppearance.BorderSize = 0;

            Button[] buttons = { editNameButton, editEmailButton, editPhoneButton, editPasswordButton, receiveMessageButton, logoutButton };
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        // Закруглення країв кнопки
        private void RoundButtonEdges(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }

        // Вихід з профілю
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        // Редагування імені
        private void EditNameButton_Click(object sender, EventArgs e)
        {
            EditNameForm editNameForm = new EditNameForm(username);
            if (editNameForm.ShowDialog() == DialogResult.OK)
            {
                username = editNameForm.NewUsername;
                LoadUserData();
            }
        }

        // Редагування email
        private void EditEmailButton_Click(object sender, EventArgs e)
        {
            new EditEmailForm(username).ShowDialog();
            LoadUserData();
        }

        // Редагування телефону
        private void EditPhoneButton_Click(object sender, EventArgs e)
        {
            new EditPhoneForm(username).ShowDialog();
            LoadUserData();
        }

        // Редагування пароля
        private void EditPasswordButton_Click(object sender, EventArgs e)
        {
            new EditPasswordForm(username).ShowDialog();
        }

        // Надсилання повідомлення
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            new MessageSendForm(username).ShowDialog();
        }

        // Отримання повідомлення
        private void ReceiveMessageButton_Click(object sender, EventArgs e)
        {
            new MessageReceiveForm(username).ShowDialog();
        }
    }
}
