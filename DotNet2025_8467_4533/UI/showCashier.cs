using BlApi;

namespace UI;

public partial class showCashier : Form
{
    static readonly IBl s_bl = Factory.Get();
    bool isClient = false;
    public showCashier()
    {
        InitializeComponent();
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelStartOrder.Visible = true;
    }

    private void insertIdClient_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            panelStartOrder.Visible = false;

            panelFinishOrder.Visible = false;
            panelShowOrder.Visible = true;
            if (s_bl.client.Read(int.Parse(insertIdClient.Text)) != null)
                isClient = true;

        }
    }

    private void addProduct_Click(object sender, EventArgs e)
    {
        AddProduct addProduct = new AddProduct();
        this.Hide();
        addProduct.FormClosed += AddProduct_FormClosed; ;
        addProduct.Show();
    }

    private void AddProduct_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Show();
    }

    private void finishOrder_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = true;

    }

    private void newOrder_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = true;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;

    }
}
