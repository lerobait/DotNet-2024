// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private TextBox textBox1;
//         private TextBox textBox2;
//         private TextBox textBox3;
//         private Button buttonSend;
//         private Button buttonReset;

//         public Form1()
//         {
//             InitializeComponent();

//             textBox1 = new TextBox { Location = new Point(10, 10), Width = 200 };
//             textBox2 = new TextBox { Location = new Point(10, 40), Width = 200 };
//             buttonReset = new Button { Text = "Reset", Location = new Point(10, 130), Width = 200 };

//             Controls.Add(buttonSend);
//             Controls.Add(buttonReset);
//             buttonSend = new Button { Text = "Send", Location = new Point(10, 100), Width = 200 };

//             Controls.Add(textBox3);
//             Controls.Add(buttonSend);
//             Controls.Add(textBox1);
//             Controls.Add(textBox2);
//             Controls.Add(textBox3);

//             buttonReset.Click += ButtonReset_Click;
//             buttonSend.Click += ButtonSend_Click;
//         }

//         private void ButtonReset_Click(object sender, EventArgs e)
//         {
//             textBox1.Clear();
//             textBox2.Clear();
//             textBox3.Clear();

//             textBox1.ForeColor = SystemColors.WindowText;
//             textBox2.ForeColor = SystemColors.WindowText;
//             textBox3.ForeColor = SystemColors.WindowText;
//         }

//         private void ButtonSend_Click(object sender, EventArgs e)
//         {
//             Color newColor = Color.Blue;
//             textBox1.ForeColor = newColor;
//             textBox2.ForeColor = newColor;
//             textBox3.ForeColor = newColor;

//         }
//     }
// }
