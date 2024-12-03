// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class ParametersForm : Form
//     {
//         private Button btnChangeColor;
//         private Button btnChangeFont;
//         private ColorDialog colorDialog;
//         private FontDialog fontDialog;
//         private Form mainForm;

//         public ParametersForm(Form mainForm)
//         {
//             this.mainForm = mainForm;

//             btnChangeColor = new Button { Text = "Змінити колір", Location = new Point(20, 20), Width = 200 };
//             btnChangeFont = new Button { Text = "Змінити шрифт", Location = new Point(20, 60), Width = 200 };

//             colorDialog = new ColorDialog();
//             fontDialog = new FontDialog();

//             btnChangeColor.Click += BtnChangeColor_Click;
//             btnChangeFont.Click += BtnChangeFont_Click;

//             Controls.Add(btnChangeColor);
//             Controls.Add(btnChangeFont);
//         }

//         private void BtnChangeColor_Click(object sender, EventArgs e)
//         {
//             if (colorDialog.ShowDialog() == DialogResult.OK)
//             {
//                 mainForm.BackColor = colorDialog.Color;
//             }
//         }

//         private void BtnChangeFont_Click(object sender, EventArgs e)
//         {
//             if (fontDialog.ShowDialog() == DialogResult.OK)
//             {
//                 mainForm.Font = fontDialog.Font;
//             }
//         }
//     }
// }
