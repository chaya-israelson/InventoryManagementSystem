using BlApi;
using BO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI;

public partial class showCashier : Form
{
    static readonly IBl s_bl = Factory.Get();
    private Order order;
    bool isClient=false;

    public showCashier()
    {
        InitializeComponent();
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelStartOrder.Visible = true;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = false;
    }

    private void insertIdClient_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            isClient = false;
            panelStartOrder.Visible = false;
            panelAllCategory.Visible = false;
            panelShowAddProducts.Visible = false;
            panelFinishOrder.Visible = false;
            panelShowOrder.Visible = true;
            if (s_bl.client.Read(int.Parse(insertIdClient.Text)) != null)
               isClient = true;
            order = new Order(isClient, new List<ProductInOrder>(), 0);
            dataGridViewOreder.DataSource = null;
            showIsClient.Checked = isClient;

        }
    }
    private void finishOrder_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = true;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = false;
        totalPrice.Text = order.TotalPrice.ToString();

    }

    private void newOrder_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = true;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        insertIdClient.Text = "";
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = false;

    }

    private void Footwear_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll(s => s.Category == BO.categories.Footwear);
        selectCount.Value = 1;
    }

    private void Clothing_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll(s => s.Category == BO.categories.Clothing);
        selectCount.Value = 1;
    }

    private void AncillaryEquipment_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll(s => s.Category == BO.categories.AncillaryEquipment);
        selectCount.Value = 1;


    }

    private void CampingEquipment_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll(s => s.Category == BO.categories.CampingEquipment);
        selectCount.Value = 1;


    }

    private void AllProduct_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll();
        selectCount.Value = 1;

    }

    private void ClimbingEquipment_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = true;
        dataGridViewShowProduct.DataSource = s_bl.product.ReadAll(s => s.Category == BO.categories.Footwear);
        selectCount.Value = 1;

    }



    private void addProduct_Click(object sender, EventArgs e)
    {
        panelStartOrder.Visible = false;
        panelShowAddProducts.Visible = false;
        panelFinishOrder.Visible = false;
        panelShowOrder.Visible = false;
        panelAllCategory.Visible = true;

    }

    private void add_Click(object sender, EventArgs e)
    {
        if (dataGridViewShowProduct.SelectedRows.Count > 0)
        {
            string id = dataGridViewShowProduct.SelectedRows[0].Cells[0].Value.ToString();
            s_bl.order.AddProductToOrder(order, int.Parse(id), int.Parse(selectCount.Value.ToString()));
            panelShowOrder.Visible = true;
            panelFinishOrder.Visible = false;
            panelStartOrder.Visible = false;
            panelAllCategory.Visible = false;
            panelShowAddProducts.Visible = false;


        }
        else
        {
            MessageBox.Show("לא נבחר מוצר");
        }
        dataGridViewOreder.DataSource = order.ListProduct;
    }

    private void goBake_Click(object sender, EventArgs e)
    {
        panelShowOrder.Visible = false;
        panelFinishOrder.Visible = false;
        panelStartOrder.Visible = false;
        panelAllCategory.Visible = true;
        panelShowAddProducts.Visible = false;
    }

    private void goBake2_Click(object sender, EventArgs e)
    {
        panelShowOrder.Visible = true;
        panelFinishOrder.Visible = false;
        panelStartOrder.Visible = false;
        panelAllCategory.Visible = false;
        panelShowAddProducts.Visible = false;
    }
}
