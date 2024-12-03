// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     private System.Windows.Forms.Timer timer;
//     private bool isDefaultColor;

//     public Form1()
//     {
//       InitializeComponent();
//       InitializeTimer();
//       InitializeButton();
//     }

//     private void InitializeTimer()
//     {
//       timer = new System.Windows.Forms.Timer();
//       timer.Interval = 250;
//       timer.Tick += Timer_Tick;
//     }

//     private void InitializeButton()
//     {
//       Button button = new Button
//       {
//         Text = "Почати",
//         Location = new Point(100, 100),
//         AutoSize = true
//       };

//       button.Click += Button_Click;
//       this.Controls.Add(button);
//     }

//     private void Button_Click(object sender, EventArgs e)
//     {
//       timer.Start();
//     }

//     private void Timer_Tick(object sender, EventArgs e)
//     {
//       if (isDefaultColor)
//       {
//         this.BackColor = Color.LightBlue;
//       }
//       else
//       {
//         this.BackColor = Color.White;
//       }

//       isDefaultColor = !isDefaultColor;
//     }
//   }
// }
