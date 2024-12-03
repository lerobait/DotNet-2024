// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private CheckBox checkBoxSport;
//         private CheckBox checkBoxTravels;
//         private CheckBox checkBoxCrafting;
//         private CheckBox checkBoxPainting;

//         public Form1()
//         {
//             InitializeComponent();
//             InitializeSelectiveForm();
//         }

//         private void InitializeSelectiveForm()
//         {
//             GroupBox interestsGroupBox = new GroupBox
//             {
//                 Text = "Виберіть ваші інтереси:",
//                 Location = new Point(10, 10),
//                 Size = new Size(300, 200)
//             };

//             checkBoxSport = new CheckBox
//             {
//                 Text = "Спорт",
//                 Location = new Point(10, 20),
//                 Checked = true
//             };
//             checkBoxTravels = new CheckBox
//             {
//                 Text = "Мандрівки",
//                 Location = new Point(10, 50)
//             };
//             checkBoxCrafting = new CheckBox
//             {
//                 Text = "Майстрування",
//                 Location = new Point(10, 80),
//                 Checked = true
//             };
//             checkBoxPainting = new CheckBox
//             {
//                 Text = "Малювання",
//                 Location = new Point(10, 110)
//             };

//             interestsGroupBox.Controls.Add(checkBoxSport);
//             interestsGroupBox.Controls.Add(checkBoxTravels);
//             interestsGroupBox.Controls.Add(checkBoxCrafting);
//             interestsGroupBox.Controls.Add(checkBoxPainting);

//             Button selectButton = new Button
//             {
//                 Text = "Відіслати",
//                 Location = new Point(10, 220)
//             };
//             selectButton.Click += SelectButton_Click;

//             Button cancelButton = new Button
//             {
//                 Text = "Скинути",
//                 Location = new Point(100, 220)
//             };
//             cancelButton.Click += CancelButton_Click;

//             this.Controls.Add(interestsGroupBox);
//             this.Controls.Add(selectButton);
//             this.Controls.Add(cancelButton);
//         }

//         private void CancelButton_Click(object sender, EventArgs e)
//         {
//             checkBoxSport.Checked = true;
//             checkBoxTravels.Checked = false;
//             checkBoxCrafting.Checked = true;
//             checkBoxPainting.Checked = false;

//         }

//         private void SelectButton_Click(object sender, EventArgs e)
//         {
//             if (checkBoxSport.Checked)
//                 checkBoxSport.ForeColor = Color.Red;
//             else
//                 checkBoxSport.ForeColor = Color.Black;

//             if (checkBoxTravels.Checked)
//                 checkBoxTravels.ForeColor = Color.Red;
//             else
//                 checkBoxTravels.ForeColor = Color.Black;

//             if (checkBoxCrafting.Checked)
//                 checkBoxCrafting.ForeColor = Color.Red;
//             else
//                 checkBoxCrafting.ForeColor = Color.Black;

//             if (checkBoxPainting.Checked)
//                 checkBoxPainting.ForeColor = Color.Red;
//             else
//                 checkBoxPainting.ForeColor = Color.Black;
//         }
//     }
// }
