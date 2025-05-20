namespace UI;
public partial class ManagerMenu : Form
{
    public ManagerMenu()
    {
        InitializeComponent();
    }

    private void clients_Click(object sender, EventArgs e)
    {
       ClientShow options = new ClientShow();
        this.Hide();
        options.FormClosed += options_FormClosed;
        options.Show();
        options.Text = "מוצרים";
    }

    private void productShow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void products_Click(object sender, EventArgs e)
    {
        ProductShow productShow = new ProductShow();
        this.Hide();
        productShow.FormClosed += ProductShow_FormClosed;
        productShow.Show();
        /*ProductShow productShow = new ProductShow();
        this.Hide();
        productShow.FormClosed += productShow_FormClosed;
        productShow.Show();*/
    }

    private void ProductShow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void sales_Click(object sender, EventArgs e)
    {
        SaleShow saleShow = new SaleShow();
        this.Hide();
        saleShow.FormClosed += saleShow_FormClosed;
        saleShow.Show();


    }

    private void saleShow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }
}
