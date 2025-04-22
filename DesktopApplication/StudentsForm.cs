using Connector;
using Entities;

namespace DesktopApplication;

public partial class StudentsForm : Form
{
    private DataGridView dgvStudents;
    private Button btnAdd, btnEdit, btnDelete;
    
    public StudentsForm()
    {
        InitializeComponent();
        LoadStudents();
    }
    
    private void LoadStudents()
    {
        var students = Context.GetInstance().Students.ToList();
        dgvStudents.DataSource = students;
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        var form = new StudentEditForm();
        if (form.ShowDialog() == DialogResult.OK)
        {
            LoadStudents();
        }
    }

    private void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvStudents.CurrentRow?.DataBoundItem is Student selected)
        {
            var form = new StudentEditForm(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStudents();
            }
        }
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        if (dgvStudents.CurrentRow?.DataBoundItem is Student selected)
        {
            var confirm = MessageBox.Show($"Удалить студента {selected.FullName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var context = Context.GetInstance();
                context.Students.Remove(selected);
                context.SaveChanges();
                LoadStudents();
            }
        }
    }
}