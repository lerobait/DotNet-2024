namespace Task_4
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
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.radioButtonRouteRegister = new System.Windows.Forms.RadioButton();
            this.radioButtonRoute = new System.Windows.Forms.RadioButton();
            this.radioButtonTransport = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.radioButtonRouteRegister);
            this.groupBoxTables.Controls.Add(this.radioButtonRoute);
            this.groupBoxTables.Controls.Add(this.radioButtonTransport);
            this.groupBoxTables.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTables.TabIndex = 0;
            this.groupBoxTables.TabStop = false;
            this.groupBoxTables.Text = "Таблиці";
            // 
            // radioButtonRouteRegister
            // 
            this.radioButtonRouteRegister.AutoSize = true;
            this.radioButtonRouteRegister.Location = new System.Drawing.Point(7, 68);
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
            this.radioButtonRoute.Location = new System.Drawing.Point(7, 44);
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
            this.radioButtonTransport.Location = new System.Drawing.Point(7, 20);
            this.radioButtonTransport.Name = "radioButtonTransport";
            this.radioButtonTransport.Size = new System.Drawing.Size(95, 21);
            this.radioButtonTransport.TabIndex = 0;
            this.radioButtonTransport.TabStop = true;
            this.radioButtonTransport.Text = "Transport";
            this.radioButtonTransport.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(760, 431);
            this.dataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxTables);
            this.Name = "MainForm";
            this.Text = "Task 4";
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonRouteRegister;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonTransport;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
