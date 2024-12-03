// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class InputForm : Form
// {
//     private TextBox txtSide1;
//     private TextBox txtSide2;
//     private TextBox txtSide3;
//     private Button btnSubmit;

//     public InputForm()
//     {
//         txtSide1 = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100 };
//         txtSide2 = new TextBox { Location = new System.Drawing.Point(20, 60), Width = 100 };
//         txtSide3 = new TextBox { Location = new System.Drawing.Point(20, 100), Width = 100 };

//         btnSubmit = new Button { Text = "Підтвердити", Location = new System.Drawing.Point(20, 140), Width = 100 };
//         btnSubmit.Click += BtnSubmit_Click;

//         Controls.Add(txtSide1);
//         Controls.Add(txtSide2);
//         Controls.Add(txtSide3);
//         Controls.Add(btnSubmit);
//     }

//     private void BtnSubmit_Click(object sender, EventArgs e)
//     {
//         double side1 = double.Parse(txtSide1.Text);
//         double side2 = double.Parse(txtSide2.Text);
//         double side3 = double.Parse(txtSide3.Text);

//         if (side1 <= 0 || side2 <= 0 || side3 <= 0)
//         {
//             MessageBox.Show("Будь ласка, введіть коректні сторони трикутника.");
//         }
//         else
//         {
//             var resultForm = new ResultForm(side1, side2, side3);
//             resultForm.Show();
//             this.Hide();
//         }
//     }
// }
// }