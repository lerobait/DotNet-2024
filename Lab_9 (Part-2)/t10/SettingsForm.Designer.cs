namespace Task_10
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBallCount;
        private System.Windows.Forms.NumericUpDown nudBallCount;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnRemoveColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений конструктором форм Windows

        private void InitializeComponent()
        {
            this.lblBallCount = new System.Windows.Forms.Label();
            this.nudBallCount = new System.Windows.Forms.NumericUpDown();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblColors = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnRemoveColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBallCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBallCount
            // 
            this.lblBallCount.AutoSize = true;
            this.lblBallCount.Location = new System.Drawing.Point(12, 15);
            this.lblBallCount.Name = "lblBallCount";
            this.lblBallCount.Size = new System.Drawing.Size(104, 17);
            this.lblBallCount.TabIndex = 0;
            this.lblBallCount.Text = "Кількість кульок:";
            // 
            // nudBallCount
            // 
            this.nudBallCount.Location = new System.Drawing.Point(180, 13);
            this.nudBallCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBallCount.Name = "nudBallCount";
            this.nudBallCount.Size = new System.Drawing.Size(120, 22);
            this.nudBallCount.TabIndex = 1;
            this.nudBallCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(12, 50);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(120, 17);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Діаметр кульки:";
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(180, 48);
            this.nudDiameter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDiameter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 22);
            this.nudDiameter.TabIndex = 3;
            this.nudDiameter.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 85);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(146, 17);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Базова швидкість:";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(180, 83);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 22);
            this.nudSpeed.TabIndex = 5;
            this.nudSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(12, 120);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(53, 17);
            this.lblColors.TabIndex = 6;
            this.lblColors.Text = "Кольори:";
            // 
            // lbColors
            // 
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 16;
            this.lbColors.Location = new System.Drawing.Point(15, 140);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(285, 100);
            this.lbColors.TabIndex = 7;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(15, 260);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(100, 30);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "Додати";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // btnRemoveColor
            // 
            this.btnRemoveColor.Location = new System.Drawing.Point(200, 260);
            this.btnRemoveColor.Name = "btnRemoveColor";
            this.btnRemoveColor.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveColor.TabIndex = 9;
            this.btnRemoveColor.Text = "Видалити";
            this.btnRemoveColor.UseVisualStyleBackColor = true;
            this.btnRemoveColor.Click += new System.EventHandler(this.btnRemoveColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Застосувати";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemoveColor);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.lbColors);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.nudBallCount);
            this.Controls.Add(this.lblBallCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Налаштування";
            ((System.ComponentModel.ISupportInitialize)(this.nudBallCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
