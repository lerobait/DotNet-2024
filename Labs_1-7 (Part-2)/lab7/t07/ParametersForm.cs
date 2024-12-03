// using System;
// using System.Drawing;
// using System.IO;
// using System.Windows.Forms;

// namespace DotNET_Labs__2
// {
//     public partial class ParametersForm : Form
//     {
//         private Button btnChangeColor;
//         private Button btnChangeFont;
//         private Button btnSaveConfig;
//         private Button btnLoadConfig;
//         private ColorDialog colorDialog;
//         private FontDialog fontDialog;
//         private Form mainForm;
//         private SaveFileDialog saveFileDialog;
//         private OpenFileDialog openFileDialog;

//         public ParametersForm(Form mainForm)
//         {
//             this.mainForm = mainForm;

//             btnChangeColor = new Button { Text = "Змінити колір", Location = new Point(20, 20), Width = 200 };
//             btnChangeFont = new Button { Text = "Змінити шрифт", Location = new Point(20, 60), Width = 200 };
//             btnSaveConfig = new Button { Text = "Зберегти конфігурацію", Location = new Point(20, 100), Width = 200 };
//             btnLoadConfig = new Button { Text = "Завантажити конфігурацію", Location = new Point(20, 140), Width = 200 };

//             colorDialog = new ColorDialog();
//             fontDialog = new FontDialog();

//             saveFileDialog = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" };
//             openFileDialog = new OpenFileDialog { Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*" };

//             btnChangeColor.Click += BtnChangeColor_Click;
//             btnChangeFont.Click += BtnChangeFont_Click;
//             btnSaveConfig.Click += BtnSaveConfig_Click;
//             btnLoadConfig.Click += BtnLoadConfig_Click;

//             Controls.Add(btnChangeColor);
//             Controls.Add(btnChangeFont);
//             Controls.Add(btnSaveConfig);
//             Controls.Add(btnLoadConfig);
//         }

//         private void BtnChangeColor_Click(object sender, EventArgs e)
//         {
//             if (colorDialog.ShowDialog() == DialogResult.OK)
//             {
//                 mainForm.BackColor = colorDialog.Color;
//             }
//         }

//         private void BtnChangeFont_Click(object sender, EventArgs e)
//         {
//             if (fontDialog.ShowDialog() == DialogResult.OK)
//             {
//                 mainForm.Font = fontDialog.Font;
//             }
//         }

//         private void BtnSaveConfig_Click(object sender, EventArgs e)
//         {
//             if (saveFileDialog.ShowDialog() == DialogResult.OK)
//             {
//                 try
//                 {
//                     using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
//                     {
//                         writer.WriteLine(mainForm.BackColor.ToArgb());
//                         writer.WriteLine(mainForm.Font.Name);
//                         writer.WriteLine(mainForm.Font.Size);
//                     }
//                 }
//                 catch (Exception ex)
//                 {
//                     MessageBox.Show($"Помилка збереження конфігурації: {ex.Message}");
//                 }
//             }
//         }

//         private void BtnLoadConfig_Click(object sender, EventArgs e)
//         {
//             if (openFileDialog.ShowDialog() == DialogResult.OK)
//             {
//                 try
//                 {
//                     using (StreamReader reader = new StreamReader(openFileDialog.FileName))
//                     {
//                         int colorArgb = int.Parse(reader.ReadLine());
//                         mainForm.BackColor = Color.FromArgb(colorArgb);

//                         string fontName = reader.ReadLine();
//                         float fontSize = float.Parse(reader.ReadLine());
//                         mainForm.Font = new Font(fontName, fontSize);
//                     }
//                 }
//                 catch (Exception ex)
//                 {
//                     MessageBox.Show($"Помилка завантаження конфігурації: {ex.Message}");
//                 }
//             }
//         }
//     }
// }
