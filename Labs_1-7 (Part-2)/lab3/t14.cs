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
//             this.Load += MainForm_Load;
//         }

//         private void MainForm_Load(object sender, EventArgs e)
//         {
//             DialogResult result = MessageBox.Show("Бажаєте завантажити форму?", "Запит", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//             if (result == DialogResult.No)
//             {
//                 this.Close();
//             }
//             else
//             {
//                 this.StartPosition = FormStartPosition.Manual;
//                 this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
//                 this.Location = new System.Drawing.Point(0, 0);
//             }
//         }
//     }
// }
