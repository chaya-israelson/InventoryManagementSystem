using BlApi;
using BO;


namespace UI;

public partial class ProductShow : Form
{
    static readonly IBl s_bl = Factory.Get();

    public ProductShow()
    {
        InitializeComponent();
        panelShowProduct.Visible = false;
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = false;
        panelDeleteProduct.Visible = false;

    }

    private void ShowProduct_Click(object sender, EventArgs e)
    {
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = false;
        panelShowProduct.Visible = true;
        panelDeleteProduct.Visible = false;
    }

    private void showIdProduct_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            panelAllProduct.Visible = false;
            panelAddOrUpdateProduct.Visible = false;
            panelProductDetails.Visible = true;
            panelDeleteProduct.Visible = false;
            panelShowProduct.Visible = true;
            try
            {
                string id = showIdProduct.Text;
                BO.Product product = s_bl.product.Read(int.Parse(id));
                label3.Text = product.NameProduct;

            }
            catch (Exception ex)
            {
                throw new Exception("שגוי");
            }

        }
    }

    private void updetProduct_Click(object sender, EventArgs e)
    {
        panelShowProduct.Visible = false;
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = true;
        panelDeleteProduct.Visible = false;
        addOrUpdate.Text = "עדכן";
    }

    private void AllProducts_Click(object sender, EventArgs e)
    {
        panelShowProduct.Visible = false;
        panelProductDetails.Visible = false;
        panelAddOrUpdateProduct.Visible = false;
        panelAllProduct.Visible = true;
        panelDeleteProduct.Visible = false;

        dataGridViewAllProduct.DataSource = s_bl.product.ReadAll();

    }


    private void addProduct_Click(object sender, EventArgs e)
    {
        panelShowProduct.Visible = false;
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = true;
        panelProductDetails.Visible = false;
        addOrUpdate.Text = "הוסף";

    }



    private void deleteProduct_Click(object sender, EventArgs e)
    {
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = false;
        panelShowProduct.Visible = false;
        panelDeleteProduct.Visible = true;
    }
    private void OK_Click(object sender, EventArgs e)
    {
        string id = textBox1.Text;
        s_bl.product.Delete(int.Parse(id));
    }

    private void addOrUpdate_Click(object sender, EventArgs e)
    {
        if (addOrUpdate.Text == "הוספה")
        {
            try
            {
                Product product = new Product(1111, insertAddNameProduct.Text, (categories)Enum.Parse(typeof(categories), insertAddCategory.Text, true), double.Parse(insertAddPrice.Text), int.Parse(insertAddQuantityInStock.Text));
                s_bl.product.Create(product);
            }
            catch (Exception es)
            {
                throw new Exception("שגיאה");
            }
            try
            {
                Product product = new Product(1111, insertAddNameProduct.Text, (categories)Enum.Parse(typeof(categories), insertAddCategory.Text, true), double.Parse(insertAddPrice.Text), int.Parse(insertAddQuantityInStock.Text));
                s_bl.product.Update(product);
            }
            catch (Exception es)
            {
                throw new Exception("שגיאה");
            }

        }
    }










    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }







































    private void DgvShowAllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        /*    ///////////////// לבדוקקקקקקקקקקקקקקקק
            if (e.RowIndex >= 0) // לוודא שהשורה שנבחרה היא חוקית
            {
                DataGridViewRow row = this.dataGridViewAllProduct.Rows[e.RowIndex];
                // כאן תוכל לגשת לערכים של השורה
                var selectedValue = row.Cells["ColumnName"].Value; // החלף "ColumnName" בשם העמודה שלך
                                                                   // בצע פעולה עם הערך הנבחר

            }*/
    }

    private void dataGridViewAllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void panelAddOrUpdateProduct_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridViewAllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }



    private void insertAddPrice_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
}

