// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
// {
//     private ComboBox cmbCities;
//     private Button btnShowCityDetails;

//     public Form1()
//     {
//         cmbCities = new ComboBox
//         {
//             Location = new System.Drawing.Point(20, 20),
//             Width = 200
//         };

//         cmbCities.Items.Add("Київ");
//         cmbCities.Items.Add("Львів");
//         cmbCities.Items.Add("Одеса");
//         cmbCities.Items.Add("Харків");
//         cmbCities.Items.Add("Дніпро");
//         cmbCities.Items.Add("Чернівці");

//         btnShowCityDetails = new Button
//         {
//             Text = "Показати деталі міста",
//             Location = new System.Drawing.Point(20, 60),
//             Width = 200
//         };

//         btnShowCityDetails.Click += BtnShowCityDetails_Click;

//         Controls.Add(cmbCities);
//         Controls.Add(btnShowCityDetails);
//     }

//     private void BtnShowCityDetails_Click(object sender, EventArgs e)
//     {
//         string selectedCity = cmbCities.SelectedItem?.ToString();

//         if (!string.IsNullOrEmpty(selectedCity))
//         {
//             CityDetailsForm cityDetailsForm = new CityDetailsForm(selectedCity);
//             cityDetailsForm.ShowDialog();
//         }
//         else
//         {
//             MessageBox.Show("Будь ласка, виберіть місто.");
//         }
//     }
// }
// }
