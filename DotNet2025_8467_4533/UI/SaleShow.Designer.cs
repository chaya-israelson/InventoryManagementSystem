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
            deleteIdSale = new Label();
            deleteInsertIdSale = new TextBox();
            panelAddOrUpdateSale = new Panel();
            addIdSale = new Label();
            insertAddIdSale = new Label();
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
            category = new Label();
            panelAllSale = new Panel();
            dataGridViewAllSale = new DataGridView();
            deleteSale = new Button();
            addSale = new Button();
            AllSales = new Button();
            ShowSale = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelShowSale = new Panel();
            showIdSale = new TextBox();
            idSale = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panelSaleDetails = new Panel();
            idProduct = new Label();
            showIdProduct = new Label();
            showCount = new Label();
            count = new Label();
            startDate = new Label();
            allClient = new Label();
            price = new Label();
            endDate = new Label();
            showAllClient = new CheckBox();
            showPrice = new Label();
            showStartDate = new Label();
            showEndDate = new Label();
            panelDeleteSale.SuspendLayout();
            panelAddOrUpdateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)insertAddCount).BeginInit();
            panelAllSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllSale).BeginInit();
            panelShowSale.SuspendLayout();
            panel2.SuspendLayout();
            panelSaleDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelDeleteSale
            // 
            panelDeleteSale.BackColor = Color.Transparent;
            panelDeleteSale.Controls.Add(cancel);
            panelDeleteSale.Controls.Add(OK);
            panelDeleteSale.Controls.Add(deleteIdSale);
            panelDeleteSale.Controls.Add(deleteInsertIdSale);
            panelDeleteSale.Location = new Point(161, 205);
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
            cancel.Click += cancel_Click;
            // 
            // OK
            // 
            OK.Location = new Point(378, 87);
            OK.Name = "OK";
            OK.Size = new Size(70, 34);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // deleteIdSale
            // 
            deleteIdSale.Location = new Point(409, 48);
            deleteIdSale.Name = "deleteIdSale";
            deleteIdSale.Size = new Size(109, 27);
            deleteIdSale.TabIndex = 1;
            deleteIdSale.Text = "הכנס קוד מבצע";
            // 
            // deleteInsertIdSale
            // 
            deleteInsertIdSale.Location = new Point(223, 48);
            deleteInsertIdSale.Name = "deleteInsertIdSale";
            deleteInsertIdSale.Size = new Size(157, 27);
            deleteInsertIdSale.TabIndex = 0;
            // 
            // panelAddOrUpdateSale
            // 
            panelAddOrUpdateSale.BackColor = Color.Transparent;
            panelAddOrUpdateSale.Controls.Add(addIdSale);
            panelAddOrUpdateSale.Controls.Add(insertAddIdSale);
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
            panelAddOrUpdateSale.Location = new Point(386, 35);
            panelAddOrUpdateSale.Margin = new Padding(3, 4, 3, 4);
            panelAddOrUpdateSale.Name = "panelAddOrUpdateSale";
            panelAddOrUpdateSale.Size = new Size(370, 493);
            panelAddOrUpdateSale.TabIndex = 18;
            panelAddOrUpdateSale.Paint += panelAddOrUpdateSale_Paint;
            // 
            // addIdSale
            // 
            addIdSale.Location = new Point(273, 37);
            addIdSale.Name = "addIdSale";
            addIdSale.Size = new Size(118, 30);
            addIdSale.TabIndex = 18;
            addIdSale.Text = "קוד מבצע";
            // 
            // insertAddIdSale
            // 
            insertAddIdSale.Location = new Point(134, 37);
            insertAddIdSale.Name = "insertAddIdSale";
            insertAddIdSale.Size = new Size(118, 30);
            insertAddIdSale.TabIndex = 17;
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
            // category
            // 
            category.Location = new Point(202, 81);
            category.Name = "category";
            category.Size = new Size(111, 31);
            category.TabIndex = 5;
            // 
            // panelAllSale
            // 
            panelAllSale.BackColor = Color.Transparent;
            panelAllSale.Controls.Add(dataGridViewAllSale);
            panelAllSale.Location = new Point(225, 57);
            panelAllSale.Margin = new Padding(3, 4, 3, 4);
            panelAllSale.Name = "panelAllSale";
            panelAllSale.Size = new Size(543, 481);
            panelAllSale.TabIndex = 17;
            panelAllSale.Paint += panelAllProduct_Paint;
            // 
            // dataGridViewAllSale
            // 
            dataGridViewAllSale.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewAllSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllSale.Location = new Point(8, 52);
            dataGridViewAllSale.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllSale.Name = "dataGridViewAllSale";
            dataGridViewAllSale.RowHeadersWidth = 51;
            dataGridViewAllSale.RowTemplate.Height = 25;
            dataGridViewAllSale.Size = new Size(526, 419);
            dataGridViewAllSale.TabIndex = 0;
            dataGridViewAllSale.CellDoubleClick += dataGridViewAllSale_CellDoubleClick;
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
            ShowSale.Click += ShowSale_Click;
            // 
            // panelShowSale
            // 
            panelShowSale.BackColor = Color.Transparent;
            panelShowSale.Controls.Add(showIdSale);
            panelShowSale.Controls.Add(idSale);
            panelShowSale.Controls.Add(panel2);
            panelShowSale.Location = new Point(161, 94);
            panelShowSale.Margin = new Padding(3, 4, 3, 4);
            panelShowSale.Name = "panelShowSale";
            panelShowSale.Size = new Size(604, 86);
            panelShowSale.TabIndex = 21;
            // 
            // showIdSale
            // 
            showIdSale.Location = new Point(178, 27);
            showIdSale.Name = "showIdSale";
            showIdSale.Size = new Size(157, 27);
            showIdSale.TabIndex = 22;
            showIdSale.KeyDown += showIdSale_KeyDown;
            // 
            // idSale
            // 
            idSale.Location = new Point(366, 30);
            idSale.Name = "idSale";
            idSale.Size = new Size(109, 27);
            idSale.TabIndex = 21;
            idSale.Text = "הכנס קוד מבצע";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(267, 230);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 321);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.Location = new Point(281, 250);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 12;
            label1.Text = "כמות למבצע";
            // 
            // label7
            // 
            label7.Location = new Point(281, 202);
            label7.Name = "label7";
            label7.Size = new Size(109, 27);
            label7.TabIndex = 11;
            label7.Text = "כמות למבצע";
            // 
            // label8
            // 
            label8.Location = new Point(281, 115);
            label8.Name = "label8";
            label8.Size = new Size(109, 27);
            label8.TabIndex = 10;
            label8.Text = "כמות למבצע";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(331, 162);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(409, 250);
            label9.Name = "label9";
            label9.Size = new Size(109, 27);
            label9.TabIndex = 8;
            label9.Text = "עד תאריך";
            // 
            // label10
            // 
            label10.Location = new Point(409, 115);
            label10.Name = "label10";
            label10.Size = new Size(109, 27);
            label10.TabIndex = 7;
            label10.Text = "מחיר מבצע";
            // 
            // label11
            // 
            label11.Location = new Point(409, 159);
            label11.Name = "label11";
            label11.Size = new Size(109, 27);
            label11.TabIndex = 6;
            label11.Text = "לקוחות מועדון";
            // 
            // label12
            // 
            label12.Location = new Point(409, 202);
            label12.Name = "label12";
            label12.Size = new Size(109, 27);
            label12.TabIndex = 5;
            label12.Text = "החל מתאריך";
            // 
            // label14
            // 
            label14.Location = new Point(409, 68);
            label14.Name = "label14";
            label14.Size = new Size(109, 27);
            label14.TabIndex = 4;
            label14.Text = "כמות למבצע";
            // 
            // label15
            // 
            label15.Location = new Point(281, 68);
            label15.Name = "label15";
            label15.Size = new Size(109, 27);
            label15.TabIndex = 3;
            label15.Text = "קוד מוצר";
            // 
            // label16
            // 
            label16.Location = new Point(281, 29);
            label16.Name = "label16";
            label16.Size = new Size(109, 27);
            label16.TabIndex = 2;
            label16.Text = "קוד מוצר";
            // 
            // label17
            // 
            label17.Location = new Point(409, 29);
            label17.Name = "label17";
            label17.Size = new Size(109, 27);
            label17.TabIndex = 1;
            label17.Text = "קוד מוצר";
            // 
            // panelSaleDetails
            // 
            panelSaleDetails.BackColor = Color.Transparent;
            panelSaleDetails.Controls.Add(showEndDate);
            panelSaleDetails.Controls.Add(showStartDate);
            panelSaleDetails.Controls.Add(showPrice);
            panelSaleDetails.Controls.Add(showAllClient);
            panelSaleDetails.Controls.Add(endDate);
            panelSaleDetails.Controls.Add(price);
            panelSaleDetails.Controls.Add(allClient);
            panelSaleDetails.Controls.Add(startDate);
            panelSaleDetails.Controls.Add(count);
            panelSaleDetails.Controls.Add(showCount);
            panelSaleDetails.Controls.Add(showIdProduct);
            panelSaleDetails.Controls.Add(idProduct);
            panelSaleDetails.Location = new Point(119, 188);
            panelSaleDetails.Margin = new Padding(3, 4, 3, 4);
            panelSaleDetails.Name = "panelSaleDetails";
            panelSaleDetails.Size = new Size(649, 321);
            panelSaleDetails.TabIndex = 20;
            // 
            // idProduct
            // 
            idProduct.Location = new Point(409, 29);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(109, 27);
            idProduct.TabIndex = 1;
            idProduct.Text = "קוד מוצר";
            // 
            // showIdProduct
            // 
            showIdProduct.Location = new Point(281, 29);
            showIdProduct.Name = "showIdProduct";
            showIdProduct.Size = new Size(109, 27);
            showIdProduct.TabIndex = 2;
            showIdProduct.Text = "קוד מוצר";
            // 
            // showCount
            // 
            showCount.Location = new Point(281, 68);
            showCount.Name = "showCount";
            showCount.Size = new Size(109, 27);
            showCount.TabIndex = 3;
            showCount.Text = "קוד מוצר";
            // 
            // count
            // 
            count.Location = new Point(409, 68);
            count.Name = "count";
            count.Size = new Size(109, 27);
            count.TabIndex = 4;
            count.Text = "כמות למבצע";
            // 
            // startDate
            // 
            startDate.Location = new Point(409, 202);
            startDate.Name = "startDate";
            startDate.Size = new Size(109, 27);
            startDate.TabIndex = 5;
            startDate.Text = "החל מתאריך";
            // 
            // allClient
            // 
            allClient.Location = new Point(409, 159);
            allClient.Name = "allClient";
            allClient.Size = new Size(109, 27);
            allClient.TabIndex = 6;
            allClient.Text = "לקוחות מועדון";
            // 
            // price
            // 
            price.Location = new Point(409, 115);
            price.Name = "price";
            price.Size = new Size(109, 27);
            price.TabIndex = 7;
            price.Text = "מחיר מבצע";
            // 
            // endDate
            // 
            endDate.Location = new Point(409, 250);
            endDate.Name = "endDate";
            endDate.Size = new Size(109, 27);
            endDate.TabIndex = 8;
            endDate.Text = "עד תאריך";
            // 
            // showAllClient
            // 
            showAllClient.AutoSize = true;
            showAllClient.Enabled = false;
            showAllClient.Location = new Point(331, 162);
            showAllClient.Name = "showAllClient";
            showAllClient.Size = new Size(18, 17);
            showAllClient.TabIndex = 9;
            showAllClient.UseVisualStyleBackColor = true;
            // 
            // showPrice
            // 
            showPrice.Location = new Point(281, 115);
            showPrice.Name = "showPrice";
            showPrice.Size = new Size(109, 27);
            showPrice.TabIndex = 10;
            showPrice.Text = "כמות למבצע";
            // 
            // showStartDate
            // 
            showStartDate.Location = new Point(281, 202);
            showStartDate.Name = "showStartDate";
            showStartDate.Size = new Size(109, 27);
            showStartDate.TabIndex = 11;
            showStartDate.Text = "כמות למבצע";
            // 
            // showEndDate
            // 
            showEndDate.Location = new Point(281, 250);
            showEndDate.Name = "showEndDate";
            showEndDate.Size = new Size(109, 27);
            showEndDate.TabIndex = 12;
            showEndDate.Text = "כמות למבצע";
            // 
            // SaleShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.world_tourism_day_coronavirus_pandemic_travel_accessories_objects_flat_lay_143683_4760;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 600);
            Controls.Add(panelSaleDetails);
            Controls.Add(panelShowSale);
            Controls.Add(panelDeleteSale);
            Controls.Add(panelAddOrUpdateSale);
            Controls.Add(panelAllSale);
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
            panelAllSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllSale).EndInit();
            panelShowSale.ResumeLayout(false);
            panelShowSale.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSaleDetails.ResumeLayout(false);
            panelSaleDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDeleteSale;
        private Button cancel;
        private Button OK;
        private Label deleteIdSale;
        private TextBox deleteInsertIdSale;
        private Panel panelAddOrUpdateSale;
        private TextBox insertAddIdProduct;
        private Button addOrUpdate;
        private Label addAllClient;
        private Label addCuont;
        private Label addIdProduct;
        private Panel panelAllSale;
        private DataGridView dataGridViewAllSale;
        private Label S;
        private Label category;
        /*        private Label showIdProduct;
        */        /*        private Panel panelShowSale;
                */        /*private Label idSale;
                        private TextBox showIdSale;*/
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
        /*        private Label showPrice;
        *//*        private Label EndDate;
        *//*        private Label allClient;
        *//*        private Label count;
        *//*        private Label idProduct;
        */
        private Label addIdSale;
        private Label insertAddIdSale;
        /*        private CheckBox showAllClient;
        *//*        private Label showEndDate;
        *//*        private Panel panelSaleDetails;
        */
        private Label showIdProdect;
        private Panel panelShowSale;
        private Panel panel2;
        private Label label1;
        private Label label7;
        private Label label8;
        private CheckBox checkBox1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label idSale;
        private TextBox showIdSale;
        private Panel panelSaleDetails;
        private Label showEndDate;
        private Label showStartDate;
        private Label showPrice;
        private CheckBox showAllClient;
        private Label endDate;
        private Label price;
        private Label allClient;
        private Label startDate;
        private Label count;
        private Label showCount;
        private Label showIdProduct;
        private Label idProduct;
        /*private Label idSale;
private TextBox showIdSale;*/
    }
}