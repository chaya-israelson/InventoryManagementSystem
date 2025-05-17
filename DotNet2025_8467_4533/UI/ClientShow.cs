

namespace UI;

public partial class ClientShow : Form
{
    public ClientShow()
    {
        InitializeComponent();
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = false;
    }
    private void ShowClient_Click(object sender, EventArgs e)
    {


        panelClientDetails.Visible = false;
        panelShowClient.Visible = true;
        panelAllClient.Visible = false;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = false;

    }
    private void AllClients_Click(object sender, EventArgs e)
    {
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = true;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = false;
    }
    private void addClient_Click(object sender, EventArgs e)
    {
        panelAddOrUpdateClient.Visible = true;
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        addOrUpdate.Text = "הוספה";
        panelDeleteClient.Visible = false;
    }
    private void updetClient_Click(object sender, EventArgs e)
    {
        panelAddOrUpdateClient.Visible = true;
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        addId.Visible = false;
        insertAddId.Visible = false;
        addOrUpdate.Text = "עדכון";
        panelDeleteClient.Visible = false;
    }

    private void deleteClient_Click(object sender, EventArgs e)
    {
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = true;
    }
    private void showIdClient_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            panelClientDetails.Visible = true;
            panelShowClient.Visible = true;
            panelAllClient.Visible = false;
            panelAddOrUpdateClient.Visible = false;
            panelDeleteClient.Visible = false;
        }
    }


































    private void panelAddOrUpdateProduct_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panelAllProduct_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panelDeleteProduct_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panelProductDetails_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panelShowProduct_Paint(object sender, PaintEventArgs e)
    {
    }

    private void ShowProduct_Click(object sender, EventArgs e)
    {
    }
    private void dataGridViewAllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }


}
