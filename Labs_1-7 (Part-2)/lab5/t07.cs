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

//         private Label priceLabel, additionalEquipmentLabel, discountLabel, totalLabel, convertedPriceLabel;
//         private ComboBox currencyComboBox;
//         private RadioButton extraWheelsRadio, basketRadio, lightRadio, lockRadio;
//         private TextBox quantityTextBox;
//         private decimal selectedModificationPrice = 0m;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Комплектація";
//             this.Size = new Size(400, 500);

//             Label mainLabel = new Label
//             {
//                 Text = "Конфігурація Велосипеда",
//                 Font = new Font("Arial", 16, FontStyle.Bold),
//                 Location = new Point(50, 20),
//                 AutoSize = true
//             };

//             GroupBox modificationsGroup = new GroupBox
//             {
//                 Text = "Оберіть модифікацію",
//                 Location = new Point(20, 60),
//                 Size = new Size(200, 140)
//             };

//             extraWheelsRadio = new RadioButton
//             {
//                 Text = $"Додаткові колеса (+{ExtraWheelsPrice} грн)",
//                 Location = new Point(10, 20),
//                 AutoSize = true
//             };
//             basketRadio = new RadioButton
//             {
//                 Text = $"Корзина (+{BasketPrice} грн)",
//                 Location = new Point(10, 45),
//                 AutoSize = true
//             };
//             lightRadio = new RadioButton
//             {
//                 Text = $"Лампа (+{LightPrice} грн)",
//                 Location = new Point(10, 70),
//                 AutoSize = true
//             };
//             lockRadio = new RadioButton
//             {
//                 Text = $"Замок (+{LockPrice} грн)",
//                 Location = new Point(10, 95),
//                 AutoSize = true
//             };

//             modificationsGroup.Controls.Add(extraWheelsRadio);
//             modificationsGroup.Controls.Add(basketRadio);
//             modificationsGroup.Controls.Add(lightRadio);
//             modificationsGroup.Controls.Add(lockRadio);

//             extraWheelsRadio.CheckedChanged += OnModificationChanged;
//             basketRadio.CheckedChanged += OnModificationChanged;
//             lightRadio.CheckedChanged += OnModificationChanged;
//             lockRadio.CheckedChanged += OnModificationChanged;

//             Label quantityLabel = new Label
//             {
//                 Text = "Кількість:",
//                 Location = new Point(20, 220),
//                 AutoSize = true
//             };

//             quantityTextBox = new TextBox
//             {
//                 Location = new Point(100, 215),
//                 Width = 50,
//                 Text = "1"
//             };

//             currencyComboBox = new ComboBox
//             {
//                 Location = new Point(20, 250),
//                 Width = 150
//             };
//             currencyComboBox.Items.AddRange(new string[] { "Гривня", "Долар США" });
//             currencyComboBox.SelectedIndex = 0;
//             currencyComboBox.SelectedIndexChanged += (sender, e) => UpdatePrices();

//             Button okButton = new Button
//             {
//                 Text = "ОК",
//                 Location = new Point(150, 290),
//                 AutoSize = true
//             };
//             okButton.Click += (sender, e) => UpdatePrices();

//             priceLabel = new Label { Text = "Ціна у вибраній комплектації: 0 грн", Location = new Point(20, 330), AutoSize = true };
//             additionalEquipmentLabel = new Label { Text = "В тому числі дод. обладнання: 0 грн", Location = new Point(20, 350), AutoSize = true };
//             discountLabel = new Label { Text = "Знижка на нове обладнання 10%: 0 грн", Location = new Point(20, 370), AutoSize = true };
//             totalLabel = new Label { Text = "Разом: 0 грн", Location = new Point(20, 390), AutoSize = true };
//             convertedPriceLabel = new Label { Text = "Ціна в обраній валюті: 0", Location = new Point(20, 410), AutoSize = true };

//             this.Controls.Add(mainLabel);
//             this.Controls.Add(modificationsGroup);
//             this.Controls.Add(quantityLabel);
//             this.Controls.Add(quantityTextBox);
//             this.Controls.Add(currencyComboBox);
//             this.Controls.Add(okButton);
//             this.Controls.Add(priceLabel);
//             this.Controls.Add(additionalEquipmentLabel);
//             this.Controls.Add(discountLabel);
//             this.Controls.Add(totalLabel);
//             this.Controls.Add(convertedPriceLabel);
//         }

//         private void OnModificationChanged(object sender, EventArgs e)
//         {
//             if (extraWheelsRadio.Checked) selectedModificationPrice = ExtraWheelsPrice;
//             else if (basketRadio.Checked) selectedModificationPrice = BasketPrice;
//             else if (lightRadio.Checked) selectedModificationPrice = LightPrice;
//             else if (lockRadio.Checked) selectedModificationPrice = LockPrice;
//         }

//         private void UpdatePrices()
//         {
//             if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity < 1)
//             {
//                 MessageBox.Show("Будь ласка, введіть коректну кількість (1 або більше).");
//                 return;
//             }

//             decimal basePrice = BasePrice;
//             decimal additionalPrice = selectedModificationPrice * quantity;
//             decimal totalPrice = basePrice + additionalPrice;

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
