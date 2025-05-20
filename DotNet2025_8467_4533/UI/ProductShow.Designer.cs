namespace UI
{
    partial class ProductShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clientBindingSource = new BindingSource(components);
            ShowProduct = new Button();
            AllProducts = new Button();
            addProduct = new Button();
            deleteProduct = new Button();
            panelShowProduct = new Panel();
            idProduct = new Label();
            showIdProduct = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelProductDetails = new Panel();
            listSales = new Label();
            listBoxSales = new ListBox();
            quantityInStock = new Label();
            label8 = new Label();
            category = new Label();
            label6 = new Label();
            price = new Label();
            label4 = new Label();
            label3 = new Label();
            nameProduct = new Label();
            updetProduct = new Button();
            dataGridViewAllProduct = new DataGridView();
            columIdProduct = new DataGridViewTextBoxColumn();
            columNameProduct = new DataGridViewTextBoxColumn();
            columPrice = new DataGridViewTextBoxColumn();
            columnCategory = new DataGridViewTextBoxColumn();
            idProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityInStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);

            panelAllProduct = new Panel();
            dataGridViewAllProduct = new DataGridView();
            panelAddOrUpdateProduct = new Panel();
            insertAddQuantityInStock = new TextBox();
            insertQuantityInStock = new Label();
            insertAddCategory = new TextBox();
            insertAddPrice = new TextBox();
            insertAddNameProduct = new TextBox();
            addOrUpdate = new Button();
            addCategory = new Label();
            addPrice = new Label();
            addNameProduct = new Label();
            updetProduct = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            OK = new Button();
            cancel = new Button();
            panelDeleteProduct = new Panel();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            panelShowProduct.SuspendLayout();
            panelProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panelAllProduct.SuspendLayout();
/*            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
*/            panelAddOrUpdateProduct.SuspendLayout();
/*            panelDeleteProduct.SuspendLayout();
*/            SuspendLayout();
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(BO.Client);
            // 
            // ShowProduct
            // 
            ShowProduct.Location = new Point(507, 31);
            ShowProduct.Name = "ShowProduct";
            ShowProduct.Size = new Size(207, 53);
            ShowProduct.TabIndex = 0;
            ShowProduct.Text = "הצג מוצר";
            ShowProduct.UseVisualStyleBackColor = true;
            ShowProduct.Click += ShowProduct_Click;
            // 
            // AllProducts
            // 
            AllProducts.Location = new Point(507, 105);
            AllProducts.Name = "AllProducts";
            AllProducts.Size = new Size(207, 53);
            AllProducts.TabIndex = 0;
            AllProducts.Text = "כל המוצרים";
            AllProducts.UseVisualStyleBackColor = true;
            AllProducts.Click += AllProducts_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(507, 181);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(207, 53);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוסף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(507, 258);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(207, 53);
            deleteProduct.TabIndex = 0;
            deleteProduct.Text = "מחק מוצר";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // panelShowProduct
            // 
            panelShowProduct.Controls.Add(idProduct);
            panelShowProduct.Controls.Add(showIdProduct);
            panelShowProduct.Location = new Point(79, 57);
            panelShowProduct.Name = "panelShowProduct";
            panelShowProduct.Size = new Size(343, 75);
            panelShowProduct.TabIndex = 1;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(243, 36);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(95, 20);
            idProduct.TabIndex = 1;
            idProduct.Text = "הכנס קוד מוצר";
            // 
            // showIdProduct
            // 
            showIdProduct.Location = new Point(31, 36);
            showIdProduct.Margin = new Padding(3, 2, 3, 2);
            showIdProduct.Name = "showIdProduct";
            showIdProduct.Size = new Size(181, 23);
            showIdProduct.TabIndex = 0;
            showIdProduct.KeyDown += showIdProduct_KeyDown;
            // 
            // panelProductDetails
            // 
            panelProductDetails.Controls.Add(listSales);
            panelProductDetails.Controls.Add(listBoxSales);
            panelProductDetails.Controls.Add(quantityInStock);
            panelProductDetails.Controls.Add(label8);
            panelProductDetails.Controls.Add(category);
            panelProductDetails.Controls.Add(label6);
            panelProductDetails.Controls.Add(price);
            panelProductDetails.Controls.Add(label4);
            panelProductDetails.Controls.Add(label3);
            panelProductDetails.Controls.Add(nameProduct);
            panelProductDetails.Location = new Point(79, 137);
            panelProductDetails.Margin = new Padding(3, 2, 3, 2);
            panelProductDetails.Name = "panelProductDetails";
            panelProductDetails.Size = new Size(343, 231);
            panelProductDetails.TabIndex = 2;
            // 
            // listSales
            // 
            listSales.Location = new Point(100, 110);
            listSales.Name = "listSales";
            listSales.Size = new Size(119, 23);
            listSales.TabIndex = 9;
            listSales.Text = ":רשימת מבצעים";
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 15;
            listBoxSales.Location = new Point(74, 136);
            listBoxSales.Margin = new Padding(3, 2, 3, 2);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(145, 94);
            listBoxSales.TabIndex = 8;
            // 
            // quantityInStock
            // 
            quantityInStock.Location = new Point(177, 86);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(97, 23);
            quantityInStock.TabIndex = 7;
            quantityInStock.Text = ":כמות במלאי";
            // 
            // label8
            // 
            label8.Location = new Point(74, 86);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // category
            // 
            category.Location = new Point(177, 61);
            category.Name = "category";
            category.Size = new Size(97, 23);
            category.TabIndex = 5;
            category.Text = ":קטגוריה";
            // 
            // label6
            // 
            label6.Location = new Point(74, 61);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // price
            // 
            price.Location = new Point(177, 37);
            price.Name = "price";
            price.Size = new Size(97, 23);
            price.TabIndex = 3;
            price.Text = ":מחיר";
            // 
            // label4
            // 
            label4.Location = new Point(74, 37);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.Location = new Point(74, 13);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(177, 13);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(97, 23);
            nameProduct.TabIndex = 0;
            nameProduct.Text = ":שם מוצר";
            // 
            // updetProduct
            // 
            updetProduct.Location = new Point(579, 453);
            updetProduct.Margin = new Padding(3, 4, 3, 4);
            updetProduct.Name = "updetProduct";
            updetProduct.Size = new Size(237, 71);
            updetProduct.TabIndex = 3;
            updetProduct.Text = "עדכון מוצר";
            updetProduct.UseVisualStyleBackColor = true;
            updetProduct.Click += updetProduct_Click;
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.AutoGenerateColumns = false;
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Columns.AddRange(new DataGridViewColumn[] { columIdProduct, columNameProduct, columPrice, columnCategory, idProductDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn });
            dataGridViewAllProduct.DataSource = productBindingSource;
            dataGridViewAllProduct.Location = new Point(17, 17);
            dataGridViewAllProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.RowTemplate.Height = 25;
            dataGridViewAllProduct.Size = new Size(526, 419);
            dataGridViewAllProduct.TabIndex = 0;
            dataGridViewAllProduct.CellDoubleClick += dataGridViewAllProduct_CellDoubleClick;
            // 
            // columIdProduct
            // 
            columIdProduct.DataPropertyName = "IdProduct";
            columIdProduct.HeaderText = "קוד מוצר";
            columIdProduct.MinimumWidth = 6;
            columIdProduct.Name = "columIdProduct";
            columIdProduct.ReadOnly = true;
            columIdProduct.Width = 125;
            // 
            // columNameProduct
            // 
            columNameProduct.DataPropertyName = "NameProduct";
            columNameProduct.HeaderText = "שם מוצר";
            columNameProduct.MinimumWidth = 6;
            columNameProduct.Name = "columNameProduct";
            columNameProduct.Width = 125;
            // 
            // columPrice
            // 
            columPrice.DataPropertyName = "Price";
            columPrice.HeaderText = "מחיר";
            columPrice.MinimumWidth = 6;
            columPrice.Name = "columPrice";
            columPrice.Width = 125;
            // 
            // columnCategory
            // 
            columnCategory.DataPropertyName = "Category";
            columnCategory.HeaderText = "קטגוריה";
            columnCategory.MinimumWidth = 6;
            columnCategory.Name = "columnCategory";
            columnCategory.Width = 125;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            idProductDataGridViewTextBoxColumn.HeaderText = "IdProduct";
            idProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            idProductDataGridViewTextBoxColumn.ReadOnly = true;
            idProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            quantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BO.Product);
            // 
            // panelAllProduct
            // 
            panelAllProduct.Controls.Add(dataGridViewAllProduct);
            panelAllProduct.Location = new Point(26, 45);
            panelAllProduct.Name = "panelAllProduct";
            panelAllProduct.Size = new Size(475, 361);
            panelAllProduct.TabIndex = 4;
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Location = new Point(7, 39);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.RowTemplate.Height = 25;
            dataGridViewAllProduct.Size = new Size(460, 314);
            dataGridViewAllProduct.TabIndex = 0;
            dataGridViewAllProduct.CellDoubleClick += dataGridViewAllProduct_CellDoubleClick;
            // 
            // panelAddOrUpdateProduct
            // 
            panelAddOrUpdateProduct.Controls.Add(insertAddQuantityInStock);
            panelAddOrUpdateProduct.Controls.Add(insertQuantityInStock);

            panelAddOrUpdateProduct.Controls.Add(insertAddCategory);
            panelAddOrUpdateProduct.Controls.Add(insertAddPrice);
            panelAddOrUpdateProduct.Controls.Add(insertAddNameProduct);
            panelAddOrUpdateProduct.Controls.Add(addOrUpdate);
            panelAddOrUpdateProduct.Controls.Add(addCategory);
            panelAddOrUpdateProduct.Controls.Add(addPrice);
            panelAddOrUpdateProduct.Controls.Add(addNameProduct);
            panelAddOrUpdateProduct.Location = new Point(139, 41);
            panelAddOrUpdateProduct.Margin = new Padding(3, 4, 3, 4);
            panelAddOrUpdateProduct.Location = new Point(120, 36);
            panelAddOrUpdateProduct.Name = "panelAddOrUpdateProduct";
            panelAddOrUpdateProduct.Size = new Size(324, 370);
            panelAddOrUpdateProduct.TabIndex = 5;
            panelAddOrUpdateProduct.Paint += panelAddOrUpdateProduct_Paint;
            // 
            // insertAddQuantityInStock
            // 
            insertAddQuantityInStock.Location = new Point(102, 199);
            insertAddQuantityInStock.Name = "insertAddQuantityInStock";
            insertAddQuantityInStock.Size = new Size(119, 23);
            insertAddQuantityInStock.TabIndex = 10;
            // 
            // insertQuantityInStock
            // 
            insertQuantityInStock.Location = new Point(239, 199);
            insertQuantityInStock.Name = "insertQuantityInStock";
            insertQuantityInStock.Size = new Size(103, 32);
            insertQuantityInStock.TabIndex = 9;
            insertQuantityInStock.Text = "כמות במלאי";
            insertQuantityInStock.Click += label2_Click;
            // 
            // insertAddCategory
            // 
            insertAddCategory.Location = new Point(102, 161);
            insertAddCategory.Name = "insertAddCategory";
            insertAddCategory.Size = new Size(119, 23);
            insertAddCategory.TabIndex = 8;
            insertAddCategory.TextChanged += textBox2_TextChanged;
            // 
            // insertAddPrice
            // 
            insertAddPrice.Location = new Point(102, 115);
            insertAddPrice.Name = "insertAddPrice";
            insertAddPrice.Size = new Size(119, 23);
            insertAddPrice.TabIndex = 7;
            insertAddPrice.TextChanged += insertAddPrice_TextChanged;
            // 
            // insertAddNameProduct
            // 
            insertAddNameProduct.Location = new Point(102, 69);
            insertAddNameProduct.Name = "insertAddNameProduct";
            insertAddNameProduct.Size = new Size(119, 23);
            insertAddNameProduct.TabIndex = 6;
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(162, 251);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(71, 38);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            addOrUpdate.Click += addOrUpdate_Click;
            // 
            // addCategory
            // 
            addCategory.Location = new Point(239, 161);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(103, 32);
            addCategory.TabIndex = 4;
            addCategory.Text = "קטגוריה";
            // 
            // addPrice
            // 
            addPrice.Location = new Point(239, 112);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(103, 32);
            addPrice.TabIndex = 2;
            addPrice.Text = "מחיר";
            // 
            // addNameProduct
            // 
            addNameProduct.Location = new Point(239, 69);
            addNameProduct.Name = "addNameProduct";
            addNameProduct.Size = new Size(103, 32);
            addNameProduct.TabIndex = 1;
            addNameProduct.Text = "שם מוצר";
            // 
            // updetProduct
            // 
            updetProduct.Location = new Point(507, 340);
            updetProduct.Name = "updetProduct";
            updetProduct.Size = new Size(207, 53);
            updetProduct.TabIndex = 3;
            updetProduct.Text = "עדכון מוצר";
            updetProduct.UseVisualStyleBackColor = true;
            updetProduct.Click += updetProduct_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 36);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(266, 36);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "הכנס קוד מוצר";
            // 
            // OK
            // 
            OK.Location = new Point(257, 64);
            OK.Margin = new Padding(3, 2, 3, 2);
            OK.Name = "OK";
            OK.Size = new Size(61, 26);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(158, 64);
            cancel.Margin = new Padding(3, 2, 3, 2);
            cancel.Name = "cancel";
            cancel.Size = new Size(61, 26);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // panelDeleteProduct
            // 
            panelDeleteProduct.Controls.Add(cancel);
            panelDeleteProduct.Controls.Add(OK);
            panelDeleteProduct.Controls.Add(label1);
            panelDeleteProduct.Controls.Add(textBox1);
            panelDeleteProduct.Location = new Point(4, 16);
            panelDeleteProduct.Name = "panelDeleteProduct";
            panelDeleteProduct.Size = new Size(497, 100);
            panelDeleteProduct.TabIndex = 9;
            // 
            // ProductShow
            // 
            cancel.Location = new Point(180, 86);
            cancel.Name = "cancel";
            cancel.Size = new Size(70, 34);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            OK.Location = new Point(294, 86);
             OK.Name = "OK";
             OK.Size = new Size(70, 34);
             OK.TabIndex = 2;
             OK.Text = "אישור";
             OK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(304, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 1;
            label1.Text = "הכנס קוד מוצר";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 0;
            // 
            // ProductShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDeleteProduct);     
            Controls.Add(updetProduct);
            Controls.Add(panelAddOrUpdateProduct);
            Controls.Add(panelAllProduct);
            Controls.Add(panelProductDetails);
            Controls.Add(panelShowProduct);
            Controls.Add(deleteProduct);
            Controls.Add(addProduct);
            Controls.Add(AllProducts);
            Controls.Add(ShowProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductShow";
            Text = "מוצרים";
            Name = "ProductShow";
            Text = "Options";
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            panelShowProduct.ResumeLayout(false);
            panelShowProduct.PerformLayout();
            panelProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panelAllProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            panelAddOrUpdateProduct.ResumeLayout(false);
            panelAddOrUpdateProduct.PerformLayout();
            panelDeleteProduct.ResumeLayout(false);
            panelDeleteProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource clientBindingSource;
        private Button ShowProduct;
        private Button AllProducts;
        private Button addProduct;
        private Button deleteProduct;
        private Panel panelShowProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox showIdProduct;
        private Label idProduct;
        private Panel panelProductDetails;
        private Label category;
        private Label label6;
        private Label price;
        private Label label4;
        private Label label3;
        private Label nameProduct;
        private Label quantityInStock;
        private Label label8;
        private Label listSales;
        private ListBox listBoxSales;
        private Button updetProduct;
        private DataGridView dataGridViewAllProduct;
        private Panel panelAllProduct;
        private Label addNameProduct;
        private Label addPrice;
        private Label addCategory;
        private Button addOrUpdate;
        private TextBox insertAddNameProduct;
        private TextBox insertAddPrice;
        private TextBox insertAddCategory;
        private Panel panelAddOrUpdateProduct;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn columIdProduct;
        private DataGridViewTextBoxColumn columNameProduct;
        private DataGridViewTextBoxColumn columPrice;
        private DataGridViewTextBoxColumn columnCategory;
        private DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Label label1;
        private Button OK;
        private Button cancel;
        private Panel panelDeleteProduct;
        private Label insertQuantityInStock;
        private TextBox insertAddQuantityInStock;
    }
}