namespace Task_3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований конструктором форм Windows

        private void InitializeComponent()
        {
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.radioButtonRouteRegister = new System.Windows.Forms.RadioButton();
            this.radioButtonRoute = new System.Windows.Forms.RadioButton();
            this.radioButtonTransport = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 15);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(124, 17);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Режим відображення:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Формуляр",
            "Таблиця"});
            this.comboBoxMode.Location = new System.Drawing.Point(142, 12);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(150, 24);
            this.comboBoxMode.TabIndex = 1;
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.radioButtonRouteRegister);
            this.groupBoxTables.Controls.Add(this.radioButtonRoute);
            this.groupBoxTables.Controls.Add(this.radioButtonTransport);
            this.groupBoxTables.Location = new System.Drawing.Point(12, 50);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(280, 100);
            this.groupBoxTables.TabIndex = 2;
            this.groupBoxTables.TabStop = false;
            this.groupBoxTables.Text = "Таблиці";
            // 
            // radioButtonRouteRegister
            // 
            this.radioButtonRouteRegister.AutoSize = true;
            this.radioButtonRouteRegister.Location = new System.Drawing.Point(20, 70);
            this.radioButtonRouteRegister.Name = "radioButtonRouteRegister";
            this.radioButtonRouteRegister.Size = new System.Drawing.Size(136, 21);
            this.radioButtonRouteRegister.TabIndex = 2;
            this.radioButtonRouteRegister.TabStop = true;
            this.radioButtonRouteRegister.Text = "RouteRegister";
            this.radioButtonRouteRegister.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoute
            // 
            this.radioButtonRoute.AutoSize = true;
            this.radioButtonRoute.Location = new System.Drawing.Point(20, 45);
            this.radioButtonRoute.Name = "radioButtonRoute";
            this.radioButtonRoute.Size = new System.Drawing.Size(72, 21);
            this.radioButtonRoute.TabIndex = 1;
            this.radioButtonRoute.TabStop = true;
            this.radioButtonRoute.Text = "Route";
            this.radioButtonRoute.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransport
            // 
            this.radioButtonTransport.AutoSize = true;
            this.radioButtonTransport.Checked = true;
            this.radioButtonTransport.Location = new System.Drawing.Point(20, 20);
            this.radioButtonTransport.Name = "radioButtonTransport";
            this.radioButtonTransport.Size = new System.Drawing.Size(95, 21);
            this.radioButtonTransport.TabIndex = 0;
            this.radioButtonTransport.TabStop = true;
            this.radioButtonTransport.Text = "Transport";
            this.radioButtonTransport.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 170);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(760, 380);
            this.dataGridView.TabIndex = 3;
            // 
            // textBoxForm
            // 
            this.textBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))));
            this.textBoxForm.Location = new System.Drawing.Point(12, 170);
            this.textBoxForm.Multiline = true;
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxForm.Size = new System.Drawing.Size(760, 380);
            this.textBoxForm.TabIndex = 4;
            this.textBoxForm.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxTables);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.labelMode);
            this.Name = "MainForm";
            this.Text = "Task 3";
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonRouteRegister;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonTransport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxForm;
    }
}
