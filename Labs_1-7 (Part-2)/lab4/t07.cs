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
//             InitializeContextMenu();
//         }

//         private void InitializeLabels()
//         {
//             Label label1 = new Label
//             {
//                 Text = "Label 1: Правий клік для контекстного меню",
//                 Location = new System.Drawing.Point(20, 20),
//                 AutoSize = true
//             };

//             Label label2 = new Label
//             {
//                 Text = "Label 2: Правий клік для контекстного меню",
//                 Location = new System.Drawing.Point(20, 60),
//                 AutoSize = true
//             };

//             Label label3 = new Label
//             {
//                 Text = "Label 3: Правий клік для контекстного меню",
//                 Location = new System.Drawing.Point(20, 100),
//                 AutoSize = true
//             };

//             this.Controls.Add(label1);
//             this.Controls.Add(label2);
//             this.Controls.Add(label3);
//         }

//         private void InitializeContextMenu()
//         {
//             ContextMenuStrip contextMenu = new ContextMenuStrip();

//             ToolStripMenuItem changeColorRed = new ToolStripMenuItem("Червоний");
//             changeColorRed.Click += (s, e) => ChangeLabelColor(Color.Red);

//             ToolStripMenuItem changeColorGreen = new ToolStripMenuItem("Зелений");
//             changeColorGreen.Click += (s, e) => ChangeLabelColor(Color.Green);

//             ToolStripMenuItem changeColorBlue = new ToolStripMenuItem("Синій");
//             changeColorBlue.Click += (s, e) => ChangeLabelColor(Color.Blue);

//             contextMenu.Items.Add(changeColorRed);
//             contextMenu.Items.Add(changeColorGreen);
//             contextMenu.Items.Add(changeColorBlue);

//             foreach (Control control in this.Controls)
//             {
//                 if (control is Label)
//                 {
//                     control.ContextMenuStrip = contextMenu;
//                 }
//             }

//             this.Size = new System.Drawing.Size(400, 200);
//             this.Text = "Контекстне меню";
//         }

//         private void ChangeLabelColor(Color color)
//         {
//             var activeControl = this.ActiveControl;

//             if (activeControl is Label label)
//             {
//                 label.ForeColor = color;
//             }
//         }
//     }
// }
