using System; 
using System.Collections.Generic;
using System.Windows.Forms;
using Task_3.Models; 

namespace Task_3
{
    public partial class MainForm : Form
    {
        private Database db; 
        private List<Transport> transports; 
        private List<Route> routes; 
        private List<RouteRegister> routeRegisters; 

        public MainForm()
        {
            InitializeComponent(); 
            db = new Database(); 

            // ��������� ��������
            if (comboBoxMode.Items.Count == 0)
            {
                comboBoxMode.Items.Add("��������"); 
                comboBoxMode.Items.Add("�������"); 
            }

            comboBoxMode.SelectedIndex = 0; // ���� �� �������������

            // ϳ������ �� ��䳿
            comboBoxMode.SelectedIndexChanged += comboBoxMode_SelectedIndexChanged; // ���� ������
            radioButtonTransport.CheckedChanged += radioButton_CheckedChanged; // ���������
            radioButtonRoute.CheckedChanged += radioButton_CheckedChanged; // �������
            radioButtonRouteRegister.CheckedChanged += radioButton_CheckedChanged; // �����
            this.Load += MainForm_Load; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
            UpdateView(); 
        }

        private void LoadData()
        {
            try
            {
                transports = db.GetTransports(); // �������� ����������
                routes = db.GetRoutes(); // �������� ��������
                routeRegisters = db.GetRouteRegisters(); // �������� ������
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� ����������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error); // ����������� ��� �������
            }
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView(); // ������� ������
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView(); // ������� ������
        }

        private void UpdateView()
        {
            if (comboBoxMode.SelectedItem == null)
                return; // ����� ���� ����� �� �������

            string mode = comboBoxMode.SelectedItem.ToString(); // �������� �����

            if (mode == "�������")
            {
                textBoxForm.Visible = false; // ������� ��������
                dataGridView.Visible = true; // �������� �������

                if (radioButtonTransport.Checked)
                {
                    dataGridView.DataSource = transports; // �������� ����������
                }
                else if (radioButtonRoute.Checked)
                {
                    dataGridView.DataSource = routes; // �������� ��������
                }
                else if (radioButtonRouteRegister.Checked)
                {
                    dataGridView.DataSource = routeRegisters; // �������� ������
                }
            }
            else if (mode == "��������")
            {
                dataGridView.Visible = false; 
                textBoxForm.Visible = true; 
                textBoxForm.Clear(); // �������� ��������

                if (radioButtonTransport.Checked)
                {
                    foreach (var transport in transports)
                    {
                        textBoxForm.AppendText(transport.ToForm() + "\n\n"); // ������ ���������
                    }
                }
                else if (radioButtonRoute.Checked)
                {
                    foreach (var route in routes)
                    {
                        textBoxForm.AppendText(route.ToForm() + "\n\n"); // ������ �������
                    }
                }
                else if (radioButtonRouteRegister.Checked)
                {
                    foreach (var rr in routeRegisters)
                    {
                        textBoxForm.AppendText(rr.ToForm() + "\n\n"); // ������ �����
                    }
                }
            }
        }
    }
}
