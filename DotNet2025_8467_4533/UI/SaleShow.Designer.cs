namespace UI
{
    partial class SaleShow
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
            panelDeleteSale = new Panel();
            cancel = new Button();
            OK = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            panelAddOrUpdateSale = new Panel();
            insertAddEndDate = new DateTimePicker();
            insertTotalPrice = new TextBox();
            insertAddStartDate = new DateTimePicker();
            addTotalPrice = new Label();
            addStartDate = new Label();
            addEndDate = new Label();
            insertAddAllClient = new CheckBox();
            insertAddCount = new NumericUpDown();
            insertAddIdProduct = new TextBox();
            addOrUpdate = new Button();
            addAllClient = new Label();
            addCuont = new Label();
            addIdProduct = new Label();
            panelShowSale = new Panel();
            idSale = new Label();
            showIdSale = new TextBox();
            panelAllProduct = new Panel();
            dataGridViewAllProduct = new DataGridView();
            updetSale = new Button();
            panelSaleDetails = new Panel();
            label13 = new Label();
            label12 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            category = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            deleteSale = new Button();
            addSale = new Button();
            AllSales = new Button();
            ShowSale = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelDeleteSale.SuspendLayout();
            panelAddOrUpdateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)insertAddCount).BeginInit();
            panelShowSale.SuspendLayout();
            panelAllProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            panelSaleDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelDeleteSale
            // 
            panelDeleteSale.BackColor = Color.Transparent;
            panelDeleteSale.Controls.Add(cancel);
            panelDeleteSale.Controls.Add(OK);
            panelDeleteSale.Controls.Add(label1);
            panelDeleteSale.Controls.Add(textBox1);
            panelDeleteSale.Location = new Point(163, 205);
            panelDeleteSale.Margin = new Padding(3, 4, 3, 4);
            panelDeleteSale.Name = "panelDeleteSale";
            panelDeleteSale.Size = new Size(603, 133);
            panelDeleteSale.TabIndex = 19;
            panelDeleteSale.Paint += panelDeleteSale_Paint;
            // 
            // cancel
            // 
            cancel.Location = new Point(268, 87);
            cancel.Name = "cancel";
            cancel.Size = new Size(70, 34);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            OK.Location = new Point(378, 87);
            OK.Name = "OK";
            OK.Size = new Size(70, 34);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(409, 48);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 1;
            label1.Text = "הכנס קוד מבצע";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 0;
            // 
            // panelAddOrUpdateSale
            // 
            panelAddOrUpdateSale.BackColor = Color.Transparent;
            panelAddOrUpdateSale.Controls.Add(insertAddEndDate);
            panelAddOrUpdateSale.Controls.Add(insertTotalPrice);
            panelAddOrUpdateSale.Controls.Add(insertAddStartDate);
            panelAddOrUpdateSale.Controls.Add(addTotalPrice);
            panelAddOrUpdateSale.Controls.Add(addStartDate);
            panelAddOrUpdateSale.Controls.Add(addEndDate);
            panelAddOrUpdateSale.Controls.Add(insertAddAllClient);
            panelAddOrUpdateSale.Controls.Add(insertAddCount);
            panelAddOrUpdateSale.Controls.Add(insertAddIdProduct);
            panelAddOrUpdateSale.Controls.Add(addOrUpdate);
            panelAddOrUpdateSale.Controls.Add(addAllClient);
            panelAddOrUpdateSale.Controls.Add(addCuont);
            panelAddOrUpdateSale.Controls.Add(addIdProduct);
            panelAddOrUpdateSale.Location = new Point(385, 35);
            panelAddOrUpdateSale.Margin = new Padding(3, 4, 3, 4);
            panelAddOrUpdateSale.Name = "panelAddOrUpdateSale";
            panelAddOrUpdateSale.Size = new Size(370, 493);
            panelAddOrUpdateSale.TabIndex = 18;
            // 
            // insertAddEndDate
            // 
            insertAddEndDate.CustomFormat = "";
            insertAddEndDate.Location = new Point(28, 357);
            insertAddEndDate.Name = "insertAddEndDate";
            insertAddEndDate.Size = new Size(224, 27);
            insertAddEndDate.TabIndex = 16;
            // 
            // insertTotalPrice
            // 
            insertTotalPrice.Location = new Point(117, 191);
            insertTotalPrice.Margin = new Padding(3, 4, 3, 4);
            insertTotalPrice.Name = "insertTotalPrice";
            insertTotalPrice.Size = new Size(135, 27);
            insertTotalPrice.TabIndex = 15;
            // 
            // insertAddStartDate
            // 
            insertAddStartDate.CustomFormat = "";
            insertAddStartDate.Location = new Point(28, 304);
            insertAddStartDate.Name = "insertAddStartDate";
            insertAddStartDate.Size = new Size(224, 27);
            insertAddStartDate.TabIndex = 14;
            // 
            // addTotalPrice
            // 
            addTotalPrice.Location = new Point(273, 191);
            addTotalPrice.Name = "addTotalPrice";
            addTotalPrice.Size = new Size(118, 43);
            addTotalPrice.TabIndex = 13;
            addTotalPrice.Text = "מחיר מבצע";
            // 
            // addStartDate
            // 
            addStartDate.Location = new Point(273, 304);
            addStartDate.Name = "addStartDate";
            addStartDate.Size = new Size(118, 43);
            addStartDate.TabIndex = 12;
            addStartDate.Text = "החל מתאריך";
            // 
            // addEndDate
            // 
            addEndDate.Location = new Point(273, 362);
            addEndDate.Name = "addEndDate";
            addEndDate.Size = new Size(118, 43);
            addEndDate.TabIndex = 11;
            addEndDate.Text = "עד תאריך";
            // 
            // insertAddAllClient
            // 
            insertAddAllClient.AutoSize = true;
            insertAddAllClient.Location = new Point(234, 255);
            insertAddAllClient.Name = "insertAddAllClient";
            insertAddAllClient.Size = new Size(18, 17);
            insertAddAllClient.TabIndex = 10;
            insertAddAllClient.UseVisualStyleBackColor = true;
            // 
            // insertAddCount
            // 
            insertAddCount.Location = new Point(117, 142);
            insertAddCount.Name = "insertAddCount";
            insertAddCount.Size = new Size(135, 27);
            insertAddCount.TabIndex = 9;
            // 
            // insertAddIdProduct
            // 
            insertAddIdProduct.Location = new Point(117, 92);
            insertAddIdProduct.Margin = new Padding(3, 4, 3, 4);
            insertAddIdProduct.Name = "insertAddIdProduct";
            insertAddIdProduct.Size = new Size(135, 27);
            insertAddIdProduct.TabIndex = 6;
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(171, 399);
            addOrUpdate.Margin = new Padding(3, 4, 3, 4);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(81, 51);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            addOrUpdate.Click += addOrUpdate_Click;
            // 
            // addAllClient
            // 
            addAllClient.Location = new Point(273, 248);
            addAllClient.Name = "addAllClient";
            addAllClient.Size = new Size(118, 43);
            addAllClient.TabIndex = 4;
            addAllClient.Text = "ללקוחות מועדון";
            // 
            // addCuont
            // 
            addCuont.Location = new Point(273, 149);
            addCuont.Name = "addCuont";
            addCuont.Size = new Size(118, 43);
            addCuont.TabIndex = 2;
            addCuont.Text = "כמות למבצע";
            // 
            // addIdProduct
            // 
            addIdProduct.Location = new Point(273, 92);
            addIdProduct.Name = "addIdProduct";
            addIdProduct.Size = new Size(118, 43);
            addIdProduct.TabIndex = 1;
            addIdProduct.Text = "קוד מוצר";
            // 
            // panelShowSale
            // 
            panelShowSale.BackColor = Color.Transparent;
            panelShowSale.Controls.Add(idSale);
            panelShowSale.Controls.Add(showIdSale);
            panelShowSale.Location = new Point(195, 72);
            panelShowSale.Margin = new Padding(3, 4, 3, 4);
            panelShowSale.Name = "panelShowSale";
            panelShowSale.Size = new Size(572, 100);
            panelShowSale.TabIndex = 14;
            // 
            // idSale
            // 
            idSale.Location = new Point(374, 44);
            idSale.Name = "idSale";
            idSale.Size = new Size(116, 27);
            idSale.TabIndex = 1;
            idSale.Text = "הכנס קוד מבצע";
            // 
            // showIdSale
            // 
            showIdSale.Location = new Point(193, 44);
            showIdSale.Name = "showIdSale";
            showIdSale.Size = new Size(159, 27);
            showIdSale.TabIndex = 0;
            showIdSale.TextChanged += showIdSale_TextChanged;
            showIdSale.KeyDown += showIdSale_KeyDown;
            // 
            // panelAllProduct
            // 
            panelAllProduct.BackColor = Color.Transparent;
            panelAllProduct.Controls.Add(dataGridViewAllProduct);
            panelAllProduct.Location = new Point(225, 57);
            panelAllProduct.Margin = new Padding(3, 4, 3, 4);
            panelAllProduct.Name = "panelAllProduct";
            panelAllProduct.Size = new Size(543, 481);
            panelAllProduct.TabIndex = 17;
            panelAllProduct.Paint += panelAllProduct_Paint;
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Location = new Point(8, 52);
            dataGridViewAllProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.RowTemplate.Height = 25;
            dataGridViewAllProduct.Size = new Size(526, 419);
            dataGridViewAllProduct.TabIndex = 0;
            // 
            // updetSale
            // 
            updetSale.Location = new Point(774, 467);
            updetSale.Margin = new Padding(3, 4, 3, 4);
            updetSale.Name = "updetSale";
            updetSale.Size = new Size(237, 71);
            updetSale.TabIndex = 16;
            updetSale.Text = "עדכון מבצע";
            updetSale.UseVisualStyleBackColor = true;
            updetSale.Click += updetProduct_Click;
            // 
            // panelSaleDetails
            // 
            panelSaleDetails.BackColor = Color.Transparent;
            panelSaleDetails.Controls.Add(label13);
            panelSaleDetails.Controls.Add(label12);
            panelSaleDetails.Controls.Add(label2);
            panelSaleDetails.Controls.Add(label5);
            panelSaleDetails.Controls.Add(label7);
            panelSaleDetails.Controls.Add(label9);
            panelSaleDetails.Controls.Add(label10);
            panelSaleDetails.Controls.Add(label11);
            panelSaleDetails.Controls.Add(label8);
            panelSaleDetails.Controls.Add(category);
            panelSaleDetails.Controls.Add(label6);
            panelSaleDetails.Controls.Add(label4);
            panelSaleDetails.Controls.Add(label3);
            panelSaleDetails.Location = new Point(367, 179);
            panelSaleDetails.Name = "panelSaleDetails";
            panelSaleDetails.Size = new Size(392, 368);
            panelSaleDetails.TabIndex = 15;
            // 
            // label13
            // 
            label13.Location = new Point(85, 264);
            label13.Name = "label13";
            label13.Size = new Size(74, 31);
            label13.TabIndex = 21;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.Location = new Point(85, 213);
            label12.Name = "label12";
            label12.Size = new Size(74, 31);
            label12.TabIndex = 20;
            label12.Text = "label12";
            // 
            // label2
            // 
            label2.Location = new Point(211, 110);
            label2.Name = "label2";
            label2.Size = new Size(118, 43);
            label2.TabIndex = 19;
            label2.Text = "מחיר מבצע";
            // 
            // label5
            // 
            label5.Location = new Point(211, 213);
            label5.Name = "label5";
            label5.Size = new Size(118, 43);
            label5.TabIndex = 18;
            label5.Text = "החל מתאריך";
            // 
            // label7
            // 
            label7.Location = new Point(211, 264);
            label7.Name = "label7";
            label7.Size = new Size(118, 43);
            label7.TabIndex = 17;
            label7.Text = "עד תאריך";
            // 
            // label9
            // 
            label9.Location = new Point(211, 163);
            label9.Name = "label9";
            label9.Size = new Size(118, 43);
            label9.TabIndex = 16;
            label9.Text = "ללקוחות מועדון";
            // 
            // label10
            // 
            label10.Location = new Point(211, 59);
            label10.Name = "label10";
            label10.Size = new Size(118, 43);
            label10.TabIndex = 15;
            label10.Text = "כמות למבצע";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(211, 13);
            label11.Name = "label11";
            label11.Size = new Size(118, 43);
            label11.TabIndex = 14;
            label11.Text = "קוד מוצר";
            // 
            // label8
            // 
            label8.Location = new Point(85, 161);
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
            // 
            // label6
            // 
            label6.Location = new Point(85, 110);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.Location = new Point(85, 59);
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
            // deleteSale
            // 
            deleteSale.Location = new Point(774, 358);
            deleteSale.Margin = new Padding(3, 4, 3, 4);
            deleteSale.Name = "deleteSale";
            deleteSale.Size = new Size(237, 71);
            deleteSale.TabIndex = 10;
            deleteSale.Text = "מחק מבצע";
            deleteSale.UseVisualStyleBackColor = true;
            deleteSale.Click += deleteProduct_Click;
            // 
            // addSale
            // 
            addSale.Location = new Point(774, 255);
            addSale.Margin = new Padding(3, 4, 3, 4);
            addSale.Name = "addSale";
            addSale.Size = new Size(237, 71);
            addSale.TabIndex = 11;
            addSale.Text = "הוסף מבצע";
            addSale.UseVisualStyleBackColor = true;
            addSale.Click += addProduct_Click;
            // 
            // AllSales
            // 
            AllSales.Location = new Point(774, 154);
            AllSales.Margin = new Padding(3, 4, 3, 4);
            AllSales.Name = "AllSales";
            AllSales.Size = new Size(237, 71);
            AllSales.TabIndex = 12;
            AllSales.Text = "כל המבצעים";
            AllSales.UseVisualStyleBackColor = true;
            AllSales.Click += AllProducts_Click;
            // 
            // ShowSale
            // 
            ShowSale.Location = new Point(774, 55);
            ShowSale.Margin = new Padding(3, 4, 3, 4);
            ShowSale.Name = "ShowSale";
            ShowSale.Size = new Size(237, 71);
            ShowSale.TabIndex = 13;
            ShowSale.Text = "הצג מבצע";
            ShowSale.UseVisualStyleBackColor = true;
            ShowSale.Click += ShowProduct_Click;
            // 
            // SaleShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.world_tourism_day_coronavirus_pandemic_travel_accessories_objects_flat_lay_143683_4760;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 600);
            Controls.Add(panelDeleteSale);
            Controls.Add(panelShowSale);
            Controls.Add(panelAddOrUpdateSale);
            Controls.Add(panelAllProduct);
            Controls.Add(updetSale);
            Controls.Add(panelSaleDetails);
            Controls.Add(deleteSale);
            Controls.Add(addSale);
            Controls.Add(AllSales);
            Controls.Add(ShowSale);
            Name = "SaleShow";
            Text = "SaleShow";
            panelDeleteSale.ResumeLayout(false);
            panelDeleteSale.PerformLayout();
            panelAddOrUpdateSale.ResumeLayout(false);
            panelAddOrUpdateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)insertAddCount).EndInit();
            panelShowSale.ResumeLayout(false);
            panelShowSale.PerformLayout();
            panelAllProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            panelSaleDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDeleteSale;
        private Button cancel;
        private Button OK;
        private Label label1;
        private TextBox textBox1;
        private Panel panelAddOrUpdateSale;
        private TextBox insertAddIdProduct;
        private Button addOrUpdate;
        private Label addAllClient;
        private Label addCuont;
        private Label addIdProduct;
        private Panel panelAllProduct;
        private DataGridView dataGridViewAllProduct;
        private Button updetSale;
        private Panel panelSaleDetails;
        private Label label8;
        private Label category;
        private Label label6;
        private Label label4;
        private Label label3;
        private Panel panelShowSale;
        private Label idSale;
        private TextBox showIdSale;
        private Button deleteSale;
        private Button addSale;
        private Button AllSales;
        private Button ShowSale;
        private NumericUpDown insertAddCount;
        private CheckBox insertAddAllClient;
        private Label addStartDate;
        private Label addEndDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label addTotalPrice;
        private DateTimePicker insertAddStartDate;
        private TextBox insertTotalPrice;
        private DateTimePicker insertAddEndDate;
        private Label label13;
        private Label label12;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}