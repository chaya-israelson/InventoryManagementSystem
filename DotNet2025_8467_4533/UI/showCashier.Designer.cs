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
            IdClient = new Label();
            panelShowOrder = new Panel();
            finishOrder = new Button();
            addProduct = new Button();
            dataGridViewOreder = new DataGridView();
            insertIdClient = new TextBox();
            panelFinishOrder = new Panel();
            newOrder = new Button();
            totalPrice = new Label();
            label1 = new Label();
            panelStartOrder = new Panel();
            panelShowOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOreder).BeginInit();
            panelFinishOrder.SuspendLayout();
            panelStartOrder.SuspendLayout();
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
            panelShowOrder.Controls.Add(finishOrder);
            panelShowOrder.Controls.Add(addProduct);
            panelShowOrder.Controls.Add(dataGridViewOreder);
            panelShowOrder.Location = new Point(51, 71);
            panelShowOrder.Name = "panelShowOrder";
            panelShowOrder.Size = new Size(699, 351);
            panelShowOrder.TabIndex = 4;
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
            // dataGridViewOreder
            // 
            dataGridViewOreder.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewOreder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOreder.Location = new Point(14, 32);
            dataGridViewOreder.Name = "dataGridViewOreder";
            dataGridViewOreder.RowTemplate.Height = 25;
            dataGridViewOreder.Size = new Size(507, 310);
            dataGridViewOreder.TabIndex = 0;
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
            panelFinishOrder.Location = new Point(194, 64);
            panelFinishOrder.Name = "panelFinishOrder";
            panelFinishOrder.Size = new Size(244, 379);
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
            // showCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelStartOrder);
            Controls.Add(panelFinishOrder);
            Controls.Add(panelShowOrder);
            Name = "showCashier";
            Text = "showCashier";
            panelShowOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOreder).EndInit();
            panelFinishOrder.ResumeLayout(false);
            panelStartOrder.ResumeLayout(false);
            panelStartOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label IdClient;
        private Panel panelShowOrder;
        private Button finishOrder;
        private Button addProduct;
        private DataGridView dataGridViewOreder;
        private TextBox insertIdClient;
        private Panel panelFinishOrder;
        private Button newOrder;
        private Label totalPrice;
        private Label label1;
        private Panel panelStartOrder;
    }
}