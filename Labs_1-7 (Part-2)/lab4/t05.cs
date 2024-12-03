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

//             item1.DropDownItems.Add(new ToolStripMenuItem("Item11", null, (s, e) => ShowMessage("Item11")));
//             item1.DropDownItems.Add(new ToolStripMenuItem("Item12", null, (s, e) => ShowMessage("Item12")));

//             item2.DropDownItems.Add(new ToolStripMenuItem("Item21", null, (s, e) => ShowMessage("Item21")));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item22", null, (s, e) => ShowMessage("Item22")));
//             item2.DropDownItems.Add(new ToolStripMenuItem("Item23", null, (s, e) => ShowMessage("Item23")));

//             ToolStripMenuItem item22 = item2.DropDownItems[1] as ToolStripMenuItem;
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item221", null, (s, e) => ShowMessage("Item221")));
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item222", null, (s, e) => ShowMessage("Item222")));
//             item22.DropDownItems.Add(new ToolStripMenuItem("Item223", null, (s, e) => ShowMessage("Item223")));

//             item3.DropDownItems.Add(new ToolStripMenuItem("Item31", null, (s, e) => ShowMessage("Item31")));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item32", null, (s, e) => ShowMessage("Item32")));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item33", null, (s, e) => ShowMessage("Item33")));
//             item3.DropDownItems.Add(new ToolStripMenuItem("Item34", null, (s, e) => ShowMessage("Item34")));

//             ToolStripMenuItem item33 = item3.DropDownItems[2] as ToolStripMenuItem;
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item331", null, (s, e) => ShowMessage("Item331")));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item332", null, (s, e) => ShowMessage("Item332")));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item333", null, (s, e) => ShowMessage("Item333")));
//             item33.DropDownItems.Add(new ToolStripMenuItem("Item334", null, (s, e) => ShowMessage("Item334")));

//             item4.DropDownItems.Add(new ToolStripMenuItem("Item41", null, (s, e) => ShowMessage("Item41")));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item42", null, (s, e) => ShowMessage("Item42")));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item43", null, (s, e) => ShowMessage("Item43")));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item44", null, (s, e) => ShowMessage("Item44")));
//             item4.DropDownItems.Add(new ToolStripMenuItem("Item45", null, (s, e) => ShowMessage("Item45")));

//             ToolStripMenuItem item44 = item4.DropDownItems[3] as ToolStripMenuItem;
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item441", null, (s, e) => ShowMessage("Item441")));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item442", null, (s, e) => ShowMessage("Item442")));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item443", null, (s, e) => ShowMessage("Item443")));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item444", null, (s, e) => ShowMessage("Item444")));
//             item44.DropDownItems.Add(new ToolStripMenuItem("Item445", null, (s, e) => ShowMessage("Item445")));

//             item5.DropDownItems.Add(new ToolStripMenuItem("Item51", null, (s, e) => ShowMessage("Item51")));
//             item5.DropDownItems.Add(new ToolStripMenuItem("Item52", null, (s, e) => ShowMessage("Item52")));

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

//         private void ShowMessage(string message)
//         {
//             MessageBox.Show(message, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
//         }
//     }
// }
