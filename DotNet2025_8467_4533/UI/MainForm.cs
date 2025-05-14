namespace UI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void management_Click(object sender, EventArgs e)
    {
        ManagerMenu managerMenu = new ManagerMenu();
        this.Hide();
        managerMenu.FormClosed += ManagerMenu_FormClosed;
        managerMenu.Show();
    }

    private void ManagerMenu_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void seller_Click(object sender, EventArgs e)
    {

    }
}
