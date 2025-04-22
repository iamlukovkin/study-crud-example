using System.ComponentModel;

namespace DesktopApplication;

partial class DatabaseConnectionForm
{
    private IContainer components = null;
    
    private System.Windows.Forms.Label lblHost;
    private System.Windows.Forms.TextBox txtHost;
    private System.Windows.Forms.Label lblPort;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.Label lblDatabase;
    private System.Windows.Forms.TextBox txtDatabase;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnConnect;

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
        this.components = new Container();
        
        TableLayoutPanel tableLayout = new TableLayoutPanel
        {
            ColumnCount = 2,
            RowCount = 6,
            Dock = DockStyle.Fill,
            AutoSize = true,
            Padding = new Padding(20),
            CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
        };
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        
        lblHost = new Label() { Text = "Host:", Anchor = AnchorStyles.Right, AutoSize = true, Margin = new Padding(5) };
        txtHost = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(5) };
        
        lblPort = new Label() { Text = "Port:", Anchor = AnchorStyles.Right, AutoSize = true, Margin = new Padding(5) };
        txtPort = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(5) };

        lblDatabase = new Label() { Text = "Database:", Anchor = AnchorStyles.Right, AutoSize = true, Margin = new Padding(5) };
        txtDatabase = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(5) };

        lblUsername = new Label() { Text = "Username:", Anchor = AnchorStyles.Right, AutoSize = true, Margin = new Padding(5) };
        txtUsername = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(5) };

        lblPassword = new Label() { Text = "Password:", Anchor = AnchorStyles.Right, AutoSize = true, Margin = new Padding(5) };
        txtPassword = new TextBox() { Anchor = AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(5), PasswordChar = '*' };

        btnConnect = new Button()
        {
            Text = "Connect",
            Anchor = AnchorStyles.None,
            Margin = new Padding(10),
            AutoSize = true
        };
        btnConnect.Click += buttonConnect_Click;
        
        tableLayout.Controls.Add(lblHost, 0, 0);
        tableLayout.Controls.Add(txtHost, 1, 0);

        tableLayout.Controls.Add(lblPort, 0, 1);
        tableLayout.Controls.Add(txtPort, 1, 1);

        tableLayout.Controls.Add(lblDatabase, 0, 2);
        tableLayout.Controls.Add(txtDatabase, 1, 2);

        tableLayout.Controls.Add(lblUsername, 0, 3);
        tableLayout.Controls.Add(txtUsername, 1, 3);

        tableLayout.Controls.Add(lblPassword, 0, 4);
        tableLayout.Controls.Add(txtPassword, 1, 4);

        // Add button centered in last row spanning 2 columns
        tableLayout.Controls.Add(btnConnect, 0, 5);
        tableLayout.SetColumnSpan(btnConnect, 2);
        
        this.Text = "Database Connection";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.Controls.Add(tableLayout);
    }
    #endregion
}