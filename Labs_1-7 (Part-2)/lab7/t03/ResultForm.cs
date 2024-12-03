// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class ResultForm : Form
// {
//     private Label lblPerimeter;
//     private Label lblArea;

//     public ResultForm(double side1, double side2, double side3)
//     {
//         lblPerimeter = new Label { Location = new System.Drawing.Point(20, 20), Width = 300 };
//         lblArea = new Label { Location = new System.Drawing.Point(20, 60), Width = 300 };

//         double perimeter = side1 + side2 + side3;
//         double semiPerimeter = perimeter / 2;
//         double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

//         lblPerimeter.Text = $"Периметр: {perimeter}";
//         lblArea.Text = $"Площа: {area}";

//         Controls.Add(lblPerimeter);
//         Controls.Add(lblArea);
//     }
// }
// }