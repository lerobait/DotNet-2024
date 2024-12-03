// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace BicycleConfigurationApp
// {
//   public partial class ConfigurationForm : Form
//   {
//     private const decimal BasePrice = 15000m;
//     private const decimal ExtraWheelsPrice = 2000m;
//     private const decimal BasketPrice = 500m;
//     private const decimal LightPrice = 300m;
//     private const decimal LockPrice = 400m;
//     private const decimal UsdExchangeRate = 37m;

//     private const decimal WholesaleDiscountRate = 0.2m;
//     private const int WholesaleThreshold = 10;

//     private Label priceLabel, additionalEquipmentLabel, discountLabel, totalLabel, convertedPriceLabel;
//     private ComboBox modificationComboBox, currencyComboBox, pricingModeComboBox;
//     private TextBox quantityTextBox;
//     private decimal selectedModificationPrice = 0m;

//     public ConfigurationForm()
//     {
//       InitializeComponent();
//     }

//     private void InitializeComponent()
//     {
//       this.Text = "Комплектація";
//       this.Size = new Size(400, 550);

//       Label mainLabel = new Label
//       {
//         Text = "Конфігурація Велосипеда",
//         Font = new Font("Arial", 16, FontStyle.Bold),
//         Location = new Point(50, 20),
//         AutoSize = true
//       };

//       Label modificationLabel = new Label
//       {
//         Text = "Оберіть модифікацію",
//         Location = new Point(20, 60),
//         AutoSize = true
//       };

//       modificationComboBox = new ComboBox
//       {
//         Location = new Point(20, 85),
//         Width = 250,
//         DropDownStyle = ComboBoxStyle.DropDownList
//       };
//       modificationComboBox.Items.AddRange(new object[]
//       {
//                 "Без додаткової модифікації",
//                 $"Додаткові колеса (+{ExtraWheelsPrice} грн)",
//                 $"Корзина (+{BasketPrice} грн)",
//                 $"Лампа (+{LightPrice} грн)",
//                 $"Замок (+{LockPrice} грн)"
//       });
//       modificationComboBox.SelectedIndex = 0;
//       modificationComboBox.SelectedIndexChanged += OnModificationChanged;

//       Label quantityLabel = new Label
//       {
//         Text = "Кількість:",
//         Location = new Point(20, 130),
//         AutoSize = true
//       };

//       quantityTextBox = new TextBox
//       {
//         Location = new Point(100, 125),
//         Width = 50,
//         Text = "1"
//       };

//       currencyComboBox = new ComboBox
//       {
//         Location = new Point(20, 160),
//         Width = 150
//       };
//       currencyComboBox.Items.AddRange(new string[] { "Гривня", "Долар США" });
//       currencyComboBox.SelectedIndex = 0;
//       currencyComboBox.SelectedIndexChanged += (sender, e) => UpdatePrices();

//       pricingModeComboBox = new ComboBox
//       {
//         Location = new Point(20, 190),
//         Width = 150
//       };
//       pricingModeComboBox.Items.AddRange(new string[] { "Роздрібна", "Оптова" });
//       pricingModeComboBox.SelectedIndex = 0;
//       pricingModeComboBox.SelectedIndexChanged += (sender, e) => UpdatePrices();

//       Button okButton = new Button
//       {
//         Text = "ОК",
//         Location = new Point(150, 230),
//         AutoSize = true
//       };
//       okButton.Click += (sender, e) => UpdatePrices();

//       priceLabel = new Label { Text = "Ціна у вибраній комплектації: 0 грн", Location = new Point(20, 270), AutoSize = true };
//       additionalEquipmentLabel = new Label { Text = "В тому числі дод. обладнання: 0 грн", Location = new Point(20, 290), AutoSize = true };
//       discountLabel = new Label { Text = "Знижка на нове обладнання 10%: 0 грн", Location = new Point(20, 310), AutoSize = true };
//       totalLabel = new Label { Text = "Разом: 0 грн", Location = new Point(20, 330), AutoSize = true };
//       convertedPriceLabel = new Label { Text = "Ціна в обраній валюті: 0", Location = new Point(20, 350), AutoSize = true };

//       this.Controls.Add(mainLabel);
//       this.Controls.Add(modificationLabel);
//       this.Controls.Add(modificationComboBox);
//       this.Controls.Add(quantityLabel);
//       this.Controls.Add(quantityTextBox);
//       this.Controls.Add(currencyComboBox);
//       this.Controls.Add(pricingModeComboBox);
//       this.Controls.Add(okButton);
//       this.Controls.Add(priceLabel);
//       this.Controls.Add(additionalEquipmentLabel);
//       this.Controls.Add(discountLabel);
//       this.Controls.Add(totalLabel);
//       this.Controls.Add(convertedPriceLabel);
//     }

//     private void OnModificationChanged(object sender, EventArgs e)
//     {
//       switch (modificationComboBox.SelectedIndex)
//       {
//         case 1:
//           selectedModificationPrice = ExtraWheelsPrice;
//           break;
//         case 2:
//           selectedModificationPrice = BasketPrice;
//           break;
//         case 3:
//           selectedModificationPrice = LightPrice;
//           break;
//         case 4:
//           selectedModificationPrice = LockPrice;
//           break;
//         default:
//           selectedModificationPrice = 0m;
//           break;
//       }
//     }

//     private void UpdatePrices()
//     {
//       if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity < 1)
//       {
//         MessageBox.Show("Будь ласка, введіть коректну кількість (1 або більше).");
//         return;
//       }

//       decimal basePrice = BasePrice;
//       decimal additionalPrice = selectedModificationPrice * quantity;
//       decimal totalPrice = basePrice + additionalPrice;

//       decimal discount = 0.1m * additionalPrice;
//       decimal discountedPrice = totalPrice - discount;

//       if (pricingModeComboBox.SelectedItem.ToString() == "Оптова" && quantity >= WholesaleThreshold)
//       {
//         discountedPrice -= discountedPrice * WholesaleDiscountRate;
//       }

//       priceLabel.Text = $"Ціна у вибраній комплектації: {totalPrice:F2} грн";
//       additionalEquipmentLabel.Text = $"В тому числі дод. обладнання: {additionalPrice:F2} грн";
//       discountLabel.Text = $"Знижка на нове обладнання 10%: {discount:F2} грн";
//       totalLabel.Text = $"Разом: {discountedPrice:F2} грн";

//       string selectedCurrency = currencyComboBox.SelectedItem.ToString();
//       if (selectedCurrency == "Долар США")
//       {
//         decimal convertedPrice = discountedPrice / UsdExchangeRate;
//         convertedPriceLabel.Text = $"Ціна в доларах США: {convertedPrice:F2} USD";
//       }
//       else
//       {
//         convertedPriceLabel.Text = $"Ціна у гривнях: {discountedPrice:F2} грн";
//       }
//     }

//     [STAThread]
//     static void Main()
//     {
//       Application.EnableVisualStyles();
//       Application.SetCompatibleTextRenderingDefault(false);
//       Application.Run(new ConfigurationForm());
//     }
//   }
// }