// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public class ResultForm : Form
// {
//     private Label lblResult;

//     public ResultForm(int x, int y, int z)
//     {
//         lblResult = new Label { Location = new System.Drawing.Point(20, 20), Width = 300 };

//         double numerator = 0;
//         double denominator = 0;

//         for (int i = 1; i <= x; i++)
//         {
//             numerator += (i - x * y);
//         }

//         for (int i = 1; i <= y; i++)
//         {
//             denominator += (i - x * z);
//         }

//         double result = numerator / denominator;

//         lblResult.Text = $"Результат: {result}";

//         Controls.Add(lblResult);
//     }
// }
// }