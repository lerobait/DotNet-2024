// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
// {
//     private Button btnOpenTriangleForm;
//     private Button btnOpenInputForm;

//     public Form1()
//     {
//         btnOpenTriangleForm = new Button { Text = "Відкрити форму трикутника", Location = new System.Drawing.Point(20, 20) };
//         btnOpenTriangleForm.Click += BtnOpenTriangleForm_Click;

//         btnOpenInputForm = new Button { Text = "Відкрити форму вводу", Location = new System.Drawing.Point(20, 60) };
//         btnOpenInputForm.Click += BtnOpenInputForm_Click;

//         Controls.Add(btnOpenTriangleForm);
//         Controls.Add(btnOpenInputForm);
//     }

//     private void BtnOpenTriangleForm_Click(object sender, EventArgs e)
//     {
//         var triangleForm = new TriangleForm();
//         triangleForm.Show();
//     }

//     private void BtnOpenInputForm_Click(object sender, EventArgs e)
//     {
//         var inputForm = new InputForm();
//         inputForm.Show();
//     }
// }
// }
