using Connector;

namespace DesktopApplication;

public partial class ExamsForm : Form
{
    private DataGridView dgvExams;
    
    public ExamsForm()
    {
        InitializeComponent();
        LoadExams();
    }
    
    private void LoadExams()
    {
        try
        {
            var context = Context.GetInstance();

            var exams = context.Exams
                .Select(e => new
                {
                    StudentName = e.Student.FullName,
                    SubjectName = e.Subject.FullName,
                    DateOfExam = e.DateOfExam.ToShortDateString(),
                    Mark = e.Mark
                })
                .ToList();

            dgvExams.DataSource = exams;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при загрузке экзаменов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}