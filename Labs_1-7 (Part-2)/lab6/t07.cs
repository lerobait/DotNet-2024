// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private TextBox input1;
//         private StatusStrip statusStrip1;
//         private ToolStripStatusLabel toolStripStatusLabel1;
//         private ToolStripStatusLabel toolStripStatusLabel2;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Статусний рядок";
//             this.Size = new System.Drawing.Size(400, 200);
//             this.StartPosition = FormStartPosition.CenterScreen;

//             input1 = new TextBox
//             {
//                 Location = new System.Drawing.Point(50, 50),
//                 Width = 300
//             };
//             input1.TextChanged += Input1_TextChanged;
//             this.Controls.Add(input1);

//             statusStrip1 = new StatusStrip();
//             toolStripStatusLabel1 = new ToolStripStatusLabel();
//             toolStripStatusLabel2 = new ToolStripStatusLabel();

//             statusStrip1.Items.Add(toolStripStatusLabel1);
//             statusStrip1.Items.Add(toolStripStatusLabel2);
//             this.Controls.Add(statusStrip1);

//             UpdateStatusLabels();
//         }

//         private void Input1_TextChanged(object sender, EventArgs e)
//         {
//             toolStripStatusLabel2.Text = input1.Text;
//         }

//         private void UpdateStatusLabels()
//         {
//             toolStripStatusLabel1.Text = DateTime.Now.ToString("dd.MM.yyyy");

//             toolStripStatusLabel2.Text = string.Empty;
//         }
//     }
// }
