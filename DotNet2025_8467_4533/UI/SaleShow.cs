
using BlApi;
using BO;

namespace UI
{
    public partial class SaleShow : Form
    {
        static readonly IBl s_bl = Factory.Get();
        public SaleShow()
        {
            InitializeComponent();
            panelDeleteSale.Visible = false;
            panelAddOrUpdateSale.Visible = false;
            panelAllProduct.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = false;
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            panelAllProduct.Visible = false;
            panelAddOrUpdateSale.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = false;
            panelDeleteSale.Visible = true;
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            panelAllProduct.Visible = false;
            panelDeleteSale.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = false;
            panelAddOrUpdateSale.Visible = true;
            addOrUpdate.Text = "הוסף";
        }

        private void updetProduct_Click(object sender, EventArgs e)
        {
            panelAllProduct.Visible = false;
            panelDeleteSale.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = false;
            panelAddOrUpdateSale.Visible = true;
            addOrUpdate.Text = "עדכן";
        }

        private void AllProducts_Click(object sender, EventArgs e)
        {
            panelDeleteSale.Visible = false;
            panelAddOrUpdateSale.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = false;
            panelAllProduct.Visible = true;
            dataGridViewAllProduct.DataSource = s_bl.sale.ReadAll();

        }

        private void panelAllProduct_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelDeleteSale_Paint(object sender, PaintEventArgs e)
        {
        }

        private void showIdSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                panelDeleteSale.Visible = false;
                panelAddOrUpdateSale.Visible = false;
                panelAllProduct.Visible = false;
                panelSaleDetails.Visible = true;
            }

        }

        private void ShowProduct_Click(object sender, EventArgs e)
        {
            panelDeleteSale.Visible = false;
            panelAddOrUpdateSale.Visible = false;
            panelAllProduct.Visible = false;
            panelSaleDetails.Visible = false;
            panelShowSale.Visible = true;
        }

        private void showIdSale_TextChanged(object sender, EventArgs e)
        {
            if (showIdSale.Text == "")
                panelSaleDetails.Visible = false;
        }

        private void addOrUpdate_Click(object sender, EventArgs e)
        {
            if (addOrUpdate.Text == "הוסף")
            {
                try
                {
                    if (insertAddIdProduct.Text == "" || insertAddCount.Value == 0 || insertTotalPrice.Text == "")
                        MessageBox.Show("Error! please fill all the field!");
                    else
                    {
                        /*                        Sale sale = new Sale(insertAddIdProduct.Text, insertAddIdProduct.Text, insertTotalPrice.Text, insertTotalPric.Text, insertAddAllClient.Checked, insertAddStartDate.Value, insertAddEndDate.Value);
                        */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            if (addOrUpdate.Text == "עדכן")
            {

            }
        }
    }
}
