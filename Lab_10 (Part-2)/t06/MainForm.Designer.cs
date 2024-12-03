namespace Task_6
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
            comboBoxMode = new ComboBox();
            labelMode = new Label();
            groupBoxTables = new GroupBox();
            radioButtonRouteRegister = new RadioButton();
            radioButtonRoute = new RadioButton();
            radioButtonTransport = new RadioButton();
            dataGridView = new DataGridView();
            panelInputs = new Panel();
            buttonAction = new Button();
            groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMode
            // 
            comboBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "Додавання", "Редагування", "Видалення" });
            comboBoxMode.Location = new Point(80, 12);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(150, 28);
            comboBoxMode.TabIndex = 0;
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new Point(12, 15);
            labelMode.Name = "labelMode";
            labelMode.Size = new Size(59, 20);
            labelMode.TabIndex = 1;
            labelMode.Text = "Режим:";
            // 
            // groupBoxTables
            // 
            groupBoxTables.Controls.Add(radioButtonRouteRegister);
            groupBoxTables.Controls.Add(radioButtonRoute);
            groupBoxTables.Controls.Add(radioButtonTransport);
            groupBoxTables.Location = new Point(15, 50);
            groupBoxTables.Name = "groupBoxTables";
            groupBoxTables.Size = new Size(215, 100);
            groupBoxTables.TabIndex = 2;
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
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 501);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.Size = new Size(760, 329);
            dataGridView.TabIndex = 3;
            // 
            // panelInputs
            // 
            panelInputs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInputs.Location = new Point(15, 156);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(760, 291);
            panelInputs.TabIndex = 4;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(15, 453);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(117, 32);
            buttonAction.TabIndex = 5;
            buttonAction.Text = "Додати";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click_1;
            // 
            // MainForm
            // 
            ClientSize = new Size(784, 842);
            Controls.Add(buttonAction);
            Controls.Add(panelInputs);
            Controls.Add(dataGridView);
            Controls.Add(groupBoxTables);
            Controls.Add(labelMode);
            Controls.Add(comboBoxMode);
            Name = "MainForm";
            Text = "Task 6";
            groupBoxTables.ResumeLayout(false);
            groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonRouteRegister;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonTransport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button buttonAction;
    }
}
