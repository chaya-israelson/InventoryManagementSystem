using BlApi;
using BO;
namespace UI;

public partial class SaleShow : Form
{
    static readonly IBl s_bl = Factory.Get();
    public SaleShow()
    {
        InitializeComponent();
        panelDeleteSale.Visible = false;
        panelAddOrUpdateSale.Visible = false;
        panelAllSale.Visible = false;
        panelSaleDetails.Visible = false;
        panelShowSale.Visible = false;
    }

    private void deleteProduct_Click(object sender, EventArgs e)
    {
        panelAllSale.Visible = false;
        panelAddOrUpdateSale.Visible = false;
        panelSaleDetails.Visible = false;
        panelShowSale.Visible = false;
        panelDeleteSale.Visible = true;
    }

    private void addProduct_Click(object sender, EventArgs e)
    {
        panelAllSale.Visible = false;
        panelDeleteSale.Visible = false;
        panelSaleDetails.Visible = false;
        panelShowSale.Visible = false;
        panelAddOrUpdateSale.Visible = true;
        addOrUpdate.Text = "הוסף";
        // אתחול כל התאים
        addIdSale.Visible = false;
        insertAddIdSale.Text = "";
        insertAddIdProduct.Text = "";
        insertAddCount.Value = 0;
        insertTotalPrice.Text = "";
        insertAddAllClient.Checked = false;
        insertAddStartDate.Value = DateTime.Now;
        insertAddEndDate.Value = DateTime.Now;

    }

    private void AllProducts_Click(object sender, EventArgs e)
    {
        panelDeleteSale.Visible = false;
        panelAddOrUpdateSale.Visible = false;
        panelSaleDetails.Visible = false;
        panelShowSale.Visible = false;
        panelAllSale.Visible = true;
        dataGridViewAllSale.DataSource = s_bl.sale.ReadAll();

    }


    private void showIdSale_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            panelDeleteSale.Visible = false;
            panelAddOrUpdateSale.Visible = false;
            panelAllSale.Visible = false;
            panelSaleDetails.Visible = true;
            Sale sale = s_bl.sale.Read(int.Parse(showIdSale.Text));
            if (sale == null)
                MessageBox.Show("מבצע לא קיים");
            else
            {
                // מעדכן את כל התוויות בערכים לפי הפרטי מבצע
                showIdProduct.Text = sale.IdProduct.ToString();
                showCount.Text = sale.Count.ToString();
                showPrice.Text = sale.TotalPrice.ToString();
                showAllClient.Checked = bool.Parse(sale.AllCustomers.ToString());
                showStartDate.Text = sale.StartDate.ToString();
                showEndDate.Text = sale.EndDate.ToString();


            }
        }

    }


    private void showIdSale_TextChanged(object sender, EventArgs e)
    {
        if (showIdSale.Text == "")
            panelSaleDetails.Visible = false;
    }

    private void addOrUpdate_Click(object sender, EventArgs e)
    {
        if (addOrUpdate.Text == "הוסף")
        { // לוגיקה של הוספת מבצע למערכת
            try
            {
                if (insertAddIdProduct.Text == "" || insertAddCount.Value == 0 || insertTotalPrice.Text == "")
                    MessageBox.Show("Error! please fill all the field!");
                else
                {
                    Sale sale = new Sale(111, int.Parse(insertAddIdProduct.Text), int.Parse(insertAddCount.Value.ToString()), double.Parse(insertTotalPrice.Text), insertAddAllClient.Checked, insertAddStartDate.Value, insertAddEndDate.Value);
                    s_bl.sale.Create(sale);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        if (addOrUpdate.Text == "עדכן")
        { // לוגיקה של עדכון מבצע
            /*panelAllSale.Visible = true;
            panelAddOrUpdateSale.Visible = false;*/
            Sale sale = new Sale(int.Parse(insertAddIdSale.Text), int.Parse(insertAddIdProduct.Text), int.Parse(insertAddCount.Value.ToString()), double.Parse(insertTotalPrice.Text), insertAddAllClient.Checked, insertAddStartDate.Value, insertAddEndDate.Value);
            s_bl.sale.Update(sale);
        }
    }

    private void dataGridViewAllSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            // קבל את הערכים של השורה שנבחרה
            DataGridViewRow row = dataGridViewAllSale.Rows[e.RowIndex];
            panelAllSale.Visible = false;
            panelAddOrUpdateSale.Visible = true;
            addOrUpdate.Text = "עדכן";
            //  הצבת הערכים של המבצע הנבחר (השורה הנבחרת) בתוך התאים של עדכון מוצר
            addIdSale.Visible = true;
            insertAddIdSale.Text = row.Cells[0].Value.ToString();
            insertAddIdProduct.Text = row.Cells[1].Value.ToString();
            insertAddCount.Value = Convert.ToDecimal(row.Cells[2].Value);
            insertTotalPrice.Text = row.Cells[3].Value.ToString();
            insertAddAllClient.Checked = Convert.ToBoolean(row.Cells[4].Value);
            insertAddStartDate.Value = Convert.ToDateTime(row.Cells[5].Value);
            insertAddEndDate.Value = Convert.ToDateTime(row.Cells[5].Value);
        }
    }

    private void cancel_Click(object sender, EventArgs e)
    {
        panelAllSale.Visible = true;
        panelDeleteSale.Visible = false;

    }

    private void OK_Click(object sender, EventArgs e)
    {
        s_bl.sale.Delete(int.Parse(deleteInsertIdSale.Text));
        deleteInsertIdSale.Text = "";
        panelAllSale.Visible = true;
        panelDeleteSale.Visible = false;
        dataGridViewAllSale.DataSource = s_bl.sale.ReadAll();
    }

    private void ShowSale_Click(object sender, EventArgs e)
    {
        panelDeleteSale.Visible = false;
        panelAddOrUpdateSale.Visible = false;
        panelAllSale.Visible = false;
        panelSaleDetails.Visible = false;
        panelShowSale.Visible = true;
        showIdSale.Text = "";
    }

















    private void panelAddOrUpdateSale_Paint(object sender, PaintEventArgs e)
    {

    }
}
