// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeButtons();
//             InitializeComponent();
//         }

//         private void InitializeButtons()
//         {
//             Size buttonSize = new Size(100, 50);

//             Button button1 = new Button()
//             {
//                 Text = "Кнопка 1",
//                 Size = buttonSize,
//                 Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, (this.ClientSize.Height - buttonSize.Height) / 2 - 30)
//             };
//             button1.Click += Button_Click;

//             Button button2 = new Button()
//             {
//                 Text = "Кнопка 2",
//                 Size = buttonSize,
//                 Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, (this.ClientSize.Height - buttonSize.Height) / 2)
//             };
//             button2.Click += Button_Click;

//             Button button3 = new Button()
//             {
//                 Text = "Кнопка 3",
//                 Size = buttonSize,
//                 Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, (this.ClientSize.Height - buttonSize.Height) / 2 + 30)
//             };
//             button3.Click += Button_Click;

//             this.Controls.Add(button1);
//             this.Controls.Add(button2);
//             this.Controls.Add(button3);
//         }

//         private void Button_Click(object sender, EventArgs e)
//         {
//             Button clickedButton = sender as Button;
//             string message = clickedButton.Text;

//             using (Graphics g = this.CreateGraphics())
//             {
//                 g.Clear(this.BackColor);
//                 g.DrawString(message, this.Font, Brushes.Black, new Point(10, 10));
//             }
//         }
//     }
// }
