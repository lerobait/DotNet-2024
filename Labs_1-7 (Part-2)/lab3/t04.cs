// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeLabels();
//       InitializeComponent();
//     }

//     private void InitializeLabels()
//     {
//       Size labelSize = new Size(200, 30);
//       int startY = (this.ClientSize.Height - labelSize.Height * 3) / 2;

//       for (int i = 0; i < 3; i++)
//       {
//         Label label = new Label()
//         {
//           Text = $"Текст рядка {i + 1}",
//           Size = labelSize,
//           Location = new Point((this.ClientSize.Width - labelSize.Width) / 2, startY + (i * 40))
//         };
//         label.DoubleClick += Label_DoubleClick;
//         this.Controls.Add(label);
//       }
//     }

//     private void Label_DoubleClick(object sender, EventArgs e)
//     {
//       if (sender is Label clickedLabel)
//       {
//         clickedLabel.Font = new Font(clickedLabel.Font.FontFamily, clickedLabel.Font.Size + 2);
//       }
//     }
//   }
// }
