// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const int SizeChange = 10;

//         public Form1()
//         {
//             InitializeComponent();
//             InitializeTextBoxes();
//         }

//         private void InitializeTextBoxes()
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 TextBox textBox = new TextBox()
//                 {
//                     Location = new Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 100) / 2 + (i * 40)),
//                     Size = new Size(200, 20),
//                     Font = new Font("Arial", 12)
//                 };

//                 textBox.Enter += TextBox_Enter;
//                 textBox.Leave += TextBox_Leave;

//                 this.Controls.Add(textBox);
//             }
//         }

//         private void TextBox_Enter(object sender, EventArgs e)
//         {
//             if (sender is TextBox textBox)
//             {
//                 textBox.Size = new Size(textBox.Width + SizeChange, textBox.Height + SizeChange);
//             }
//         }

//         private void TextBox_Leave(object sender, EventArgs e)
//         {
//             if (sender is TextBox textBox)
//             {
//                 textBox.Size = new Size(textBox.Width - SizeChange, textBox.Height - SizeChange);
//             }
//         }
//     }
// }
