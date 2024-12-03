// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const decimal KilometersToLeague = 1 / 4.82803m;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Конвертер Відстані";

//             Label label1 = new Label
//             {
//                 Text = "Відстань у км:",
//                 Location = new System.Drawing.Point(20, 20),
//                 AutoSize = true
//             };

//             TextBox inputKilometers = new TextBox
//             {
//                 Location = new System.Drawing.Point(120, 20),
//                 Width = 100
//             };

//             Label label2 = new Label
//             {
//                 Text = "",
//                 Location = new System.Drawing.Point(20, 60),
//                 AutoSize = true
//             };

//             Button convertButton = new Button
//             {
//                 Text = "Конвертувати в ліги",
//                 Location = new System.Drawing.Point(120, 100),
//                 AutoSize = true
//             };
//             convertButton.Click += (sender, e) =>
//             {
//                 if (decimal.TryParse(inputKilometers.Text, out decimal kilometers))
//                 {
//                     decimal leagues = kilometers * KilometersToLeague;
//                     label2.Text = $"Відстань у лігах: {leagues:F4}";
//                 }
//                 else
//                 {
//                     MessageBox.Show("Будь ласка, введіть правильну суму у кілометрах.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                 }
//             };

//             this.Controls.Add(label1);
//             this.Controls.Add(inputKilometers);
//             this.Controls.Add(label2);
//             this.Controls.Add(convertButton);

//             this.Size = new System.Drawing.Size(300, 200);
//         }
//     }
// }
