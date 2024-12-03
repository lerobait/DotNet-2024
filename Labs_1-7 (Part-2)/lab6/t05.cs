// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private Label label1, label2, label3;
//         private Button button1, button2;
//         private System.Windows.Forms.Timer stopwatchTimer, changeTitleTimer;
//         private int secondsElapsed = 0;
//         private bool isTitleChanged = false;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Секундомір";
//             this.Size = new Size(300, 150);
//             this.StartPosition = FormStartPosition.CenterScreen;

//             label1 = new Label
//             {
//                 Text = "00",
//                 Location = new Point(30, 20),
//                 Font = new Font("Arial", 24),
//                 AutoSize = true
//             };
//             this.Controls.Add(label1);

//             label3 = new Label
//             {
//                 Text = ":",
//                 Location = new Point(100, 20),
//                 Font = new Font("Arial", 24),
//                 AutoSize = true
//             };
//             this.Controls.Add(label3);

//             label2 = new Label
//             {
//                 Text = "00",
//                 Location = new Point(130, 20),
//                 Font = new Font("Arial", 24),
//                 AutoSize = true
//             };
//             this.Controls.Add(label2);

//             button1 = new Button
//             {
//                 Text = "Старт",
//                 Location = new Point(30, 70),
//                 Width = 100
//             };
//             button1.Click += StartTimer;
//             this.Controls.Add(button1);

//             button2 = new Button
//             {
//                 Text = "Стоп",
//                 Location = new Point(150, 70),
//                 Width = 100
//             };
//             button2.Click += StopTimer;
//             this.Controls.Add(button2);

//             stopwatchTimer = new System.Windows.Forms.Timer { Interval = 1000 };
//             stopwatchTimer.Tick += UpdateTime;

//             changeTitleTimer = new System.Windows.Forms.Timer { Interval = 5000 };
//             changeTitleTimer.Tick += ChangeTitle;
//         }

//         private void StartTimer(object sender, EventArgs e)
//         {
//             secondsElapsed = 0;
//             UpdateTimeDisplay();
//             stopwatchTimer.Start();
//             changeTitleTimer.Start();
//         }

//         private void StopTimer(object sender, EventArgs e)
//         {
//             stopwatchTimer.Stop();
//             changeTitleTimer.Stop();
//             this.Text = "Секундомір";
//         }

//         private void UpdateTime(object sender, EventArgs e)
//         {
//             secondsElapsed++;
//             UpdateTimeDisplay();
//         }

//         private void UpdateTimeDisplay()
//         {
//             int minutes = secondsElapsed / 60;
//             int seconds = secondsElapsed % 60;

//             label1.Text = minutes.ToString("D2");
//             label2.Text = seconds.ToString("D2");
//         }

//         private void ChangeTitle(object sender, EventArgs e)
//         {
//             if (isTitleChanged)
//             {
//                 this.Text = "Секундомір";
//             }
//             else
//             {
//                 this.Text = "Таймер йде...";
//             }
//             isTitleChanged = !isTitleChanged;
//         }
//     }
// }
