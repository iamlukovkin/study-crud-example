using System.ComponentModel;

namespace DesktopApplication;

partial class StudentsForm
{
    private IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    
    private void InitializeComponent()
        {
            this.Text = "Список студентов (CRUD)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 450);
            this.BackColor = Color.WhiteSmoke;

            // Настройки DataGridView
            dgvStudents = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 300,
                AutoGenerateColumns = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                RowHeadersVisible = false
            };

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Номер", DataPropertyName = "Number", Width = 80 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ФИО", DataPropertyName = "FullName", Width = 200 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Группа", DataPropertyName = "GroupNumber", Width = 100 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Год рождения", DataPropertyName = "BirthYear", Width = 120 });

            // Кнопки с улучшенным оформлением
            btnAdd = new Button
            {
                Text = "Добавить",
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                AutoSize = true
            };
            btnAdd.FlatAppearance.BorderSize = 0;

            btnEdit = new Button
            {
                Text = "Изменить",
                BackColor = Color.CornflowerBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                AutoSize = true
            };
            btnEdit.FlatAppearance.BorderSize = 0;

            btnDelete = new Button
            {
                Text = "Удалить",
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                AutoSize = true
            };
            btnDelete.FlatAppearance.BorderSize = 0;

            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            // Панель с кнопками
            FlowLayoutPanel buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.LeftToRight,
                Height = 60,
                Padding = new Padding(10),
                BackColor = Color.LightGray
            };

            buttonPanel.Controls.Add(btnAdd);
            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);

            this.Controls.Add(dgvStudents);
            this.Controls.Add(buttonPanel);
        }

    #endregion
}