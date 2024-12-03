// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const int MaxDigits = 7;

//         public Form1()
//         {
//             InitializeComponent();
//             InitializeTextBox();
//         }

//         private void InitializeTextBox()
//         {
//             TextBox textBox = new TextBox
//             {
//                 Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 100) / 2),
//                 Size = new System.Drawing.Size(200, 30),
//                 Font = new System.Drawing.Font("Arial", 12)
//             };

//             textBox.KeyPress += TextBox_KeyPress;

//             this.Controls.Add(textBox);
//         }

//         private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
//         {
//             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
//             {
//                 e.Handled = true;
//             }
//             else
//             {
//                 TextBox textBox = sender as TextBox;
//                 if (textBox.Text.Length >= MaxDigits && !char.IsControl(e.KeyChar))
//                 {
//                     e.Handled = true;
//                 }
//             }
//         }
//     }
// }
