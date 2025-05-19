using BlApi;
using BO;

namespace UI;
public partial class ClientShow : Form
{
    static readonly IBl s_bl = Factory.Get();

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
        String num = showIdClient.Text;
        try
        {
            Client client = s_bl.client.Read(int.Parse(num));
            if (client != null)
            {
                label3.Text = client.Name;
                label4.Text = client.Addres;
                label6.Text = client.Phon;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("ERROR");
        }
    }
    private void AllClients_Click(object sender, EventArgs e)
    {
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = true;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = false;
        dataGridViewAllClient.DataSource = s_bl.client.ReadAll();

    }
    private void addClient_Click(object sender, EventArgs e)
    {
        panelAddOrUpdateClient.Visible = true;
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        addOrUpdate.Text = "הוספה";
        panelDeleteClient.Visible = false;
        Client client = new Client(int.Parse(insertAddId.Text), insertAddNameClient.Text, insertAddAddres.Text, insertAddPhon.Text);
        s_bl.client.Create(client);
    }
    private void updetClient_Click(object sender, EventArgs e)
    {
        panelAddOrUpdateClient.Visible = true;
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
       // addId.Visible = false;
       // insertAddId.Visible = false;
        addOrUpdate.Text = "עדכון";
        panelDeleteClient.Visible = false;
        Client client = new Client(int.Parse(insertAddId.Text), insertAddNameClient.Text, insertAddAddres.Text, insertAddPhon.Text);
        s_bl.client.Update(client);
    }

    private void deleteClient_Click(object sender, EventArgs e)
    {
        panelClientDetails.Visible = false;
        panelShowClient.Visible = false;
        panelAllClient.Visible = false;
        panelAddOrUpdateClient.Visible = false;
        panelDeleteClient.Visible = true;
        try
        {
            String num = insertId.Text;
            s_bl.client.Delete(int.Parse(num));
        }
        catch (Exception ex)
        {
            throw new Exception("נתון שגוי");
        }
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
