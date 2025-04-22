using System.ComponentModel;

namespace DesktopApplication;

partial class StudentEditForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.Text = isNew ? "Добавить студента" : "Редактировать студента";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(500, 350); // Увеличиваем размер формы
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                BackColor = Color.WhiteSmoke,
            };
            this.Controls.Add(panel);

            Label lblTitle = new Label
            {
                Text = isNew ? "Добавить студента" : "Редактировать студента",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.MediumSlateBlue,
                AutoSize = true,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 10, 0, 10),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(lblTitle);

            Label lblName = new Label { Text = "ФИО", Font = new Font("Segoe UI", 10) };
            txtName = new TextBox
            {
                Text = student.FullName ?? "",
                Width = 350, 
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                Height = 40, 
                Margin = new Padding(0, 5, 0, 15),
            };

            Label lblGroup = new Label { Text = "Группа", Font = new Font("Segoe UI", 10) };
            txtGroup = new TextBox
            {
                Text = student.GroupNumber?.ToString() ?? "",
                Width = 350, 
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                Height = 40,
                Margin = new Padding(0, 5, 0, 15),
            };

            Label lblBirth = new Label { Text = "Год рождения", Font = new Font("Segoe UI", 10) };
            txtBirth = new TextBox
            {
                Text = student.BirthYear?.ToString() ?? "",
                Width = 350, 
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                Height = 40, 
                Margin = new Padding(0, 5, 0, 15),
            };

            btnSave = new Button
            {
                Text = "Сохранить",
                Width = 350,
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Height = 45, 
                Margin = new Padding(0, 5, 0, 0),
                Dock = DockStyle.Bottom,
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            panel.Controls.Add(lblName);
            panel.Controls.Add(txtName);
            panel.Controls.Add(lblGroup);
            panel.Controls.Add(txtGroup);
            panel.Controls.Add(lblBirth);
            panel.Controls.Add(txtBirth);
            panel.Controls.Add(btnSave);
        }

    #endregion
}