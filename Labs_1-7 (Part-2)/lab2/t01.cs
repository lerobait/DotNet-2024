// using System;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//             InitializeComboBoxAndListBox();
//         }

//         private void InitializeComboBoxAndListBox()
//         {
//             ComboBox comboBox = new ComboBox
//             {
//                 Location = new System.Drawing.Point(10, 10),
//                 Width = 200
//             };

//             comboBox.Items.AddRange(new string[]
//             {
//                 "Київ",
//                 "Харків",
//                 "Одеса",
//                 "Дніпро",
//                 "Львів",
//                 "Запоріжжя"
//             });

//             ListBox listBox = new ListBox
//             {
//                 Location = new System.Drawing.Point(10, 50),
//                 Width = 200,
//                 Height = 100
//             };

//             listBox.Items.AddRange(new string[]
//             {
//                 "Київ",
//                 "Харків",
//                 "Одеса",
//                 "Дніпро",
//                 "Львів",
//                 "Запоріжжя"
//             });

//             this.Controls.Add(comboBox);
//             this.Controls.Add(listBox);
//         }
//     }
// }
