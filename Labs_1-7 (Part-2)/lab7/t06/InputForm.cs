// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public class InputForm : Form
// {
//     private TextBox txtX;
//     private TextBox txtY;
//     private TextBox txtZ;
//     private Button btnCalculate;

//     public InputForm()
//     {
//         txtX = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100 };
//         txtY = new TextBox { Location = new System.Drawing.Point(20, 60), Width = 100 };
//         txtZ = new TextBox { Location = new System.Drawing.Point(20, 100), Width = 100 };

//         btnCalculate = new Button { Text = "Розрахувати", Location = new System.Drawing.Point(20, 140), Width = 100 };
//         btnCalculate.Click += BtnCalculate_Click;

//         Controls.Add(txtX);
//         Controls.Add(txtY);
//         Controls.Add(txtZ);
//         Controls.Add(btnCalculate);
//     }

//     private void BtnCalculate_Click(object sender, EventArgs e)
//     {
//         try
//         {
//             int x = int.Parse(txtX.Text);
//             int y = int.Parse(txtY.Text);
//             int z = int.Parse(txtZ.Text);

//             var resultForm = new ResultForm(x, y, z);
//             resultForm.Show();
//             this.Hide();
//         }
//         catch (Exception)
//         {
//             MessageBox.Show("Будь ласка, введіть коректні числа.");
//         }
//     }
// }
// }