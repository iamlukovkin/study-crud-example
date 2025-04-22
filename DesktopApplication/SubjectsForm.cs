using Connector;

namespace DesktopApplication;

public partial class SubjectsForm : Form
{
    private DataGridView dgvSubjects;
    
    public SubjectsForm()
    {
        InitializeComponent();
        LoadSubjects();
    }
    
    private void LoadSubjects()
    {
        try
        {
            var subjects = Context.GetInstance().Subjects.ToList();
            dgvSubjects.DataSource = subjects;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при загрузке предметов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}