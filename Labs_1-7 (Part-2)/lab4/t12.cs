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
//       InitializeComponents();
//     }

//     private void InitializeTimer()
//     {
//       timer = new System.Windows.Forms.Timer();
//       timer.Interval = 250;
//       timer.Tick += Timer_Tick;
//     }

//     private void InitializeComponents()
//     {
//       Button startButton = new Button
//       {
//         Text = "Запустити",
//         Location = new Point(20, 20),
//         AutoSize = true
//       };
//       startButton.Click += StartButton_Click;

//       Button stopButton = new Button
//       {
//         Text = "Зупинити",
//         Location = new Point(120, 20),
//         AutoSize = true
//       };
//       stopButton.Click += StopButton_Click;

//       TextBox intervalTextBox = new TextBox
//       {
//         Location = new Point(220, 20),
//         Width = 50,
//         Text = "250"
//       };

//       Button setIntervalButton = new Button
//       {
//         Text = "Змінити інтервал",
//         Location = new Point(280, 20),
//         AutoSize = true
//       };
//       setIntervalButton.Click += (s, e) =>
//       {
//         if (int.TryParse(intervalTextBox.Text, out int interval) && interval > 0)
//         {
//           timer.Interval = interval;
//         }
//         else
//         {
//           MessageBox.Show("Введіть коректне значення інтервалу (мс).");
//         }
//       };

//       this.Controls.Add(startButton);
//       this.Controls.Add(stopButton);
//       this.Controls.Add(intervalTextBox);
//       this.Controls.Add(setIntervalButton);

//       this.Size = new System.Drawing.Size(400, 200);
//       this.Text = "Таймер з налаштуваннями";
//     }

//     private void StartButton_Click(object sender, EventArgs e)
//     {
//       timer.Start();
//     }

//     private void StopButton_Click(object sender, EventArgs e)
//     {
//       timer.Stop();
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
