// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//   public partial class Form1 : Form
//   {
//     public Form1()
//     {
//       InitializeComponent();
//       InitializeSelectiveForm();
//     }

//     private void InitializeSelectiveForm()
//     {
//       GroupBox interestsGroupBox = new GroupBox
//       {
//         Text = "Виберіть ваші інтереси:",
//         Location = new Point(10, 10),
//         Size = new Size(300, 200)
//       };

//       CheckBox checkBoxSport = new CheckBox
//       {
//         Text = "Спорт",
//         Location = new Point(10, 20),
//         Checked = true
//       };
//       CheckBox checkBoxTravels = new CheckBox
//       {
//         Text = "Мандрівки",
//         Location = new Point(10, 50)
//       };
//       CheckBox checkBoxCrafting = new CheckBox
//       {
//         Text = "Майстрування",
//         Location = new Point(10, 80),
//         Checked = true
//       };
//       CheckBox checkBoxPainting = new CheckBox
//       {
//         Text = "Малювання",
//         Location = new Point(10, 110)
//       };

//       interestsGroupBox.Controls.Add(checkBoxSport);
//       interestsGroupBox.Controls.Add(checkBoxTravels);
//       interestsGroupBox.Controls.Add(checkBoxCrafting);
//       interestsGroupBox.Controls.Add(checkBoxPainting);

//       Button selectButton = new Button
//       {
//         Text = "Вибрати",
//         Location = new Point(10, 220)
//       };
//       Button cancelButton = new Button
//       {
//         Text = "Відмовитися",
//         Location = new Point(100, 220)
//       };

//       this.Controls.Add(interestsGroupBox);
//       this.Controls.Add(selectButton);
//       this.Controls.Add(cancelButton);
//     }
//   }
// }
