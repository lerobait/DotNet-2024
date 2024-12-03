// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeMenu();
//         }

//         private void InitializeMenu()
//         {
//             MenuStrip menuStrip = new MenuStrip();

//             ToolStripMenuItem item1 = new ToolStripMenuItem("Item1");
//             ToolStripMenuItem item2 = new ToolStripMenuItem("Item2");
//             ToolStripMenuItem item3 = new ToolStripMenuItem("Item3");
//             ToolStripMenuItem item4 = new ToolStripMenuItem("Item4");
//             ToolStripMenuItem item5 = new ToolStripMenuItem("Item5");

//             item1.DropDownItems.Add(new ToolStripMenuItem("Item11"));
//             item1.DropDownItems.Add(new ToolStripMenuItem("Item12"));

//             item2.DropDownItems.Add(new ToolStripMenuItem("Item21"));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item22"));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item23"));

//             ToolStripMenuItem item22 = item2.DropDownItems[1] as ToolStripMenuItem;
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item221"));
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item222"));
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item223"));

//             item3.DropDownItems.Add(new ToolStripMenuItem("Item31"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item32"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item33"));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item34"));

//             ToolStripMenuItem item33 = item3.DropDownItems[2] as ToolStripMenuItem;
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item331"));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item332"));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item333"));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item334"));

//             item4.DropDownItems.Add(new ToolStripMenuItem("Item41"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item42"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item43"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item44"));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item45"));

//             ToolStripMenuItem item44 = item4.DropDownItems[3] as ToolStripMenuItem;
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item441"));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item442"));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item443"));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item444"));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item445"));

//             item5.DropDownItems.Add(new ToolStripMenuItem("Item51"));
//             item5.DropDownItems.Add(new ToolStripMenuItem("Item52"));

//             menuStrip.Items.Add(item1);
//             menuStrip.Items.Add(item2);
//             menuStrip.Items.Add(item3);
//             menuStrip.Items.Add(item4);
//             menuStrip.Items.Add(item5);

//             this.MainMenuStrip = menuStrip;
//             this.Controls.Add(menuStrip);
//             this.Size = new System.Drawing.Size(600, 400);
//             this.Text = "Трирівневе меню";
//         }
//     }
// }
