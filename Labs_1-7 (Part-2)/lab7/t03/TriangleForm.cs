// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class TriangleForm : Form
// {
//     private TextBox txtSide1;
//     private TextBox txtSide2;
//     private TextBox txtSide3;
//     private Button btnCalculate;
//     private Label lblPerimeter;
//     private Label lblArea;

//     public TriangleForm()
//     {
//         txtSide1 = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100 };
//         txtSide2 = new TextBox { Location = new System.Drawing.Point(20, 60), Width = 100 };
//         txtSide3 = new TextBox { Location = new System.Drawing.Point(20, 100), Width = 100 };
        
//         btnCalculate = new Button { Text = "Розрахувати", Location = new System.Drawing.Point(20, 140), Width = 100 };
//         btnCalculate.Click += BtnCalculate_Click;

//         lblPerimeter = new Label { Location = new System.Drawing.Point(20, 180), Width = 300 };
//         lblArea = new Label { Location = new System.Drawing.Point(20, 220), Width = 300 };

//         Controls.Add(txtSide1);
//         Controls.Add(txtSide2);
//         Controls.Add(txtSide3);
//         Controls.Add(btnCalculate);
//         Controls.Add(lblPerimeter);
//         Controls.Add(lblArea);
//     }

//     private void BtnCalculate_Click(object sender, EventArgs e)
//     {
//         try
//         {
//             double side1 = double.Parse(txtSide1.Text);
//             double side2 = double.Parse(txtSide2.Text);
//             double side3 = double.Parse(txtSide3.Text);

//             if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
//             {
//                 MessageBox.Show("Невірно введені сторони трикутника.");
//                 return;
//             }

//             double perimeter = side1 + side2 + side3;
//             double semiPerimeter = perimeter / 2;
//             double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

//             lblPerimeter.Text = $"Периметр: {perimeter}";
//             lblArea.Text = $"Площа: {area}";
//         }
//         catch (Exception)
//         {
//             MessageBox.Show("Будь ласка, введіть коректні числа.");
//         }
//     }
// }
// }
