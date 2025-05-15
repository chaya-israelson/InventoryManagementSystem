namespace UI;
public partial class ManagerMenu : Form
{
    public ManagerMenu()
    {
        InitializeComponent();
    }

    private void clients_Click(object sender, EventArgs e)
    {
       
    }

    private void options_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void products_Click(object sender, EventArgs e)
    {
        ProductShow options = new ProductShow();
        this.Hide();
        options.FormClosed += options_FormClosed;
        options.Show();
        options.Text = "מוצרים";
    }

    private void sales_Click(object sender, EventArgs e)
    {
      


    }
}
