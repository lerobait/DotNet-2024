// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeCustomComponents();
//         }

//         private void InitializeCustomComponents()
//         {
//             this.Text = "Реєстраційна форма";
//             this.Size = new System.Drawing.Size(500, 650);

//             Label lblPassword = new Label { Text = "Введіть пароль:", Location = new System.Drawing.Point(20, 20), Width = 100 };
//             TextBox txtPassword = new TextBox { Location = new System.Drawing.Point(130, 20), Width = 300, PasswordChar = '*' };

//             GroupBox groupAbout = new GroupBox { Text = "Розкажіть про себе", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(500, 230) };

//             Label lblName = new Label { Text = "Ваше ім'я:", Location = new System.Drawing.Point(10, 30) };
//             TextBox txtName = new TextBox { Location = new System.Drawing.Point(150, 30), Width = 200, Text = "Анонім" };

//             Label lblAge = new Label { Text = "Ваш вік:", Location = new System.Drawing.Point(10, 70) };
//             ComboBox cmbAge = new ComboBox { Location = new System.Drawing.Point(150, 70), Width = 150 };
//             cmbAge.Items.AddRange(new string[] { "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });

//             Label lblGender = new Label { Text = "Ваша стать:", Location = new System.Drawing.Point(10, 110) };
//             RadioButton rbMale = new RadioButton { Text = "Чоловіча", Location = new System.Drawing.Point(150, 110) };
//             RadioButton rbFemale = new RadioButton { Text = "Жіноча", Location = new System.Drawing.Point(280, 110) };

//             Label lblInterests = new Label { Text = "Ваші інтереси:", Location = new System.Drawing.Point(10, 140) };
//             CheckBox cbComputers = new CheckBox { Text = "Комп'ютери", Location = new System.Drawing.Point(150, 140) };
//             CheckBox cbSports = new CheckBox { Text = "Спорт", Location = new System.Drawing.Point(150, 160) };
//             CheckBox cbArt = new CheckBox { Text = "Мистецтво", Location = new System.Drawing.Point(150, 180) };
//             CheckBox cbScience = new CheckBox { Text = "Наука", Location = new System.Drawing.Point(150, 200) };

//             groupAbout.Controls.Add(lblName);
//             groupAbout.Controls.Add(txtName);
//             groupAbout.Controls.Add(lblAge);
//             groupAbout.Controls.Add(cmbAge);
//             groupAbout.Controls.Add(lblGender);
//             groupAbout.Controls.Add(rbMale);
//             groupAbout.Controls.Add(rbFemale);
//             groupAbout.Controls.Add(lblInterests);
//             groupAbout.Controls.Add(cbComputers);
//             groupAbout.Controls.Add(cbSports);
//             groupAbout.Controls.Add(cbArt);
//             groupAbout.Controls.Add(cbScience);

//             GroupBox groupOpinion = new GroupBox { Text = "Ваша думка", Location = new System.Drawing.Point(20, 270), Size = new System.Drawing.Size(500, 250) };

//             Label lblFileName = new Label { Text = "Введіть ім'я файла з описом вашої думки:", Location = new System.Drawing.Point(10, 30) };
//             TextBox txtFileName = new TextBox { Location = new System.Drawing.Point(10, 60), Width = 400 };

//             Button btnFileChooser = new Button { Text = "Вибрати файл", Location = new System.Drawing.Point(320, 90) };
//             btnFileChooser.Click += (sender, e) =>
//             {
//                 using (OpenFileDialog openFileDialog = new OpenFileDialog())
//                 {
//                     if (openFileDialog.ShowDialog() == DialogResult.OK)
//                     {
//                         txtFileName.Text = openFileDialog.FileName;
//                     }
//                 }
//             };

//             Label lblOpinion = new Label { Text = "Або можете висловити свою думку прямо тут:", Location = new System.Drawing.Point(10, 120) };
//             TextBox txtOpinion = new TextBox { Location = new System.Drawing.Point(10, 150), Size = new System.Drawing.Size(400, 60), Multiline = true };

//             Button btnSubmit = new Button { Text = "Відправити", Location = new System.Drawing.Point(10, 220) };
//             Button btnClear = new Button { Text = "Очистити форму", Location = new System.Drawing.Point(120, 220) };

//             btnClear.Click += (sender, e) =>
//             {
//                 txtPassword.Clear();
//                 txtName.Text = "Анонім";
//                 cmbAge.SelectedIndex = -1;
//                 rbMale.Checked = false;
//                 rbFemale.Checked = false;
//                 cbComputers.Checked = false;
//                 cbSports.Checked = false;
//                 cbArt.Checked = false;
//                 cbScience.Checked = false;
//                 txtFileName.Clear();
//                 txtOpinion.Clear();
//             };

//             groupOpinion.Controls.Add(lblFileName);
//             groupOpinion.Controls.Add(txtFileName);
//             groupOpinion.Controls.Add(btnFileChooser);
//             groupOpinion.Controls.Add(lblOpinion);
//             groupOpinion.Controls.Add(txtOpinion);
//             groupOpinion.Controls.Add(btnSubmit);
//             groupOpinion.Controls.Add(btnClear);

//             this.Controls.Add(lblPassword);
//             this.Controls.Add(txtPassword);
//             this.Controls.Add(groupAbout);
//             this.Controls.Add(groupOpinion);
//         }
//     }
// }
