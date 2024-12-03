// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeComponent();
//       this.Load += new EventHandler(Form1_Load);
//     }

//     private void Form1_Load(object sender, EventArgs e)
//     {
//       TextBox textBox1 = new TextBox();
//       textBox1.Text = "Перший рядок";
//       textBox1.Font = new Font("Arial", 17, FontStyle.Bold);
//       textBox1.ForeColor = Color.Yellow;
//       textBox1.BackColor = Color.Red;
//       textBox1.TextAlign = HorizontalAlignment.Center;
//       textBox1.ReadOnly = true;
//       textBox1.Dock = DockStyle.Top;
//       this.Controls.Add(textBox1);

//       TextBox textBox2 = new TextBox();
//       textBox2.Text = "Другий рядок";
//       textBox2.Font = new Font("Arial", 15, FontStyle.Italic);
//       textBox2.ForeColor = Color.Green;
//       textBox2.BackColor = Color.Yellow;
//       textBox2.TextAlign = HorizontalAlignment.Left;
//       textBox2.ReadOnly = true;
//       textBox2.Dock = DockStyle.Top;
//       this.Controls.Add(textBox2);

//       TextBox textBox3 = new TextBox();
//       textBox3.Text = "Третій рядок";
//       textBox3.Font = new Font("Arial", 11, FontStyle.Underline);
//       textBox3.ForeColor = Color.Red;
//       textBox3.BackColor = Color.Gray;
//       textBox3.TextAlign = HorizontalAlignment.Right;
//       textBox3.ReadOnly = true;
//       textBox3.Dock = DockStyle.Top;
//       this.Controls.Add(textBox3);
//     }
//   }
// }
