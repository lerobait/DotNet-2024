// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//             InitializeTableLayoutPanel();
//         }

//         private void InitializeTableLayoutPanel()
//         {
//             TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
//             {
//                 RowCount = 3,
//                 ColumnCount = 3,
//                 Dock = DockStyle.Fill
//             };

//             tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
//             tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
//             tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
//             tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
//             tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
//             tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

//             Button button1 = new Button { Text = "but1" };
//             Button button2 = new Button { Text = "but2" };
//             Button button3 = new Button { Text = "but3" };
//             Button button4 = new Button { Text = "but4" };
//             Button button5 = new Button { Text = "but5" };

//             tableLayoutPanel.Controls.Add(button1, 0, 0);
//             tableLayoutPanel.Controls.Add(button4, 2, 0);
//             tableLayoutPanel.Controls.Add(button2, 1, 1);
//             tableLayoutPanel.Controls.Add(button3, 0, 2);
//             tableLayoutPanel.Controls.Add(button5, 2, 2);

//             this.Controls.Add(tableLayoutPanel);
//         }
//     }
// }
