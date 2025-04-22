using System.ComponentModel;

namespace DesktopApplication;

partial class SelectionEntitiesForm
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
        
        LinkLabel linkStudents = new LinkLabel()
        {
            Text = "Студенты",
            AutoSize = true,
            Margin = new Padding(10)
        };
        linkStudents.Click += (s, e) =>
        {
            var form = new StudentsForm();
            form.ShowDialog();
        };
        
        LinkLabel linkSubjects = new LinkLabel()
        {
            Text = "Предметы",
            AutoSize = true,
            Margin = new Padding(10)
        };
        linkSubjects.Click += (s, e) =>
        {
            var form = new SubjectsForm();
            form.ShowDialog();
        };


        LinkLabel linkExams = new LinkLabel()
        {
            Text = "Экзамены",
            AutoSize = true,
            Margin = new Padding(10)
        };
        linkExams.Click += (s, e) =>
        {
            var form = new ExamsForm();
            form.ShowDialog();
        };
        
        FlowLayoutPanel panel = new FlowLayoutPanel()
        {
            FlowDirection = FlowDirection.TopDown,
            Dock = DockStyle.Fill,
            Padding = new Padding(20),
            AutoSize = true
        };

        panel.Controls.Add(linkStudents);
        panel.Controls.Add(linkSubjects);
        panel.Controls.Add(linkExams);
        
        this.Controls.Add(panel);
        this.Text = "Главное меню";
        this.AutoSize = true;
        this.StartPosition = FormStartPosition.CenterScreen;

    }

    #endregion
}