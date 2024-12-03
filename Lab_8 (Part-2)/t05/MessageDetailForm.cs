using System;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageDetailForm : Form
    {
        public MessageDetailForm(string message)
        {
            InitializeComponent();
            messageTextBox.Text = message; // Відображення повідомлення
        }
    }
}
