// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private const decimal BasePrice = 15000m;
//         private const decimal ExtraWheelsPrice = 2000m;
//         private const decimal BasketPrice = 500m;
//         private const decimal LightPrice = 300m;
//         private const decimal LockPrice = 400m;

//         private const decimal UsdExchangeRate = 37m;

//         private Label priceLabel;
//         private Label additionalEquipmentLabel;
//         private Label discountLabel;
//         private Label totalLabel;
//         private Label convertedPriceLabel;

//         private ComboBox currencyComboBox;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Комплектація";
//             this.Size = new Size(400, 450);

//             Label mainLabel = new Label
//             {
//                 Text = "Конфігурація Велосипеда",
//                 Font = new Font("Arial", 16, FontStyle.Bold),
//                 Location = new Point(50, 20),
//                 AutoSize = true
//             };

//             CheckBox extraWheelsCheckBox = new CheckBox
//             {
//                 Text = "Додаткові колеса (+2000 грн)",
//                 Location = new Point(20, 70),
//                 AutoSize = true
//             };

//             CheckBox basketCheckBox = new CheckBox
//             {
//                 Text = "Корзина (+500 грн)",
//                 Location = new Point(20, 100),
//                 AutoSize = true
//             };

//             CheckBox lightCheckBox = new CheckBox
//             {
//                 Text = "Лампа (+300 грн)",
//                 Location = new Point(20, 130),
//                 AutoSize = true
//             };

//             CheckBox lockCheckBox = new CheckBox
//             {
//                 Text = "Замок (+400 грн)",
//                 Location = new Point(20, 160),
//                 AutoSize = true
//             };

//             PictureBox bikePictureBox = new PictureBox
//             {
//                 Image = Image.FromFile("bike_image.jpg"),
//                 Location = new Point(200, 70),
//                 SizeMode = PictureBoxSizeMode.StretchImage,
//                 Size = new Size(150, 150)
//             };

//             currencyComboBox = new ComboBox
//             {
//                 Location = new Point(20, 200),
//                 Width = 150
//             };
//             currencyComboBox.Items.AddRange(new string[] { "Гривня", "Долар США" });
//             currencyComboBox.SelectedIndex = 0;
//             currencyComboBox.SelectedIndexChanged += (sender, e) => UpdatePrices(extraWheelsCheckBox.Checked, basketCheckBox.Checked, lightCheckBox.Checked, lockCheckBox.Checked);

//             Button okButton = new Button
//             {
//                 Text = "ОК",
//                 Location = new Point(150, 240),
//                 AutoSize = true
//             };
//             okButton.Click += (sender, e) =>
//             {
//                 UpdatePrices(extraWheelsCheckBox.Checked, basketCheckBox.Checked, lightCheckBox.Checked, lockCheckBox.Checked);
//             };

//             priceLabel = new Label
//             {
//                 Text = "Ціна у вибраній комплектації: 0 грн",
//                 Location = new Point(20, 280),
//                 AutoSize = true
//             };

//             additionalEquipmentLabel = new Label
//             {
//                 Text = "В тому числі дод. обладнання: 0 грн",
//                 Location = new Point(20, 300),
//                 AutoSize = true
//             };

//             discountLabel = new Label
//             {
//                 Text = "Знижка на нове обладнання 10%: 0 грн",
//                 Location = new Point(20, 320),
//                 AutoSize = true
//             };

//             totalLabel = new Label
//             {
//                 Text = "Разом: 0 грн",
//                 Location = new Point(20, 340),
//                 AutoSize = true
//             };

//             convertedPriceLabel = new Label
//             {
//                 Text = "Ціна в обраній валюті: 0",
//                 Location = new Point(20, 360),
//                 AutoSize = true
//             };

//             this.Controls.Add(mainLabel);
//             this.Controls.Add(extraWheelsCheckBox);
//             this.Controls.Add(basketCheckBox);
//             this.Controls.Add(lightCheckBox);
//             this.Controls.Add(lockCheckBox);
//             this.Controls.Add(bikePictureBox);
//             this.Controls.Add(currencyComboBox);
//             this.Controls.Add(okButton);
//             this.Controls.Add(priceLabel);
//             this.Controls.Add(additionalEquipmentLabel);
//             this.Controls.Add(discountLabel);
//             this.Controls.Add(totalLabel);
//             this.Controls.Add(convertedPriceLabel);
//         }

//         private void UpdatePrices(bool extraWheels, bool basket, bool light, bool lockComponent)
//         {
//             decimal totalPrice = BasePrice;
//             decimal additionalPrice = 0;

//             if (extraWheels)
//                 additionalPrice += ExtraWheelsPrice;

//             if (basket)
//                 additionalPrice += BasketPrice;

//             if (light)
//                 additionalPrice += LightPrice;

//             if (lockComponent)
//                 additionalPrice += LockPrice;

//             totalPrice += additionalPrice;

//             decimal discount = 0.1m * additionalPrice;
//             decimal discountedPrice = totalPrice - discount;

//             priceLabel.Text = $"Ціна у вибраній комплектації: {totalPrice:F2} грн";
//             additionalEquipmentLabel.Text = $"В тому числі дод. обладнання: {additionalPrice:F2} грн";
//             discountLabel.Text = $"Знижка на нове обладнання 10%: {discount:F2} грн";
//             totalLabel.Text = $"Разом: {discountedPrice:F2} грн";

//             string selectedCurrency = currencyComboBox.SelectedItem.ToString();
//             if (selectedCurrency == "Долар США")
//             {
//                 decimal convertedPrice = discountedPrice / UsdExchangeRate;
//                 convertedPriceLabel.Text = $"Ціна в доларах США: {convertedPrice:F2} USD";
//             }
//             else
//             {
//                 convertedPriceLabel.Text = $"Ціна у гривнях: {discountedPrice:F2} грн";
//             }
//         }

//     }
// }
