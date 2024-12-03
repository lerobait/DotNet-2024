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

//             ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
//             ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
//             ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
//             ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");
//             ToolStripMenuItem item5 = new ToolStripMenuItem("Item5");

//             item2.DropDownItems.Add(new ToolStripMenuItem("Item21"));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item22"));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item23"));

//             item3.DropDownItems.Add(new ToolStripMenuItem("Item31"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item32"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item33"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item34"));

//             item4.DropDownItems.Add(new ToolStripMenuItem("Item41"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item42"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item43"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item44"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item45"));

//             contextMenu.Items.Add(item1);
//             contextMenu.Items.Add(item2);
//             contextMenu.Items.Add(item3);
//             contextMenu.Items.Add(item4);
//             contextMenu.Items.Add(item5);

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
//     }
// }
