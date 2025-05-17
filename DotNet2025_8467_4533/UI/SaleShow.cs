
namespace UI
{
    public partial class SaleShow : Form
    {
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
    }
}
