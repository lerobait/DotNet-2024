// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeComponent();
//       InitializeButtons();
//     }

//     private void InitializeButtons()
//     {
//       Size buttonSize = new Size(100, 30);
//       int startY = (this.ClientSize.Height - buttonSize.Height * 3) / 2;

//       for (int i = 0; i < 3; i++)
//       {
//         Button button = new Button()
//         {
//           Text = $"Кнопка {i + 1}",
//           Size = buttonSize,
//           Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, startY + (i * 40))
//         };

//         button.MouseEnter += Button_MouseEnterLeave;
//         button.MouseLeave += Button_MouseEnterLeave;

//         this.Controls.Add(button);
//       }
//     }

//     private void Button_MouseEnterLeave(object sender, EventArgs e)
//     {
//       if (sender is Button button)
//       {
//         if (e is EventArgs)
//         {
//           if (button.ClientRectangle.Contains(button.PointToClient(Control.MousePosition)))
//           {
//             button.Size = new Size(button.Width + 2, button.Height + 2);
//           }
//           else
//           {
//             button.Size = new Size(button.Width - 2, button.Height - 2);
//           }
//         }
//       }
//     }
//   }
// }
