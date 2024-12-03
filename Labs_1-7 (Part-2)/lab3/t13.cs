// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private int labelCount = 0;

//         public Form1()
//         {
//             InitializeComponent();
//             this.KeyPreview = true;
//             this.KeyDown += MainForm_KeyDown;
//         }

//         private void MainForm_KeyDown(object sender, KeyEventArgs e)
//         {
//             if (e.Alt)
//             {
//                 if (e.KeyCode == Keys.A)
//                 {
//                     AddLabel();
//                     e.Handled = true;
//                 }
//                 else if (e.KeyCode == Keys.D)
//                 {
//                     RemoveLabel();
//                     e.Handled = true;
//                 }
//             }
//         }

//         private void AddLabel()
//         {
//             Label newLabel = new Label
//             {
//                 Text = $"Label {++labelCount}",
//                 Location = new Point(10, 10 + (labelCount - 1) * 30),
//                 BackColor = Color.Transparent,
//                 AutoSize = true
//             };

//             this.Controls.Add(newLabel);
//         }

//         private void RemoveLabel()
//         {
//             if (labelCount > 0)
//             {
//                 this.Controls.RemoveAt(this.Controls.Count - 1);
//                 labelCount--;
//             }
//             else
//             {
//                 MessageBox.Show("Немає міток для видалення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//             }
//         }
//     }
// }
