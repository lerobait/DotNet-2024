// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private Label label1, label2, label3;
//         private Button button1;
//         private NumericUpDown numericUpDownMinutes, numericUpDownSeconds;
//         private System.Windows.Forms.Timer stopwatchTimer, changeTitleTimer;
//         private int secondsElapsed = 0;
//         private bool isTitleChanged = false;
//         private bool isRunning = false;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Секундомір";
//             this.Size = new Size(350, 200);
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

//             numericUpDownMinutes = new NumericUpDown
//             {
//                 Location = new Point(30, 70),
//                 Width = 50,
//                 Minimum = 0,
//                 Maximum = 59,
//                 Value = 0
//             };
//             this.Controls.Add(numericUpDownMinutes);

//             numericUpDownSeconds = new NumericUpDown
//             {
//                 Location = new Point(90, 70),
//                 Width = 50,
//                 Minimum = 0,
//                 Maximum = 59,
//                 Value = 0
//             };
//             this.Controls.Add(numericUpDownSeconds);

//             button1 = new Button
//             {
//                 Text = "Старт",
//                 Location = new Point(150, 70),
//                 Width = 100
//             };
//             button1.Click += ToggleTimer;
//             this.Controls.Add(button1);

//             stopwatchTimer = new System.Windows.Forms.Timer { Interval = 1000 };
//             stopwatchTimer.Tick += UpdateTime;

//             changeTitleTimer = new System.Windows.Forms.Timer { Interval = 5000 };
//             changeTitleTimer.Tick += ChangeTitle;
//         }

//         private void ToggleTimer(object sender, EventArgs e)
//         {
//             if (isRunning)
//             {
//                 stopwatchTimer.Stop();
//                 changeTitleTimer.Stop();
//                 button1.Text = "Старт";
//             }
//             else
//             {
//                 secondsElapsed = 0;
//                 UpdateTimeDisplay();
//                 stopwatchTimer.Start();
//                 changeTitleTimer.Start();
//                 button1.Text = "Стоп";
//             }
//             isRunning = !isRunning;
//         }

//         private void UpdateTime(object sender, EventArgs e)
//         {
//             secondsElapsed++;
//             UpdateTimeDisplay();

//             AdjustTimerIntervals();
//         }

//         private void UpdateTimeDisplay()
//         {
//             int minutes = secondsElapsed / 60;
//             int seconds = secondsElapsed % 60;

//             label1.Text = minutes.ToString("D2");
//             label2.Text = seconds.ToString("D2");
//         }

//         private void AdjustTimerIntervals()
//         {
//             stopwatchTimer.Interval = (int)((numericUpDownMinutes.Value * 60 + numericUpDownSeconds.Value) * 1000);
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
