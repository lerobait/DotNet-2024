// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const int MaxDigits = 7;

//         public Form1()
//         {
//             InitializeComponent();
//             InitializeComboBox();
//         }

//         private void InitializeComboBox()
//         {
//             ComboBox comboBox = new ComboBox
//             {
//                 Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 100) / 2),
//                 Size = new System.Drawing.Size(200, 30),
//             };

//             comboBox.Items.Add("Київ");
//             comboBox.Items.Add("Львів");
//             comboBox.Items.Add("Одеса");
//             comboBox.Items.Add("Харків");
//             comboBox.Items.Add("Дніпро");

//             comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

//             this.Controls.Add(comboBox);
//         }

//         private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
//         {
//             ComboBox comboBox = sender as ComboBox;
//             string selectedCity = comboBox.SelectedItem.ToString();

//             MessageBox.Show($"Вибране місто: {selectedCity}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
//         }
//     }
// }
