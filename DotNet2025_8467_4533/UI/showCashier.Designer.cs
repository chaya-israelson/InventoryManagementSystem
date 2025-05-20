namespace UI
{
    partial class showCashier
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
            IdClient = new Label();
            panelShowOrder = new Panel();
            dataGridViewOreder = new DataGridView();
            idProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            basePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productInOrderBindingSource2 = new BindingSource(components);
            finishOrder = new Button();
            addProduct = new Button();
            productInOrderBindingSource1 = new BindingSource(components);
            productInOrderBindingSource = new BindingSource(components);
            panelShowAddProducts = new Panel();
            goBake = new Button();
            label2 = new Label();
            add = new Button();
            selectCount = new NumericUpDown();
            label3 = new Label();
            dataGridViewShowProduct = new DataGridView();
            insertIdClient = new TextBox();
            panelFinishOrder = new Panel();
            newOrder = new Button();
            totalPrice = new Label();
            label1 = new Label();
            panelStartOrder = new Panel();
            panelAllCategory = new Panel();
            goBake2 = new Button();
            AncillaryEquipment = new Button();
            AllProduct = new Button();
            CampingEquipment = new Button();
            ClimbingEquipment = new Button();
            Footwear = new Button();
            Clothing = new Button();
            showIsClient = new CheckBox();
            panelShowOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOreder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).BeginInit();
            panelShowAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowProduct).BeginInit();
            panelFinishOrder.SuspendLayout();
            panelStartOrder.SuspendLayout();
            panelAllCategory.SuspendLayout();
            SuspendLayout();
            // 
            // IdClient
            // 
            IdClient.Location = new Point(168, 11);
            IdClient.Name = "IdClient";
            IdClient.RightToLeft = RightToLeft.No;
            IdClient.Size = new Size(117, 29);
            IdClient.TabIndex = 5;
            IdClient.Text = "הכנס ת.ז. לקוח";
            // 
            // panelShowOrder
            // 
            panelShowOrder.Controls.Add(showIsClient);
            panelShowOrder.Controls.Add(dataGridViewOreder);
            panelShowOrder.Controls.Add(finishOrder);
            panelShowOrder.Controls.Add(addProduct);
            panelShowOrder.Location = new Point(51, 71);
            panelShowOrder.Name = "panelShowOrder";
            panelShowOrder.Size = new Size(699, 351);
            panelShowOrder.TabIndex = 4;
            // 
            // dataGridViewOreder
            // 
            dataGridViewOreder.AllowUserToAddRows = false;
            dataGridViewOreder.AllowUserToDeleteRows = false;
            dataGridViewOreder.AutoGenerateColumns = false;
            dataGridViewOreder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOreder.Columns.AddRange(new DataGridViewColumn[] { idProductDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, basePriceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, finalPriceDataGridViewTextBoxColumn });
            dataGridViewOreder.DataSource = productInOrderBindingSource2;
            dataGridViewOreder.Location = new Point(8, 49);
            dataGridViewOreder.Name = "dataGridViewOreder";
            dataGridViewOreder.ReadOnly = true;
            dataGridViewOreder.RowTemplate.Height = 25;
            dataGridViewOreder.Size = new Size(515, 269);
            dataGridViewOreder.TabIndex = 4;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            idProductDataGridViewTextBoxColumn.HeaderText = "IdProduct";
            idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            idProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            finalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productInOrderBindingSource2
            // 
            productInOrderBindingSource2.DataSource = typeof(BO.ProductInOrder);
            // 
            // finishOrder
            // 
            finishOrder.Location = new Point(538, 180);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(140, 68);
            finishOrder.TabIndex = 3;
            finishOrder.Text = "סיום הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(538, 72);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(140, 68);
            addProduct.TabIndex = 1;
            addProduct.Text = " הוסף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // productInOrderBindingSource1
            // 
            productInOrderBindingSource1.DataSource = typeof(BO.ProductInOrder);
            // 
            // productInOrderBindingSource
            // 
            productInOrderBindingSource.DataSource = typeof(BO.ProductInOrder);
            // 
            // panelShowAddProducts
            // 
            panelShowAddProducts.Controls.Add(goBake);
            panelShowAddProducts.Controls.Add(label2);
            panelShowAddProducts.Controls.Add(add);
            panelShowAddProducts.Controls.Add(selectCount);
            panelShowAddProducts.Controls.Add(label3);
            panelShowAddProducts.Controls.Add(dataGridViewShowProduct);
            panelShowAddProducts.Location = new Point(50, 71);
            panelShowAddProducts.Name = "panelShowAddProducts";
            panelShowAddProducts.Size = new Size(455, 381);
            panelShowAddProducts.TabIndex = 11;
            // 
            // goBake
            // 
            goBake.Location = new Point(54, 21);
            goBake.Name = "goBake";
            goBake.Size = new Size(99, 25);
            goBake.TabIndex = 5;
            goBake.Text = "חזרה לעמוד קודם";
            goBake.UseVisualStyleBackColor = true;
            goBake.Click += goBake_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 335);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "בחר כמות";
            // 
            // add
            // 
            add.Location = new Point(122, 331);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 3;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // selectCount
            // 
            selectCount.Location = new Point(220, 331);
            selectCount.Name = "selectCount";
            selectCount.Size = new Size(55, 23);
            selectCount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 54);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 1;
            label3.Text = "בחר מוצר לקניה";
            // 
            // dataGridViewShowProduct
            // 
            dataGridViewShowProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShowProduct.Location = new Point(54, 81);
            dataGridViewShowProduct.MultiSelect = false;
            dataGridViewShowProduct.Name = "dataGridViewShowProduct";
            dataGridViewShowProduct.RowTemplate.Height = 25;
            dataGridViewShowProduct.Size = new Size(344, 227);
            dataGridViewShowProduct.TabIndex = 0;
            // 
            // insertIdClient
            // 
            insertIdClient.Location = new Point(29, 11);
            insertIdClient.Name = "insertIdClient";
            insertIdClient.Size = new Size(117, 23);
            insertIdClient.TabIndex = 3;
            insertIdClient.KeyDown += insertIdClient_KeyDown;
            // 
            // panelFinishOrder
            // 
            panelFinishOrder.Controls.Add(newOrder);
            panelFinishOrder.Controls.Add(totalPrice);
            panelFinishOrder.Controls.Add(label1);
            panelFinishOrder.Location = new Point(173, 65);
            panelFinishOrder.Name = "panelFinishOrder";
            panelFinishOrder.Size = new Size(244, 367);
            panelFinishOrder.TabIndex = 6;
            // 
            // newOrder
            // 
            newOrder.Location = new Point(74, 187);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(115, 52);
            newOrder.TabIndex = 2;
            newOrder.Text = "הזמנה חדשה";
            newOrder.UseVisualStyleBackColor = true;
            newOrder.Click += newOrder_Click;
            // 
            // totalPrice
            // 
            totalPrice.Location = new Point(23, 79);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(94, 25);
            totalPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(139, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "סכום לתשלום";
            // 
            // panelStartOrder
            // 
            panelStartOrder.Controls.Add(IdClient);
            panelStartOrder.Controls.Add(insertIdClient);
            panelStartOrder.Location = new Point(173, 12);
            panelStartOrder.Name = "panelStartOrder";
            panelStartOrder.Size = new Size(285, 42);
            panelStartOrder.TabIndex = 7;
            // 
            // panelAllCategory
            // 
            panelAllCategory.Controls.Add(goBake2);
            panelAllCategory.Controls.Add(AncillaryEquipment);
            panelAllCategory.Controls.Add(AllProduct);
            panelAllCategory.Controls.Add(CampingEquipment);
            panelAllCategory.Controls.Add(ClimbingEquipment);
            panelAllCategory.Controls.Add(Footwear);
            panelAllCategory.Controls.Add(Clothing);
            panelAllCategory.Location = new Point(115, 55);
            panelAllCategory.Name = "panelAllCategory";
            panelAllCategory.Size = new Size(393, 381);
            panelAllCategory.TabIndex = 10;
            // 
            // goBake2
            // 
            goBake2.Location = new Point(20, 8);
            goBake2.Name = "goBake2";
            goBake2.Size = new Size(123, 36);
            goBake2.TabIndex = 8;
            goBake2.Text = "חזרה לעמוד קודם";
            goBake2.UseVisualStyleBackColor = true;
            goBake2.Click += goBake2_Click;
            // 
            // AncillaryEquipment
            // 
            AncillaryEquipment.Location = new Point(26, 170);
            AncillaryEquipment.Name = "AncillaryEquipment";
            AncillaryEquipment.Size = new Size(147, 78);
            AncillaryEquipment.TabIndex = 7;
            AncillaryEquipment.Text = "AncillaryEquipment";
            AncillaryEquipment.UseVisualStyleBackColor = true;
            AncillaryEquipment.Click += AncillaryEquipment_Click;
            // 
            // AllProduct
            // 
            AllProduct.Location = new Point(26, 291);
            AllProduct.Name = "AllProduct";
            AllProduct.Size = new Size(147, 78);
            AllProduct.TabIndex = 6;
            AllProduct.Text = "AllProduct";
            AllProduct.UseVisualStyleBackColor = true;
            AllProduct.Click += AllProduct_Click;
            // 
            // CampingEquipment
            // 
            CampingEquipment.Location = new Point(214, 170);
            CampingEquipment.Name = "CampingEquipment";
            CampingEquipment.Size = new Size(147, 78);
            CampingEquipment.TabIndex = 5;
            CampingEquipment.Text = "CampingEquipment";
            CampingEquipment.UseVisualStyleBackColor = true;
            CampingEquipment.Click += CampingEquipment_Click;
            // 
            // ClimbingEquipment
            // 
            ClimbingEquipment.Location = new Point(214, 291);
            ClimbingEquipment.Name = "ClimbingEquipment";
            ClimbingEquipment.Size = new Size(147, 78);
            ClimbingEquipment.TabIndex = 4;
            ClimbingEquipment.Text = "ClimbingEquipment";
            ClimbingEquipment.UseVisualStyleBackColor = true;
            ClimbingEquipment.Click += ClimbingEquipment_Click;
            // 
            // Footwear
            // 
            Footwear.Location = new Point(26, 61);
            Footwear.Name = "Footwear";
            Footwear.Size = new Size(147, 78);
            Footwear.TabIndex = 3;
            Footwear.Text = "Footwear";
            Footwear.UseVisualStyleBackColor = true;
            Footwear.Click += Footwear_Click;
            // 
            // Clothing
            // 
            Clothing.Location = new Point(214, 61);
            Clothing.Name = "Clothing";
            Clothing.Size = new Size(147, 78);
            Clothing.TabIndex = 2;
            Clothing.Text = "Clothing";
            Clothing.UseVisualStyleBackColor = true;
            Clothing.Click += Clothing_Click;
            // 
            // showIsClient
            // 
            showIsClient.AutoSize = true;
            showIsClient.Enabled = false;
            showIsClient.Location = new Point(224, 17);
            showIsClient.Name = "showIsClient";
            showIsClient.Size = new Size(85, 19);
            showIsClient.TabIndex = 5;
            showIsClient.Text = "לקוח מועדון";
            showIsClient.UseVisualStyleBackColor = true;
            // 
            // showCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAllCategory);
            Controls.Add(panelShowAddProducts);
            Controls.Add(panelStartOrder);
            Controls.Add(panelFinishOrder);
            Controls.Add(panelShowOrder);
            Name = "showCashier";
            Text = "showCashier";
            panelShowOrder.ResumeLayout(false);
            panelShowOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOreder).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).EndInit();
            panelShowAddProducts.ResumeLayout(false);
            panelShowAddProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowProduct).EndInit();
            panelFinishOrder.ResumeLayout(false);
            panelStartOrder.ResumeLayout(false);
            panelStartOrder.PerformLayout();
            panelAllCategory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label IdClient;
        private Panel panelShowOrder;
        private Button finishOrder;
        private Button addProduct;
        private TextBox insertIdClient;
        private Panel panelFinishOrder;
        private Button newOrder;
        private Label totalPrice;
        private Label label1;
        private Panel panelStartOrder;
        private BindingSource productInOrderBindingSource;
        private Panel panelShowAddProducts;
        private Button goBake;
        private Label label2;
        private Button add;
        private NumericUpDown selectCount;
        private Label label3;
        private DataGridView dataGridViewShowProduct;
        private Panel panelAllCategory;
        private Button AncillaryEquipment;
        private Button AllProduct;
        private Button CampingEquipment;
        private Button ClimbingEquipment;
        private Button Footwear;
        private Button Clothing;
        private BindingSource productInOrderBindingSource1;
        private DataGridView dataGridViewOreder;
        private DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private BindingSource productInOrderBindingSource2;
        private Button goBake2;
        private CheckBox showIsClient;
    }
}