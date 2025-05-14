

namespace UI;

public partial class ManagerMenu : Form
{
    public ManagerMenu()
    {
        InitializeComponent();
    }

    private void clients_Click(object sender, EventArgs e)
    {
        Options options = new Options();
        this.Hide();
        options.FormClosed += options_FormClosed;
        options.Show();
        options.Text = "לקוחות";
    }

    private void options_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void products_Click(object sender, EventArgs e)
    {
        Options options = new Options();
        this.Hide();
        options.FormClosed += options_FormClosed;
        options.Show();
        options.Text = "מוצרים";
    }

    private void sales_Click(object sender, EventArgs e)
    {
        Options options = new Options();
        this.Hide();
        options.FormClosed += options_FormClosed;
        options.Show();
        options.Text = "מבצעים";


    }
}
