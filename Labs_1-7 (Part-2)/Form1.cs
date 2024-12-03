using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DotNET_Labs__2
{
    public partial class Form1 : Form
    {
        private RichTextBox txtEditor;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu, fontMenu, helpMenu;
        private ToolStripMenuItem newFileMenuItem, openFileMenuItem, saveFileMenuItem, exitMenuItem;
        private ToolStripMenuItem fontSizeMenuItem;
        private ToolStripMenuItem aboutMenuItem;

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;

        public Form1()
        {
            InitializeComponentCustom();
        }

        private void InitializeComponentCustom()
        {
            this.txtEditor = new RichTextBox();
            this.menuStrip = new MenuStrip();
            this.fileMenu = new ToolStripMenuItem("Файл");
            this.fontMenu = new ToolStripMenuItem("Шрифт");
            this.helpMenu = new ToolStripMenuItem("Допомога");

            this.newFileMenuItem = new ToolStripMenuItem("Новий", null, NewFile_Click);
            this.openFileMenuItem = new ToolStripMenuItem("Відкрити", null, OpenFile_Click);
            this.saveFileMenuItem = new ToolStripMenuItem("Зберегти", null, SaveFile_Click);
            this.exitMenuItem = new ToolStripMenuItem("Вийти", null, ExitFile_Click);

            this.fontSizeMenuItem = new ToolStripMenuItem("Розмір шрифта", null, FontSizeMenuItem_Click);

            this.aboutMenuItem = new ToolStripMenuItem("Про програму", null, AboutMenuItem_Click);

            this.fileMenu.DropDownItems.AddRange(new ToolStripMenuItem[] {
                this.newFileMenuItem,
                this.openFileMenuItem,
                this.saveFileMenuItem,
                this.exitMenuItem
            });

            this.fontMenu.DropDownItems.Add(this.fontSizeMenuItem);

            this.helpMenu.DropDownItems.Add(this.aboutMenuItem);

            this.menuStrip.Items.AddRange(new ToolStripMenuItem[] {
                this.fileMenu,
                this.fontMenu,
                this.helpMenu
            });

            this.txtEditor.Multiline = true;
            this.txtEditor.Dock = DockStyle.Fill;
            this.txtEditor.ScrollBars = RichTextBoxScrollBars.Both;

            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
            this.fontDialog = new FontDialog();

            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "Текстовий редактор";
            this.WindowState = FormWindowState.Maximized;

            this.txtEditor.SelectionChanged += TxtEditor_SelectionChanged;
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
            this.Text = "Нове файл - Текстовий редактор";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                    this.Text = $"{Path.GetFileName(openFileDialog.FileName)} - Текстовий редактор";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при відкритті файлу: {ex.Message}");
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                    this.Text = $"{Path.GetFileName(saveFileDialog.FileName)} - Текстовий редактор";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}");
                }
            }
        }

        private void FontSizeMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void TxtEditor_SelectionChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtEditor.SelectionStart;
            int line = txtEditor.GetLineFromCharIndex(cursorPosition);
            Point point = txtEditor.GetPositionFromCharIndex(cursorPosition);
            int column = point.X / txtEditor.Font.Height;

            this.Text = $"Текстовий редактор - Лінія: {line + 1}, Стовпець: {column + 1}";
        }

        private void ExitFile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовий редактор\nРозроблено: Artem Nikulin", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}