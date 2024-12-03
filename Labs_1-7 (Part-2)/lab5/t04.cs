// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     private const decimal KilometersToLeague = 1 / 4.82803m;
//     private const decimal LeagueToKilometers = 4.82803m;
//     public Form1()
//     {
//       InitializeComponentCustom();
//     }

//     private void InitializeComponentCustom()
//     {
//       this.Text = "Конвертер Відстані";

//       Label label1 = new Label
//       {
//         Text = "Сума:",
//         Location = new System.Drawing.Point(20, 20),
//         AutoSize = true
//       };

//       TextBox inputDistance = new TextBox
//       {
//         Location = new System.Drawing.Point(120, 20),
//         Width = 100
//       };

//       Label label2 = new Label
//       {
//         Text = "",
//         Location = new System.Drawing.Point(20, 60),
//         AutoSize = true
//       };

//       ComboBox conversionDirection = new ComboBox
//       {
//         Location = new System.Drawing.Point(230, 20),
//         Width = 150
//       };
//       conversionDirection.Items.Add("Кілометри в Ліги");
//       conversionDirection.Items.Add("Ліги в Кілометри");
//       conversionDirection.SelectedIndex = 0;

//       Button convertButton = new Button
//       {
//         Text = "Конвертувати",
//         Location = new System.Drawing.Point(120, 100),
//         AutoSize = true
//       };
//       convertButton.Click += (sender, e) =>
//       {
//         if (decimal.TryParse(inputDistance.Text, out decimal distance))
//         {
//           if (conversionDirection.SelectedIndex == 0)
//           {
//             decimal leagues = distance * KilometersToLeague;
//             label2.Text = $"Сума у лігах: {leagues:F4}";
//           }
//           else
//           {
//             decimal kilometers = distance * LeagueToKilometers;
//             label2.Text = $"Сума у кілометрах: {kilometers:F4}";
//           }
//         }
//         else
//         {
//           MessageBox.Show("Будь ласка, введіть правильну суму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//         }
//       };

//       this.Controls.Add(label1);
//       this.Controls.Add(inputDistance);
//       this.Controls.Add(label2);
//       this.Controls.Add(conversionDirection);
//       this.Controls.Add(convertButton);

//       this.Size = new System.Drawing.Size(400, 200);
//     }

//   }
// }
