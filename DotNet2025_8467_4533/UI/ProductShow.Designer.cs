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
            panelAddOrUpdateProduct = new Panel();
            insertAddIdProduct = new Label();
            addIdProduct = new Label();
            insertAddQuantityInStock = new TextBox();
            insertQuantityInStock = new Label();
            insertAddCategory = new TextBox();
            insertAddPrice = new TextBox();
            insertAddNameProduct = new TextBox();
            addOrUpdate = new Button();
            addCategory = new Label();
            addPrice = new Label();
            addNameProduct = new Label();
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
            panelAddOrUpdateProduct.SuspendLayout();
            panelDeleteProduct.SuspendLayout();
            SuspendLayout();
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(BO.Client);
            // 
            // ShowProduct
            // 
            ShowProduct.Location = new Point(769, 52);
            ShowProduct.Margin = new Padding(3, 4, 3, 4);
            ShowProduct.Name = "ShowProduct";
            ShowProduct.Size = new Size(237, 71);
            ShowProduct.TabIndex = 0;
            ShowProduct.Text = "הצג מוצר";
            ShowProduct.UseVisualStyleBackColor = true;
            ShowProduct.Click += ShowProduct_Click;
            // 
            // AllProducts
            // 
            AllProducts.Location = new Point(769, 151);
            AllProducts.Margin = new Padding(3, 4, 3, 4);
            AllProducts.Name = "AllProducts";
            AllProducts.Size = new Size(237, 71);
            AllProducts.TabIndex = 0;
            AllProducts.Text = "כל המוצרים";
            AllProducts.UseVisualStyleBackColor = true;
            AllProducts.Click += AllProducts_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(769, 252);
            addProduct.Margin = new Padding(3, 4, 3, 4);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(237, 71);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוסף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(769, 355);
            deleteProduct.Margin = new Padding(3, 4, 3, 4);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(237, 71);
            deleteProduct.TabIndex = 0;
            deleteProduct.Text = "מחק מוצר";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // panelShowProduct
            // 
            panelShowProduct.BackColor = Color.Transparent;
            panelShowProduct.Controls.Add(idProduct);
            panelShowProduct.Controls.Add(showIdProduct);
            panelShowProduct.Location = new Point(335, 81);
            panelShowProduct.Margin = new Padding(3, 4, 3, 4);
            panelShowProduct.Name = "panelShowProduct";
            panelShowProduct.Size = new Size(392, 100);
            panelShowProduct.TabIndex = 1;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(278, 48);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(109, 27);
            idProduct.TabIndex = 1;
            idProduct.Text = "הכנס קוד מוצר";
            // 
            // showIdProduct
            // 
            showIdProduct.Location = new Point(35, 48);
            showIdProduct.Name = "showIdProduct";
            showIdProduct.Size = new Size(206, 27);
            showIdProduct.TabIndex = 0;
            showIdProduct.KeyDown += showIdProduct_KeyDown;
            // 
            // panelProductDetails
            // 
            panelProductDetails.BackColor = Color.Transparent;
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
            panelProductDetails.Location = new Point(335, 188);
            panelProductDetails.Name = "panelProductDetails";
            panelProductDetails.Size = new Size(392, 308);
            panelProductDetails.TabIndex = 2;
            // 
            // listSales
            // 
            listSales.Location = new Point(132, 152);
            listSales.Name = "listSales";
            listSales.Size = new Size(136, 31);
            listSales.TabIndex = 9;
            listSales.Text = ":רשימת מבצעים";
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 20;
            listBoxSales.Location = new Point(103, 186);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(165, 124);
            listBoxSales.TabIndex = 8;
            // 
            // quantityInStock
            // 
            quantityInStock.Location = new Point(220, 120);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(111, 31);
            quantityInStock.TabIndex = 7;
            quantityInStock.Text = ":כמות במלאי";
            // 
            // label8
            // 
            label8.Location = new Point(103, 120);
            label8.Name = "label8";
            label8.Size = new Size(111, 31);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // category
            // 
            category.Location = new Point(220, 86);
            category.Name = "category";
            category.Size = new Size(111, 31);
            category.TabIndex = 5;
            category.Text = ":קטגוריה";
            // 
            // label6
            // 
            label6.Location = new Point(103, 86);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // price
            // 
            price.Location = new Point(220, 54);
            price.Name = "price";
            price.Size = new Size(111, 31);
            price.TabIndex = 3;
            price.Text = ":מחיר";
            // 
            // label4
            // 
            label4.Location = new Point(103, 54);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.Location = new Point(103, 22);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(220, 22);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(111, 31);
            nameProduct.TabIndex = 0;
            nameProduct.Text = ":שם מוצר";
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.AutoGenerateColumns = false;
            dataGridViewAllProduct.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Columns.AddRange(new DataGridViewColumn[] { columIdProduct, columNameProduct, columPrice, columnCategory, idProductDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn });
            dataGridViewAllProduct.DataSource = productBindingSource;
            dataGridViewAllProduct.Location = new Point(8, 52);
            dataGridViewAllProduct.Margin = new Padding(3, 5, 3, 5);
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
            panelAllProduct.BackColor = Color.Transparent;
            panelAllProduct.Controls.Add(dataGridViewAllProduct);
            panelAllProduct.Location = new Point(222, 64);
            panelAllProduct.Margin = new Padding(3, 4, 3, 4);
            panelAllProduct.Name = "panelAllProduct";
            panelAllProduct.Size = new Size(543, 492);
            panelAllProduct.TabIndex = 4;
            // 
            // panelAddOrUpdateProduct
            // 
            panelAddOrUpdateProduct.BackColor = Color.Transparent;
            panelAddOrUpdateProduct.Controls.Add(insertAddIdProduct);
            panelAddOrUpdateProduct.Controls.Add(addIdProduct);
            panelAddOrUpdateProduct.Controls.Add(insertAddQuantityInStock);
            panelAddOrUpdateProduct.Controls.Add(insertQuantityInStock);
            panelAddOrUpdateProduct.Controls.Add(insertAddCategory);
            panelAddOrUpdateProduct.Controls.Add(insertAddPrice);
            panelAddOrUpdateProduct.Controls.Add(insertAddNameProduct);
            panelAddOrUpdateProduct.Controls.Add(addOrUpdate);
            panelAddOrUpdateProduct.Controls.Add(addCategory);
            panelAddOrUpdateProduct.Controls.Add(addPrice);
            panelAddOrUpdateProduct.Controls.Add(addNameProduct);
            panelAddOrUpdateProduct.Location = new Point(351, 77);
            panelAddOrUpdateProduct.Margin = new Padding(3, 5, 3, 5);
            panelAddOrUpdateProduct.Name = "panelAddOrUpdateProduct";
            panelAddOrUpdateProduct.Size = new Size(370, 493);
            panelAddOrUpdateProduct.TabIndex = 5;
            // 
            // insertAddIdProduct
            // 
            insertAddIdProduct.Location = new Point(134, 26);
            insertAddIdProduct.Name = "insertAddIdProduct";
            insertAddIdProduct.Size = new Size(118, 43);
            insertAddIdProduct.TabIndex = 4;
            // 
            // addIdProduct
            // 
            addIdProduct.Location = new Point(273, 26);
            addIdProduct.Name = "addIdProduct";
            addIdProduct.Size = new Size(118, 43);
            addIdProduct.TabIndex = 4;
            addIdProduct.Text = "קוד מוצר";
            // 
            // insertAddQuantityInStock
            // 
            insertAddQuantityInStock.Location = new Point(117, 265);
            insertAddQuantityInStock.Margin = new Padding(3, 4, 3, 4);
            insertAddQuantityInStock.Name = "insertAddQuantityInStock";
            insertAddQuantityInStock.Size = new Size(135, 27);
            insertAddQuantityInStock.TabIndex = 10;
            // 
            // insertQuantityInStock
            // 
            insertQuantityInStock.Location = new Point(273, 265);
            insertQuantityInStock.Name = "insertQuantityInStock";
            insertQuantityInStock.Size = new Size(118, 43);
            insertQuantityInStock.TabIndex = 9;
            insertQuantityInStock.Text = "כמות במלאי";
            // 
            // insertAddCategory
            // 
            insertAddCategory.Location = new Point(117, 215);
            insertAddCategory.Margin = new Padding(3, 4, 3, 4);
            insertAddCategory.Name = "insertAddCategory";
            insertAddCategory.Size = new Size(135, 27);
            insertAddCategory.TabIndex = 8;
            // 
            // insertAddPrice
            // 
            insertAddPrice.Location = new Point(117, 153);
            insertAddPrice.Margin = new Padding(3, 4, 3, 4);
            insertAddPrice.Name = "insertAddPrice";
            insertAddPrice.Size = new Size(135, 27);
            insertAddPrice.TabIndex = 7;
            // 
            // insertAddNameProduct
            // 
            insertAddNameProduct.Location = new Point(117, 92);
            insertAddNameProduct.Margin = new Padding(3, 4, 3, 4);
            insertAddNameProduct.Name = "insertAddNameProduct";
            insertAddNameProduct.Size = new Size(135, 27);
            insertAddNameProduct.TabIndex = 6;
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(185, 335);
            addOrUpdate.Margin = new Padding(3, 4, 3, 4);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(81, 51);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            addOrUpdate.Click += addOrUpdate_Click;
            // 
            // addCategory
            // 
            addCategory.Location = new Point(273, 215);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(118, 43);
            addCategory.TabIndex = 4;
            addCategory.Text = "קטגוריה";
            // 
            // addPrice
            // 
            addPrice.Location = new Point(273, 149);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(118, 43);
            addPrice.TabIndex = 2;
            addPrice.Text = "מחיר";
            // 
            // addNameProduct
            // 
            addNameProduct.Location = new Point(273, 92);
            addNameProduct.Name = "addNameProduct";
            addNameProduct.Size = new Size(118, 43);
            addNameProduct.TabIndex = 1;
            addNameProduct.Text = "שם מוצר";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(399, 29);
            label1.Name = "label1";
            label1.Size = new Size(125, 36);
            label1.TabIndex = 1;
            label1.Text = "הכנס קוד מוצר";
            // 
            // OK
            // 
            OK.Location = new Point(384, 80);
            OK.Name = "OK";
            OK.Size = new Size(80, 45);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(222, 80);
            cancel.Name = "cancel";
            cancel.Size = new Size(80, 45);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // panelDeleteProduct
            // 
            panelDeleteProduct.BackColor = Color.Transparent;
            panelDeleteProduct.Controls.Add(cancel);
            panelDeleteProduct.Controls.Add(OK);
            panelDeleteProduct.Controls.Add(label1);
            panelDeleteProduct.Controls.Add(textBox1);
            panelDeleteProduct.Location = new Point(197, 187);
            panelDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            panelDeleteProduct.Name = "panelDeleteProduct";
            panelDeleteProduct.Size = new Size(568, 151);
            panelDeleteProduct.TabIndex = 9;
            // 
            // ProductShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.world_tourism_day_coronavirus_pandemic_travel_accessories_objects_flat_lay_143683_4760;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 600);
            Controls.Add(panelDeleteProduct);
            Controls.Add(panelAddOrUpdateProduct);
            Controls.Add(panelAllProduct);
            Controls.Add(panelProductDetails);
            Controls.Add(panelShowProduct);
            Controls.Add(deleteProduct);
            Controls.Add(addProduct);
            Controls.Add(AllProducts);
            Controls.Add(ShowProduct);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ProductShow";
            Text = "Options";
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            panelShowProduct.ResumeLayout(false);
            panelShowProduct.PerformLayout();
            panelProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panelAllProduct.ResumeLayout(false);
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
        private Label addIdProduct;
        private Label insertAddIdProduct;
    }
}