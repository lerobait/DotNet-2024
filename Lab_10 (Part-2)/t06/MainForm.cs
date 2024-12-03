using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task_6.Models;

namespace Task_6
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

            // ϳ������ �� ��䳿
            comboBoxMode.SelectedIndexChanged += ComboBoxMode_SelectedIndexChanged; // ���� ������
            radioButtonTransport.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRoute.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRouteRegister.CheckedChanged += RadioButton_CheckedChanged;
            buttonAction.Click += ButtonAction_Click; // ������ ��
            dataGridView.SelectionChanged += DataGridView_SelectionChanged; // ���� �����

            comboBoxMode.SelectedIndex = 0; // ���� �� �������������
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData(); // ����������� ���
            UpdateView(); // ������� ������
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
                MessageBox.Show($"������� ��� ����������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateView()
        {
            ClearInputFields(); // �������� ����

            if (radioButtonTransport.Checked)
            {
                dataGridView.DataSource = transports; // ³��������� ����������
                CreateInputFields(typeof(Transport)); // ���� �����
            }
            else if (radioButtonRoute.Checked)
            {
                dataGridView.DataSource = routes; // ³��������� ��������
                CreateInputFields(typeof(Route));
            }
            else if (radioButtonRouteRegister.Checked)
            {
                dataGridView.DataSource = routeRegisters; // ³��������� ������
                CreateInputFields(typeof(RouteRegister));
            }

            UpdateButtonText(); // ������� ������
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ���� ����� �������
        }

        private void CreateInputFields(Type type)
        {
            panelInputs.Controls.Clear();
            int x = 0; // ������� X
            int y = 0; // ������� Y
            int spacing = 10; // ³�����

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Label lbl = new Label
                {
                    Text = prop.Name,
                    Location = new System.Drawing.Point(x, y), // ������������
                    Width = 100
                };
                panelInputs.Controls.Add(lbl); // ������ ����

                Control inputControl;

                if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(decimal) || prop.PropertyType == typeof(string))
                {
                    TextBox textBox = new TextBox
                    {
                        Name = "input_" + prop.Name,
                        Location = new System.Drawing.Point(x + 110, y), // ������������
                        Width = 150
                    };

                    // ���� �� ���� ID � ����� - "���������", ���������� �������, ������ ������ ���� ����� ��� �������
                    if (prop.Name.EndsWith("ID") && comboBoxMode.SelectedItem.ToString() != "���������")
                    {
                        textBox.ReadOnly = true;
                    }

                    panelInputs.Controls.Add(textBox);
                    inputControl = textBox;
                }
                else if (prop.PropertyType == typeof(TimeSpan))
                {
                    DateTimePicker timePicker = new DateTimePicker
                    {
                        Name = "input_" + prop.Name,
                        Location = new System.Drawing.Point(x + 110, y), // ������������
                        Width = 150,
                        Format = DateTimePickerFormat.Time, // ������ ����
                        ShowUpDown = true // �����
                    };
                    panelInputs.Controls.Add(timePicker); // ������ ���� ����
                    inputControl = timePicker;
                }
                else
                {
                    continue; // ���������� �������� ���
                }

                y += inputControl.Height + spacing; // �������� Y
            }
        }

        private void UpdateButtonText()
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // �������� �����
            buttonAction.Text = mode;
        }

        private void ComboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonText();
            ClearInputFields();
            UpdateView();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // �������� �����

            try
            {
                if (mode == "���������")
                {
                    AddRecord(); // ������ �����
                }
                else if (mode == "�����������")
                {
                    EditRecord(); // ���������� �����
                }
                else if (mode == "���������")
                {
                    DeleteRecord(); // �������� �����
                }

                LoadData();
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRecord()
        {
            if (radioButtonTransport.Checked)
            {
                Transport transport = new Transport(); // ����� ���������
                FillObjectFromInputs(transport); // ��������� ���
                db.AddTransport(transport);
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = new Route(); // ����� �������
                FillObjectFromInputs(route);
                db.AddRoute(route);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = new RouteRegister(); // ����� �����
                FillObjectFromInputs(routeRegister);
                db.AddRouteRegister(routeRegister);
            }
        }

        private void EditRecord()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ ����� ��� �����������.");
                return;
            }

            if (radioButtonTransport.Checked)
            {
                Transport transport = (Transport)dataGridView.SelectedRows[0].DataBoundItem; // �������� ���������
                FillObjectFromInputs(transport); // ��������� ���
                db.UpdateTransport(transport);
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = (Route)dataGridView.SelectedRows[0].DataBoundItem; // �������� �������
                FillObjectFromInputs(route);
                db.UpdateRoute(route);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = (RouteRegister)dataGridView.SelectedRows[0].DataBoundItem; // �������� �����
                FillObjectFromInputs(routeRegister);
                db.UpdateRouteRegister(routeRegister);
            }
        }

        private void DeleteRecord()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("������ ����� ��� ���������."); // �����������
                return;
            }

            if (radioButtonTransport.Checked)
            {
                Transport transport = (Transport)dataGridView.SelectedRows[0].DataBoundItem; // �������� ���������
                db.DeleteTransport(transport.TransportID); // �������� � ����
            }
            else if (radioButtonRoute.Checked)
            {
                Route route = (Route)dataGridView.SelectedRows[0].DataBoundItem; // �������� �������
                db.DeleteRoute(route.RouteID);
            }
            else if (radioButtonRouteRegister.Checked)
            {
                RouteRegister routeRegister = (RouteRegister)dataGridView.SelectedRows[0].DataBoundItem; // �������� �����
                db.DeleteRouteRegister(routeRegister.RouteRegisterID);
            }
        }

        private void FillObjectFromInputs<T>(T obj)
        {
            var type = typeof(T); // ��� ��'����
            var properties = type.GetProperties(); // ����������

            foreach (var prop in properties)
            {
                var control = panelInputs.Controls["input_" + prop.Name]; // �������� �����

                if (control == null)
                    continue; // ����������

                if (control is TextBox textBox)
                {
                    string value = textBox.Text; // �������� �����

                    if (prop.PropertyType == typeof(int))
                    {
                        if (int.TryParse(value, out int intValue))
                        {
                            prop.SetValue(obj, intValue); // ���������� int
                        }
                        else
                        {
                            throw new Exception($"������� ������ ��� {prop.Name}. ��������� ���� �����.");
                        }
                    }
                    else if (prop.PropertyType == typeof(decimal))
                    {
                        if (decimal.TryParse(value, out decimal decimalValue))
                        {
                            prop.SetValue(obj, decimalValue); // ���������� decimal
                        }
                        else
                        {
                            throw new Exception($"������� ������ ��� {prop.Name}. ��������� �����.");
                        }
                    }
                    else if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(obj, value); // ���������� string
                    }
                }
                else if (control is DateTimePicker timePicker)
                {
                    if (prop.PropertyType == typeof(TimeSpan))
                    {
                        prop.SetValue(obj, timePicker.Value.TimeOfDay); // ���������� TimeSpan
                    }
                }
            }
        }

        private void ClearInputFields()
        {
            foreach (Control control in panelInputs.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // �������� �������� ����
                }
                else if (control is DateTimePicker timePicker)
                {
                    timePicker.Value = DateTime.Now; // ������� ���
                }
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string mode = comboBoxMode.SelectedItem.ToString(); // �������� �����
            if ((mode == "�����������" || mode == "���������") && dataGridView.SelectedRows.Count > 0)
            {
                LoadSelectedRecordIntoInputs(); // ����������� �����
            }
        }

        private void LoadSelectedRecordIntoInputs()
        {
            object selectedItem = dataGridView.SelectedRows[0].DataBoundItem; // �������� �����
            var type = selectedItem.GetType(); // ��� ������
            var properties = type.GetProperties(); // ����������

            foreach (var prop in properties)
            {
                var control = panelInputs.Controls["input_" + prop.Name]; // �������� �����

                if (control == null)
                    continue; // ����������

                var value = prop.GetValue(selectedItem); // �������� ����������

                if (control is TextBox textBox)
                {
                    textBox.Text = value?.ToString(); // ���������� �����
                }
                else if (control is DateTimePicker timePicker)
                {
                    if (value is TimeSpan timeSpan)
                    {
                        timePicker.Value = DateTime.Today.Add(timeSpan); // ���������� ���
                    }
                }
            }
        }

        private void buttonAction_Click_1(object sender, EventArgs e)
        {

        }
    }
}
