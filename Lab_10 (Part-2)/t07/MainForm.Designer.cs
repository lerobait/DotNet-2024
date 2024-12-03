namespace Task_7
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

        private void InitializeComponent()
        {
            groupBoxTables = new GroupBox();
            radioButtonRouteRegister = new RadioButton();
            radioButtonRoute = new RadioButton();
            radioButtonTransport = new RadioButton();
            comboBoxMode = new ComboBox();
            labelMode = new Label();
            comboBoxStatistics = new ComboBox();
            labelStatistics = new Label();
            buttonCalculate = new Button();
            labelResult = new Label();
            dataGridView = new DataGridView();
            groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTables
            // 
            groupBoxTables.Controls.Add(radioButtonRouteRegister);
            groupBoxTables.Controls.Add(radioButtonRoute);
            groupBoxTables.Controls.Add(radioButtonTransport);
            groupBoxTables.Location = new Point(12, 12);
            groupBoxTables.Name = "groupBoxTables";
            groupBoxTables.Size = new Size(200, 100);
            groupBoxTables.TabIndex = 0;
            groupBoxTables.TabStop = false;
            groupBoxTables.Text = "Таблиці";
            // 
            // radioButtonRouteRegister
            // 
            radioButtonRouteRegister.AutoSize = true;
            radioButtonRouteRegister.Location = new Point(7, 68);
            radioButtonRouteRegister.Name = "radioButtonRouteRegister";
            radioButtonRouteRegister.Size = new Size(123, 24);
            radioButtonRouteRegister.TabIndex = 2;
            radioButtonRouteRegister.TabStop = true;
            radioButtonRouteRegister.Text = "RouteRegister";
            radioButtonRouteRegister.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoute
            // 
            radioButtonRoute.AutoSize = true;
            radioButtonRoute.Location = new Point(7, 44);
            radioButtonRoute.Name = "radioButtonRoute";
            radioButtonRoute.Size = new Size(69, 24);
            radioButtonRoute.TabIndex = 1;
            radioButtonRoute.TabStop = true;
            radioButtonRoute.Text = "Route";
            radioButtonRoute.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransport
            // 
            radioButtonTransport.AutoSize = true;
            radioButtonTransport.Checked = true;
            radioButtonTransport.Location = new Point(7, 20);
            radioButtonTransport.Name = "radioButtonTransport";
            radioButtonTransport.Size = new Size(92, 24);
            radioButtonTransport.TabIndex = 0;
            radioButtonTransport.TabStop = true;
            radioButtonTransport.Text = "Transport";
            radioButtonTransport.UseVisualStyleBackColor = true;
            // 
            // comboBoxMode
            // 
            comboBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "Перегляд даних", "Статистика" });
            comboBoxMode.Location = new Point(320, 25);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(150, 28);
            comboBoxMode.TabIndex = 1;
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new Point(255, 28);
            labelMode.Name = "labelMode";
            labelMode.Size = new Size(59, 20);
            labelMode.TabIndex = 2;
            labelMode.Text = "Режим:";
            // 
            // comboBoxStatistics
            // 
            comboBoxStatistics.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatistics.FormattingEnabled = true;
            comboBoxStatistics.Location = new Point(320, 55);
            comboBoxStatistics.Name = "comboBoxStatistics";
            comboBoxStatistics.Size = new Size(291, 28);
            comboBoxStatistics.TabIndex = 3;
            // 
            // labelStatistics
            // 
            labelStatistics.AutoSize = true;
            labelStatistics.Location = new Point(227, 58);
            labelStatistics.Name = "labelStatistics";
            labelStatistics.Size = new Size(87, 20);
            labelStatistics.TabIndex = 4;
            labelStatistics.Text = "Статистика:";
            labelStatistics.Click += labelStatistics_Click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(644, 53);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(109, 30);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Розрахувати";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Location = new Point(12, 115);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(771, 23);
            labelResult.TabIndex = 6;
            labelResult.Text = "Результат:";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 141);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.Size = new Size(771, 307);
            dataGridView.TabIndex = 7;
            // 
            // MainForm
            // 
            ClientSize = new Size(795, 460);
            Controls.Add(dataGridView);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(labelStatistics);
            Controls.Add(comboBoxStatistics);
            Controls.Add(labelMode);
            Controls.Add(comboBoxMode);
            Controls.Add(groupBoxTables);
            Name = "MainForm";
            Text = "Task 7";
            groupBoxTables.ResumeLayout(false);
            groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonRouteRegister;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonTransport;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxStatistics;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
