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
//       InitializeRadioForm();
//     }

//     private void InitializeRadioForm()
//     {
//       GroupBox cityGroupBox = new GroupBox
//       {
//         Text = "Виберіть місто:",
//         Location = new Point(10, 10),
//         Size = new Size(200, 150)
//       };

//       RadioButton radioButtonKharkiv = new RadioButton
//       {
//         Text = "Харків",
//         Location = new Point(10, 20),
//         Checked = true
//       };
//       RadioButton radioButtonKyiv = new RadioButton
//       {
//         Text = "Київ",
//         Location = new Point(10, 50)
//       };
//       RadioButton radioButtonOdesa = new RadioButton
//       {
//         Text = "Одеса",
//         Location = new Point(10, 80)
//       };
//       RadioButton radioButtonZaporizhzhia = new RadioButton
//       {
//         Text = "Запоріжжя",
//         Location = new Point(10, 110)
//       };

//       cityGroupBox.Controls.Add(radioButtonKharkiv);
//       cityGroupBox.Controls.Add(radioButtonKyiv);
//       cityGroupBox.Controls.Add(radioButtonOdesa);
//       cityGroupBox.Controls.Add(radioButtonZaporizhzhia);

//       GroupBox transportGroupBox = new GroupBox
//       {
//         Text = "Виберіть транспорт:",
//         Location = new Point(220, 10),
//         Size = new Size(200, 150)
//       };

//       RadioButton radioButtonBus = new RadioButton
//       {
//         Text = "Автобус",
//         Location = new Point(10, 20),
//         Checked = true
//       };
//       RadioButton radioButtonTrain = new RadioButton
//       {
//         Text = "Потяг",
//         Location = new Point(10, 50)
//       };
//       RadioButton radioButtonPlane = new RadioButton
//       {
//         Text = "Літак",
//         Location = new Point(10, 80)
//       };

//       transportGroupBox.Controls.Add(radioButtonBus);
//       transportGroupBox.Controls.Add(radioButtonTrain);
//       transportGroupBox.Controls.Add(radioButtonPlane);

//       Button selectButton = new Button
//       {
//         Text = "Вибрати",
//         Location = new Point(10, 170)
//       };
//       Button cancelButton = new Button
//       {
//         Text = "Відмовитися",
//         Location = new Point(220, 170)
//       };

//       this.Controls.Add(cityGroupBox);
//       this.Controls.Add(transportGroupBox);
//       this.Controls.Add(selectButton);
//       this.Controls.Add(cancelButton);
//     }
//   }
// }
