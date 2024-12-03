// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeLabels();
//             InitializeComponent();
//         }

//         private void InitializeLabels()
//         {
//             Size labelSize = new Size(200, 30);
//             int startY = (this.ClientSize.Height - labelSize.Height * 3) / 2;

//             Label label1 = new Label()
//             {
//                 Text = "Текст рядка 1",
//                 Size = labelSize,
//                 Location = new Point((this.ClientSize.Width - labelSize.Width) / 2, startY)
//             };
//             label1.DoubleClick += Label_DoubleClick;

//             Label label2 = new Label()
//             {
//                 Text = "Текст рядка 2",
//                 Size = labelSize,
//                 Location = new Point((this.ClientSize.Width - labelSize.Width) / 2, startY + 40)
//             };
//             label2.DoubleClick += Label_DoubleClick;

//             Label label3 = new Label()
//             {
//                 Text = "Текст рядка 3",
//                 Size = labelSize,
//                 Location = new Point((this.ClientSize.Width - labelSize.Width) / 2, startY + 80)
//             };
//             label3.DoubleClick += Label_DoubleClick;

//             this.Controls.Add(label1);
//             this.Controls.Add(label2);
//             this.Controls.Add(label3);
//         }

//         private void Label_DoubleClick(object sender, EventArgs e)
//         {
//             Label clickedLabel = sender as Label;

//             if (clickedLabel != null)
//             {
//                 clickedLabel.Font = new Font(clickedLabel.Font.FontFamily, clickedLabel.Font.Size + 2);
//             }
//         }
//     }
// }
