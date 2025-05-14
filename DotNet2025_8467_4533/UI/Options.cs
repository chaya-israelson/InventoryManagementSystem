

namespace UI;

public partial class Options : Form
{
    public bool flag = false;
    public Options()
    {
        InitializeComponent();
        panelShowProduct.Visible = false;
        panelProductDetails.Visible = false;
        panelAllProduct.Visible = false;
        panelAddOrUpdateProduct.Visible = false;
        btn.Visible = false;

    }

    private void ShowProduct_Click(object sender, EventArgs e)
    {
        panelShowProduct.Visible = true;

    }

    private void showIdProduct_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            panelProductDetails.Visible = true;


        }
    }

    private void updetProduct_Click(object sender, EventArgs e)
    {

        panelAddOrUpdateProduct.Visible = true;
        addOrUpdate.Text = "עדכן";
    }

    private void AllProducts_Click(object sender, EventArgs e)
    {
        dataGridViewAllProduct.Rows.Add(215188467, "chayaisraelson", 75, 1234);
        panelAllProduct.Visible = true;
    }


    private void addProduct_Click(object sender, EventArgs e)
    {

        panelAddOrUpdateProduct.Visible = true;
        addOrUpdate.Text = "הוסף";

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void DgvShowAllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        ///////////////// לבדוקקקקקקקקקקקקקקקק
        if (e.RowIndex >= 0) // לוודא שהשורה שנבחרה היא חוקית
        {
            DataGridViewRow row = this.dataGridViewAllProduct.Rows[e.RowIndex];
            // כאן תוכל לגשת לערכים של השורה
            var selectedValue = row.Cells["ColumnName"].Value; // החלף "ColumnName" בשם העמודה שלך
                                                               // בצע פעולה עם הערך הנבחר
            btn.Visible = true;
            btn.Text = "מחק";
        }
    }

    private void dataGridViewAllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

