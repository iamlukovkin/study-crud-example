using Connector;
using Entities;

namespace DesktopApplication;

public partial class StudentEditForm : Form
{
    private TextBox txtName, txtGroup, txtBirth;
    private Button btnSave;

    private readonly Student student;
    private readonly bool isNew;

    public StudentEditForm(Student? existingStudent = null)
    {
        isNew = existingStudent == null;
        student = existingStudent ?? new Student();
        InitializeComponent();
    }
    
    private void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            student.FullName = txtName.Text;
            student.GroupNumber = int.TryParse(txtGroup.Text, out var g) ? g : null;
            student.BirthYear = decimal.TryParse(txtBirth.Text, out var b) ? b : null;

            var context = Context.GetInstance();

            if (isNew)
                context.Students.Add(student);

            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}