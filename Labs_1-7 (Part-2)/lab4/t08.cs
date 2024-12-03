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
//       InitializeContextMenu();
//     }

//     private void InitializeLabels()
//     {
//       Label label1 = new Label
//       {
//         Text = "Label 1: Правий клік для контекстного меню",
//         Location = new System.Drawing.Point(20, 20),
//         AutoSize = true
//       };

//       Label label2 = new Label
//       {
//         Text = "Label 2: Правий клік для контекстного меню",
//         Location = new System.Drawing.Point(20, 60),
//         AutoSize = true
//       };

//       Label label3 = new Label
//       {
//         Text = "Label 3: Правий клік для контекстного меню",
//         Location = new System.Drawing.Point(20, 100),
//         AutoSize = true
//       };

//       this.Controls.Add(label1);
//       this.Controls.Add(label2);
//       this.Controls.Add(label3);
//     }

//     private void InitializeContextMenu()
//     {
//       ContextMenuStrip contextMenu = new ContextMenuStrip();

//       ToolStripMenuItem changeColorRed = new ToolStripMenuItem("Червоний");
//       changeColorRed.Click += ChangeLabelColor;

//       ToolStripMenuItem changeColorGreen = new ToolStripMenuItem("Зелений");
//       changeColorGreen.Click += ChangeLabelColor;

//       ToolStripMenuItem changeColorBlue = new ToolStripMenuItem("Синій");
//       changeColorBlue.Click += ChangeLabelColor;

//       contextMenu.Items.Add(changeColorRed);
//       contextMenu.Items.Add(changeColorGreen);
//       contextMenu.Items.Add(changeColorBlue);

//       foreach (Control control in this.Controls)
//       {
//         if (control is Label)
//         {
//           control.ContextMenuStrip = contextMenu;
//         }
//       }

//       this.Size = new System.Drawing.Size(400, 200);
//       this.Text = "Контекстне меню";
//     }

//     private void ChangeLabelColor(object sender, EventArgs e)
//     {
//       var activeControl = this.ActiveControl;

//       if (activeControl is Label label && sender is ToolStripMenuItem menuItem)
//       {
//         Color color;
//         switch (menuItem.Text)
//         {
//           case "Червоний":
//             color = Color.Red;
//             break;
//           case "Зелений":
//             color = Color.Green;
//             break;
//           case "Синій":
//             color = Color.Blue;
//             break;
//           default:
//             return;
//         }

//         label.ForeColor = color;
//       }
//     }
//   }
// }
