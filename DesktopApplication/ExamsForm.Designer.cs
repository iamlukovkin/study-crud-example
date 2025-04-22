using System.ComponentModel;

namespace DesktopApplication;

partial class ExamsForm
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
        this.Text = "Список экзаменов";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new System.Drawing.Size(800, 400);

        dgvExams = new DataGridView
        {
            Dock = DockStyle.Fill,
            AutoGenerateColumns = false,
            ReadOnly = true,
            AllowUserToAddRows = false
        };

        dgvExams.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Студент",
            DataPropertyName = "StudentName",
            Width = 200
        });

        dgvExams.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Предмет",
            DataPropertyName = "SubjectName",
            Width = 200
        });

        dgvExams.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Дата экзамена",
            DataPropertyName = "DateOfExam",
            Width = 150
        });

        dgvExams.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Оценка",
            DataPropertyName = "Mark",
            Width = 100
        });

        this.Controls.Add(dgvExams);
    }

    #endregion
}