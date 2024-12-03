namespace Task_5
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
            dataGridView = new DataGridView();
            panelFilters = new Panel();
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
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 162);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 24;
            dataGridView.Size = new Size(770, 436);
            dataGridView.TabIndex = 1;
            // 
            // panelFilters
            // 
            panelFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFilters.Location = new Point(12, 118);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(770, 25);
            panelFilters.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(794, 609);
            Controls.Add(panelFilters);
            Controls.Add(dataGridView);
            Controls.Add(groupBoxTables);
            Name = "MainForm";
            Text = "Task 5";
            groupBoxTables.ResumeLayout(false);
            groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.RadioButton radioButtonRouteRegister;
        private System.Windows.Forms.RadioButton radioButtonRoute;
        private System.Windows.Forms.RadioButton radioButtonTransport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelFilters;
    }
}
