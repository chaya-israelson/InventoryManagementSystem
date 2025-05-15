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
            panelAllProduct = new Panel();
            addNameProduct = new Label();
            addPrice = new Label();
            addCategory = new Label();
            addOrUpdate = new Button();
            insertAddNameProduct = new TextBox();
            insertAddPrice = new TextBox();
            insertAddCategory = new TextBox();
            panelAddOrUpdateProduct = new Panel();
            panelDeleteProduct = new Panel();
            cancel = new Button();
            OK = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            panelShowProduct.SuspendLayout();
            panelProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
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
            ShowProduct.Location = new Point(579, 41);
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
            AllProducts.Location = new Point(579, 140);
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
            addProduct.Location = new Point(579, 241);
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
            deleteProduct.Location = new Point(579, 344);
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
            panelShowProduct.Controls.Add(idProduct);
            panelShowProduct.Controls.Add(showIdProduct);
            panelShowProduct.Location = new Point(90, 76);
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
            panelProductDetails.Location = new Point(90, 183);
            panelProductDetails.Name = "panelProductDetails";
            panelProductDetails.Size = new Size(392, 308);
            panelProductDetails.TabIndex = 2;
            // 
            // listSales
            // 
            listSales.Location = new Point(114, 147);
            listSales.Name = "listSales";
            listSales.Size = new Size(136, 31);
            listSales.TabIndex = 9;
            listSales.Text = ":רשימת מבצעים";
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 20;
            listBoxSales.Location = new Point(85, 181);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(165, 124);
            listBoxSales.TabIndex = 8;
            // 
            // quantityInStock
            // 
            quantityInStock.Location = new Point(202, 115);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(111, 31);
            quantityInStock.TabIndex = 7;
            quantityInStock.Text = ":כמות במלאי";
            // 
            // label8
            // 
            label8.Location = new Point(85, 115);
            label8.Name = "label8";
            label8.Size = new Size(111, 31);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // category
            // 
            category.Location = new Point(202, 81);
            category.Name = "category";
            category.Size = new Size(111, 31);
            category.TabIndex = 5;
            category.Text = ":קטגוריה";
            // 
            // label6
            // 
            label6.Location = new Point(85, 81);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // price
            // 
            price.Location = new Point(202, 49);
            price.Name = "price";
            price.Size = new Size(111, 31);
            price.TabIndex = 3;
            price.Text = ":מחיר";
            // 
            // label4
            // 
            label4.Location = new Point(85, 49);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.Location = new Point(85, 17);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(202, 17);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(111, 31);
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
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Columns.AddRange(new DataGridViewColumn[] { columIdProduct, columNameProduct, columPrice, columnCategory });
            dataGridViewAllProduct.Location = new Point(8, 52);
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
            columIdProduct.HeaderText = "קוד מוצר";
            columIdProduct.MinimumWidth = 6;
            columIdProduct.Name = "columIdProduct";
            columIdProduct.Width = 125;
            // 
            // columNameProduct
            // 
            columNameProduct.HeaderText = "שם מוצר";
            columNameProduct.MinimumWidth = 6;
            columNameProduct.Name = "columNameProduct";
            columNameProduct.Width = 125;
            // 
            // columPrice
            // 
            columPrice.HeaderText = "מחיר";
            columPrice.MinimumWidth = 6;
            columPrice.Name = "columPrice";
            columPrice.Width = 125;
            // 
            // columnCategory
            // 
            columnCategory.HeaderText = "קטגוריה";
            columnCategory.MinimumWidth = 6;
            columnCategory.Name = "columnCategory";
            columnCategory.Width = 125;
            // 
            // panelAllProduct
            // 
            panelAllProduct.Controls.Add(dataGridViewAllProduct);
            panelAllProduct.Location = new Point(19, 63);
            panelAllProduct.Margin = new Padding(3, 4, 3, 4);
            panelAllProduct.Name = "panelAllProduct";
            panelAllProduct.Size = new Size(543, 481);
            panelAllProduct.TabIndex = 4;
            // 
            // addNameProduct
            // 
            addNameProduct.Location = new Point(273, 92);
            addNameProduct.Name = "addNameProduct";
            addNameProduct.Size = new Size(118, 43);
            addNameProduct.TabIndex = 1;
            addNameProduct.Text = "שם מוצר";
            // 
            // addPrice
            // 
            addPrice.Location = new Point(273, 149);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(118, 43);
            addPrice.TabIndex = 2;
            addPrice.Text = "מחיר";
            // 
            // addCategory
            // 
            addCategory.Location = new Point(273, 215);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(118, 43);
            addCategory.TabIndex = 4;
            addCategory.Text = "קטגוריה";
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(202, 312);
            addOrUpdate.Margin = new Padding(3, 4, 3, 4);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(81, 51);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            // 
            // insertAddNameProduct
            // 
            insertAddNameProduct.Location = new Point(117, 92);
            insertAddNameProduct.Margin = new Padding(3, 4, 3, 4);
            insertAddNameProduct.Name = "insertAddNameProduct";
            insertAddNameProduct.Size = new Size(135, 27);
            insertAddNameProduct.TabIndex = 6;
            // 
            // insertAddPrice
            // 
            insertAddPrice.Location = new Point(117, 153);
            insertAddPrice.Margin = new Padding(3, 4, 3, 4);
            insertAddPrice.Name = "insertAddPrice";
            insertAddPrice.Size = new Size(135, 27);
            insertAddPrice.TabIndex = 7;
            // 
            // insertAddCategory
            // 
            insertAddCategory.Location = new Point(117, 215);
            insertAddCategory.Margin = new Padding(3, 4, 3, 4);
            insertAddCategory.Name = "insertAddCategory";
            insertAddCategory.Size = new Size(135, 27);
            insertAddCategory.TabIndex = 8;
            insertAddCategory.TextChanged += textBox2_TextChanged;
            // 
            // panelAddOrUpdateProduct
            // 
            panelAddOrUpdateProduct.Controls.Add(insertAddCategory);
            panelAddOrUpdateProduct.Controls.Add(insertAddPrice);
            panelAddOrUpdateProduct.Controls.Add(insertAddNameProduct);
            panelAddOrUpdateProduct.Controls.Add(addOrUpdate);
            panelAddOrUpdateProduct.Controls.Add(addCategory);
            panelAddOrUpdateProduct.Controls.Add(addPrice);
            panelAddOrUpdateProduct.Controls.Add(addNameProduct);
            panelAddOrUpdateProduct.Location = new Point(189, 41);
            panelAddOrUpdateProduct.Margin = new Padding(3, 4, 3, 4);
            panelAddOrUpdateProduct.Name = "panelAddOrUpdateProduct";
            panelAddOrUpdateProduct.Size = new Size(370, 493);
            panelAddOrUpdateProduct.TabIndex = 5;
            panelAddOrUpdateProduct.Paint += panelAddOrUpdateProduct_Paint;
            // 
            // panelDeleteProduct
            // 
            panelDeleteProduct.Controls.Add(cancel);
            panelDeleteProduct.Controls.Add(OK);
            panelDeleteProduct.Controls.Add(label1);
            panelDeleteProduct.Controls.Add(textBox1);
            panelDeleteProduct.Location = new Point(12, 201);
            panelDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            panelDeleteProduct.Name = "panelDeleteProduct";
            panelDeleteProduct.Size = new Size(568, 133);
            panelDeleteProduct.TabIndex = 9;
            // 
            // cancel
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
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelDeleteProduct);
            Controls.Add(panelAddOrUpdateProduct);
            Controls.Add(panelAllProduct);
            Controls.Add(updetProduct);
            Controls.Add(panelProductDetails);
            Controls.Add(panelShowProduct);
            Controls.Add(deleteProduct);
            Controls.Add(addProduct);
            Controls.Add(AllProducts);
            Controls.Add(ShowProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Options";
            Text = "Options";
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            panelShowProduct.ResumeLayout(false);
            panelShowProduct.PerformLayout();
            panelProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
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
        private Button updetProduct;
        private DataGridView dataGridViewAllProduct;
        private DataGridViewTextBoxColumn columIdProduct;
        private DataGridViewTextBoxColumn columNameProduct;
        private DataGridViewTextBoxColumn columPrice;
        private DataGridViewTextBoxColumn columnCategory;
        private Panel panelAllProduct;
        private Label addNameProduct;
        private Label addPrice;
        private Label addCategory;
        private Button addOrUpdate;
        private TextBox insertAddNameProduct;
        private TextBox insertAddPrice;
        private TextBox insertAddCategory;
        private Panel panelAddOrUpdateProduct;
        private Panel panelDeleteProduct;
        private Button cancel;
        private Button OK;
        private Label label1;
        private TextBox textBox1;
    }
}