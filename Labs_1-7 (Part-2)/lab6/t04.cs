// using System;
// using System.Drawing;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         private Label label1, label2, label3;
//         private TextBox input1, input2, input3;
//         private Button button1;
//         private ListView listView;

//         public Form1()
//         {
//             InitializeComponentCustom();
//         }

//         private void InitializeComponentCustom()
//         {
//             this.Text = "Фінансовий Калькулятор";
//             this.Size = new Size(600, 400);

//             label1 = new Label
//             {
//                 Text = "Сума:",
//                 Location = new Point(10, 10),
//                 AutoSize = true
//             };
//             this.Controls.Add(label1);

//             input1 = new TextBox
//             {
//                 Location = new Point(100, 10),
//                 Width = 100
//             };
//             this.Controls.Add(input1);

//             label2 = new Label
//             {
//                 Text = "Термін (міс.):",
//                 Location = new Point(10, 40),
//                 AutoSize = true
//             };
//             this.Controls.Add(label2);

//             input2 = new TextBox
//             {
//                 Location = new Point(100, 40),
//                 Width = 100
//             };
//             this.Controls.Add(input2);

//             label3 = new Label
//             {
//                 Text = "Відсоткова ставка:",
//                 Location = new Point(10, 70),
//                 AutoSize = true
//             };
//             this.Controls.Add(label3);

//             input3 = new TextBox
//             {
//                 Location = new Point(100, 70),
//                 Width = 100
//             };
//             this.Controls.Add(input3);

//             button1 = new Button
//             {
//                 Text = "ОК",
//                 Location = new Point(10, 100),
//                 Width = 100
//             };
//             button1.Click += new EventHandler(button1_Click);
//             this.Controls.Add(button1);

//             listView = new ListView
//             {
//                 Location = new Point(10, 140),
//                 Size = new Size(550, 200),
//                 View = View.Details,
//                 FullRowSelect = true,
//                 GridLines = true
//             };
//             listView.Columns.Add("Місяць", 80);
//             listView.Columns.Add("Борг", 120);
//             listView.Columns.Add("Відсоток", 120);
//             listView.Columns.Add("Платіж", 120);
//             this.Controls.Add(listView);
//         }

//         private void button1_Click(object sender, EventArgs e)
//         {
//             listView.Items.Clear();

//             if (decimal.TryParse(input1.Text, out decimal principal) &&
//                 int.TryParse(input2.Text, out int months) &&
//                 decimal.TryParse(input3.Text, out decimal interestRate))
//             {
//                 decimal monthlyRate = interestRate / 100 / 12;
//                 decimal monthlyPayment = principal * monthlyRate / (1 - (decimal)Math.Pow(1 + (double)monthlyRate, -months));
//                 decimal balance = principal;

//                 for (int i = 1; i <= months; i++)
//                 {
//                     decimal interest = balance * monthlyRate;
//                     decimal principalPayment = monthlyPayment - interest;
//                     balance -= principalPayment;

//                     ListViewItem item = new ListViewItem(i.ToString());
//                     item.SubItems.Add(balance.ToString("F2"));
//                     item.SubItems.Add(interest.ToString("F2"));
//                     item.SubItems.Add(monthlyPayment.ToString("F2"));

//                     listView.Items.Add(item);
//                 }
//             }
//             else
//             {
//                 MessageBox.Show("Будь ласка, введіть коректні числові значення для всіх полів.");
//             }
//         }
//     }
// }
