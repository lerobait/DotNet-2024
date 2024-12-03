// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class CalculationForm : Form
//     {
//         private TextBox txtX;
//         private TextBox txtY;
//         private TextBox txtZ;
//         private Button btnCalculate;
//         private Label lblResult;
//         private Button btnOpenParameters;

//         public CalculationForm()
//         {
//             txtX = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100 };
//             txtY = new TextBox { Location = new System.Drawing.Point(20, 60), Width = 100 };
//             txtZ = new TextBox { Location = new System.Drawing.Point(20, 100), Width = 100 };
            
//             btnCalculate = new Button { Text = "Розрахувати", Location = new System.Drawing.Point(20, 140), Width = 100 };
//             btnCalculate.Click += BtnCalculate_Click;

//             lblResult = new Label { Location = new System.Drawing.Point(20, 180), Width = 300 };

//             btnOpenParameters = new Button { Text = "Параметри", Location = new System.Drawing.Point(20, 220), Width = 100 };
//             btnOpenParameters.Click += BtnOpenParameters_Click;

//             Controls.Add(txtX);
//             Controls.Add(txtY);
//             Controls.Add(txtZ);
//             Controls.Add(btnCalculate);
//             Controls.Add(lblResult);
//             Controls.Add(btnOpenParameters);
//         }

//         private void BtnCalculate_Click(object sender, EventArgs e)
//         {
//             try
//             {
//                 int x = int.Parse(txtX.Text);
//                 int y = int.Parse(txtY.Text);
//                 int z = int.Parse(txtZ.Text);

//                 double numerator = 0;
//                 for (int i = 1; i <= x; i++)
//                 {
//                     numerator += (i - x * y);
//                 }

//                 double denominator = 0;
//                 for (int i = 1; i <= y; i++)
//                 {
//                     denominator += (i - x * z);
//                 }

//                 if (denominator != 0)
//                 {
//                     double result = numerator / denominator;
//                     lblResult.Text = $"Результат: {result}";
//                 }
//                 else
//                 {
//                     lblResult.Text = "Помилка: знаменник не може бути нулем.";
//                 }
//             }
//             catch (FormatException)
//             {
//                 MessageBox.Show("Будь ласка, введіть коректні числа.");
//             }
//         }

//         private void BtnOpenParameters_Click(object sender, EventArgs e)
//         {
//             ParametersForm parametersForm = new ParametersForm(this);
//             parametersForm.ShowDialog();
//         }
//     }
// }
