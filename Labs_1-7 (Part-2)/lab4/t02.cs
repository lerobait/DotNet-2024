// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private RadioButton radioButtonKharkiv;
//         private RadioButton radioButtonKyiv;
//         private RadioButton radioButtonOdesa;
//         private RadioButton radioButtonZaporizhzhia;
//         private RadioButton radioButtonBus;
//         private RadioButton radioButtonTrain;
//         private RadioButton radioButtonPlane;

//         public Form1()
//         {
//             InitializeComponent();
//             InitializeRadioForm();
//         }

//         private void InitializeRadioForm()
//         {
//             GroupBox cityGroupBox = new GroupBox
//             {
//                 Text = "Виберіть місто:",
//                 Location = new Point(10, 10),
//                 Size = new Size(200, 150)
//             };

//             radioButtonKharkiv = new RadioButton
//             {
//                 Text = "Харків",
//                 Location = new Point(10, 20),
//                 Checked = true
//             };
//             radioButtonKyiv = new RadioButton
//             {
//                 Text = "Київ",
//                 Location = new Point(10, 50)
//             };
//             radioButtonOdesa = new RadioButton
//             {
//                 Text = "Одеса",
//                 Location = new Point(10, 80)
//             };
//             radioButtonZaporizhzhia = new RadioButton
//             {
//                 Text = "Запоріжжя",
//                 Location = new Point(10, 110)
//             };

//             cityGroupBox.Controls.Add(radioButtonKharkiv);
//             cityGroupBox.Controls.Add(radioButtonKyiv);
//             cityGroupBox.Controls.Add(radioButtonOdesa);
//             cityGroupBox.Controls.Add(radioButtonZaporizhzhia);

//             GroupBox transportGroupBox = new GroupBox
//             {
//                 Text = "Виберіть транспорт:",
//                 Location = new Point(220, 10),
//                 Size = new Size(200, 150)
//             };

//             radioButtonBus = new RadioButton
//             {
//                 Text = "Автобус",
//                 Location = new Point(10, 20),
//                 Checked = true
//             };
//             radioButtonTrain = new RadioButton
//             {
//                 Text = "Потяг",
//                 Location = new Point(10, 50)
//             };
//             radioButtonPlane = new RadioButton
//             {
//                 Text = "Літак",
//                 Location = new Point(10, 80)
//             };

//             transportGroupBox.Controls.Add(radioButtonBus);
//             transportGroupBox.Controls.Add(radioButtonTrain);
//             transportGroupBox.Controls.Add(radioButtonPlane);

//             Button selectButton = new Button
//             {
//                 Text = "Вибрати",
//                 Location = new Point(10, 170)
//             };
//             selectButton.Click += SelectButton_Click;

//             Button cancelButton = new Button
//             {
//                 Text = "Відмовитися",
//                 Location = new Point(220, 170)
//             };
//             cancelButton.Click += CancelButton_Click;

//             this.Controls.Add(cityGroupBox);
//             this.Controls.Add(transportGroupBox);
//             this.Controls.Add(selectButton);
//             this.Controls.Add(cancelButton);
//         }

//         private void SelectButton_Click(object sender, EventArgs e)
//         {
//             Color newColor = Color.Red;

//             if (radioButtonKharkiv.Checked)
//                 radioButtonKharkiv.ForeColor = newColor;
//             else if (radioButtonKyiv.Checked)
//                 radioButtonKyiv.ForeColor = newColor;
//             else if (radioButtonOdesa.Checked)
//                 radioButtonOdesa.ForeColor = newColor;
//             else if (radioButtonZaporizhzhia.Checked)
//                 radioButtonZaporizhzhia.ForeColor = newColor;

//             if (radioButtonBus.Checked)
//                 radioButtonBus.ForeColor = newColor;
//             else if (radioButtonTrain.Checked)
//                 radioButtonTrain.ForeColor = newColor;
//             else if (radioButtonPlane.Checked)
//                 radioButtonPlane.ForeColor = newColor;
//         }

//         private void CancelButton_Click(object sender, EventArgs e)
//         {
//             radioButtonKharkiv.Checked = true;
//             radioButtonBus.Checked = true;

//             radioButtonKharkiv.ForeColor = SystemColors.WindowText;
//             radioButtonKyiv.ForeColor = SystemColors.WindowText;
//             radioButtonOdesa.ForeColor = SystemColors.WindowText;
//             radioButtonZaporizhzhia.ForeColor = SystemColors.WindowText;
//             radioButtonBus.ForeColor = SystemColors.WindowText;
//             radioButtonTrain.ForeColor = SystemColors.WindowText;
//             radioButtonPlane.ForeColor = SystemColors.WindowText;
//         }
//     }
// }
