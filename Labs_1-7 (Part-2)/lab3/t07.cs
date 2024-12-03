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
//             InitializeLabels();
//         }

//         private void InitializeLabels()
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 Label label = new Label()
//                 {
//                     Text = $"Рядок тексту {i + 1}",
//                     Location = new Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 100) / 2 + (i * 40)),
//                     AutoSize = true,
//                     Font = new Font("Arial", 12)
//                 };

//                 label.MouseDown += Label_MouseDown;
//                 label.MouseUp += Label_MouseUp;

//                 this.Controls.Add(label);
//             }
//         }

//         private void Label_MouseDown(object sender, MouseEventArgs e)
//         {
//             if (sender is Label label)
//             {
//                 label.Font = new Font(label.Font.FontFamily, label.Font.Size + 2);
//             }
//         }

//         private void Label_MouseUp(object sender, MouseEventArgs e)
//         {
//             if (sender is Label label)
//             {
//                 label.Font = new Font(label.Font.FontFamily, label.Font.Size - 2);
//             }
//         }
//     }
// }
