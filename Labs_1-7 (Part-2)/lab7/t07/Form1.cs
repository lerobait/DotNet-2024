// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
// {
//     private Button btnOpenInputForm;
//     private Button btnOpenCalculationForm;


//     public Form1()
//     {
//         btnOpenInputForm = new Button { Text = "Відкрити форму вводу", Location = new System.Drawing.Point(20, 20), Width = 150 };
//         btnOpenInputForm.Click += BtnOpenInputForm_Click;

//          btnOpenCalculationForm = new Button
//         {
//             Text = "Відкрити форму для обчислення",
//             Location = new System.Drawing.Point(20, 100),
//             Width = 200
//         };
//         btnOpenCalculationForm.Click += BtnOpenCalculationForm_Click;

//         Controls.Add(btnOpenCalculationForm);
//         Controls.Add(btnOpenInputForm);
//     }

//     private void BtnOpenInputForm_Click(object sender, EventArgs e)
//     {
//         var inputForm = new InputForm();
//         inputForm.Show();
//         this.Hide();
//     }

//     private void BtnOpenCalculationForm_Click(object sender, EventArgs e)
//     {
//         CalculationForm calculationForm = new CalculationForm();
//         calculationForm.ShowDialog();
//     }
// }
// }
