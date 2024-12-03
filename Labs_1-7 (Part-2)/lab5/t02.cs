// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const decimal ExchangeRateToAUD = 0.043m;
//         private const decimal ExchangeRateToUAH = 1 / ExchangeRateToAUD;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {

//             Label label1 = new Label
//             {
//                 Text = "Сума у грн.:",
//                 Location = new System.Drawing.Point(20, 20),
//                 AutoSize = true
//             };

//             TextBox inputAmountUAH = new TextBox
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

//             Button okButtonUAH = new Button
//             {
//                 Text = "Конвертувати в AUD",
//                 Location = new System.Drawing.Point(120, 100),
//                 AutoSize = true
//             };
//             okButtonUAH.Click += (sender, e) =>
//             {
//                 if (decimal.TryParse(inputAmountUAH.Text, out decimal amountUah))
//                 {
//                     decimal amountAud = amountUah * ExchangeRateToAUD;
//                     label2.Text = $"Сума у AUD: {amountAud:F2}";
//                 }
//                 else
//                 {
//                     MessageBox.Show("Будь ласка, введіть правильну суму у гривнях.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                 }
//             };

//             Label label3 = new Label
//             {
//                 Text = "Сума у AUD:",
//                 Location = new System.Drawing.Point(20, 140),
//                 AutoSize = true
//             };

//             TextBox inputAmountAUD = new TextBox
//             {
//                 Location = new System.Drawing.Point(120, 140),
//                 Width = 100
//             };

//             Label label4 = new Label
//             {
//                 Text = "",
//                 Location = new System.Drawing.Point(20, 180),
//                 AutoSize = true
//             };

//             Button okButtonAUD = new Button
//             {
//                 Text = "Конвертувати в грн.",
//                 Location = new System.Drawing.Point(120, 220),
//                 AutoSize = true
//             };
//             okButtonAUD.Click += (sender, e) =>
//             {
//                 if (decimal.TryParse(inputAmountAUD.Text, out decimal amountAud))
//                 {
//                     decimal amountUah = amountAud * ExchangeRateToUAH;
//                     label4.Text = $"Сума у грн.: {amountUah:F2}";
//                 }
//                 else
//                 {
//                     MessageBox.Show("Будь ласка, введіть правильну суму у австралійських доларах.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                 }
//             };

//             this.Controls.Add(label1);
//             this.Controls.Add(inputAmountUAH);
//             this.Controls.Add(label2);
//             this.Controls.Add(okButtonUAH);
//             this.Controls.Add(label3);
//             this.Controls.Add(inputAmountAUD);
//             this.Controls.Add(label4);
//             this.Controls.Add(okButtonAUD);

//             this.Size = new System.Drawing.Size(300, 300);
//         }
//     }
// }
