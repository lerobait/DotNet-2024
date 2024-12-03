// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     private const decimal ExchangeRate = 0.043m;

//     public Form1()
//     {
//       InitializeComponentCustom();
//     }

//     private void InitializeComponentCustom()
//     {
//       this.Text = "Обмін Валют";

//       Label label1 = new Label
//       {
//         Text = "Сума у грн.:",
//         Location = new System.Drawing.Point(20, 20),
//         AutoSize = true
//       };

//       TextBox inputAmount = new TextBox
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

//       Button okButton = new Button
//       {
//         Text = "OK",
//         Location = new System.Drawing.Point(120, 100),
//         AutoSize = true
//       };
//       okButton.Click += (sender, e) =>
//       {
//         if (decimal.TryParse(inputAmount.Text, out decimal amountUah))
//         {
//           decimal amountAud = amountUah * ExchangeRate;
//           label2.Text = $"Сума у AUD: {amountAud:F2}";
//         }
//         else
//         {
//           MessageBox.Show("Будь ласка, введіть правильну суму у гривнях.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//         }
//       };

//       this.Controls.Add(label1);
//       this.Controls.Add(inputAmount);
//       this.Controls.Add(label2);
//       this.Controls.Add(okButton);

//       this.Size = new System.Drawing.Size(300, 180);
//     }
//   }
// }
