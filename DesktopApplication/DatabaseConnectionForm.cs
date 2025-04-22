namespace DesktopApplication;
using Connector;

public partial class DatabaseConnectionForm : Form
{
    private readonly ConnectionFactory _connectionFactory;
    
    public DatabaseConnectionForm()
    {
        _connectionFactory = ConnectionFactory.GetInstance();
        InitializeComponent();
        FillTextFields();
    }

    private void FillTextFields()
    {
        txtHost.Text = _connectionFactory.Host;
        txtPort.Text = _connectionFactory.Port.ToString();
        txtDatabase.Text = _connectionFactory.Database;
        txtUsername.Text = _connectionFactory.Username;
        txtPassword.Text = _connectionFactory.Password;
    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
        try
        {
            _connectionFactory.Host = txtHost.Text;
            _connectionFactory.Port = int.Parse(txtPort.Text);
            _connectionFactory.Database = txtDatabase.Text;
            _connectionFactory.Username = txtUsername.Text;
            _connectionFactory.Password = txtPassword.Text;
            Context.CreateContext();
            var applicationForm = new SelectionEntitiesForm();
            applicationForm.Show();
            Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}