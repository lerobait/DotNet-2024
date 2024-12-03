// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//             InitializeButtons();
//         }

//         private void InitializeButtons()
//         {
//             Size buttonSize = new Size(100, 30);
//             int startY = (this.ClientSize.Height - buttonSize.Height * 3) / 2;

//             for (int i = 0; i < 3; i++)
//             {
//                 Button button = new Button()
//                 {
//                     Text = $"Кнопка {i + 1}",
//                     Size = buttonSize,
//                     Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, startY + (i * 40))
//                 };

//                 button.MouseEnter += Button_MouseEnter;
//                 button.MouseLeave += Button_MouseLeave;

//                 this.Controls.Add(button);
//             }
//         }

//         private void Button_MouseEnter(object sender, EventArgs e)
//         {
//             if (sender is Button button)
//             {
//                 button.Size = new Size(button.Width + 2, button.Height + 2);
//             }
//         }

//         private void Button_MouseLeave(object sender, EventArgs e)
//         {
//             if (sender is Button button)
//             {
//                 button.Size = new Size(button.Width - 2, button.Height - 2);
//             }
//         }
//     }
// }
