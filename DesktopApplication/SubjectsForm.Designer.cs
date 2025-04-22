using System.ComponentModel;

namespace DesktopApplication;

partial class SubjectsForm
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
        this.Text = "Список предметов";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new System.Drawing.Size(600, 400);

        dgvSubjects = new DataGridView
        {
            Dock = DockStyle.Fill,
            AutoGenerateColumns = false,
            ReadOnly = true,
            AllowUserToAddRows = false
        };

        // Define columns manually
        dgvSubjects.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Номер",
            DataPropertyName = "Number",
            Width = 80
        });
        dgvSubjects.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Название",
            DataPropertyName = "FullName",
            Width = 250
        });
        dgvSubjects.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Объем часов",
            DataPropertyName = "HoursVolume",
            Width = 120
        });

        this.Controls.Add(dgvSubjects);
    }

    #endregion
}