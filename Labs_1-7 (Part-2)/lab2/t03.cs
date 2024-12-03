// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//             InitializeRegistrationForm();
//         }

//         private void InitializeRegistrationForm()
//         {
//             Label nameLabel = new Label
//             {
//                 Text = "Ім'я",
//                 Location = new Point(10, 10)
//             };
//             TextBox nameTextBox = new TextBox
//             {
//                 Location = new Point(150, 10),
//                 Width = 200
//             };

//             Label phoneLabel = new Label
//             {
//                 Text = "Телефон",
//                 Location = new Point(10, 50)
//             };
//             TextBox phoneTextBox = new TextBox
//             {
//                 Location = new Point(150, 50),
//                 Width = 200
//             };

//             Label emailLabel = new Label
//             {
//                 Text = "Поштова скринька",
//                 Location = new Point(10, 90)
//             };
//             TextBox emailTextBox = new TextBox
//             {
//                 Location = new Point(150, 90),
//                 Width = 200
//             };

//             Label dobLabel = new Label
//             {
//                 Text = "Дата народження",
//                 Location = new Point(10, 130)
//             };
//             DateTimePicker dobPicker = new DateTimePicker
//             {
//                 Location = new Point(150, 130),
//                 Width = 200
//             };

//             Button sendButton = new Button
//             {
//                 Text = "Відправити",
//                 Location = new Point(150, 170)
//             };
//             Button resetButton = new Button
//             {
//                 Text = "Скинути",
//                 Location = new Point(250, 170)
//             };

//             this.Controls.Add(nameLabel);
//             this.Controls.Add(nameTextBox);
//             this.Controls.Add(phoneLabel);
//             this.Controls.Add(phoneTextBox);
//             this.Controls.Add(emailLabel);
//             this.Controls.Add(emailTextBox);
//             this.Controls.Add(dobLabel);
//             this.Controls.Add(dobPicker);
//             this.Controls.Add(sendButton);
//             this.Controls.Add(resetButton);
//         }
//     }
// }
