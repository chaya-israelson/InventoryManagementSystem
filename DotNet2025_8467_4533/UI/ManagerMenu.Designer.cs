namespace UI
{
    partial class ManagerMenu
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
            clients = new Button();
            products = new Button();
            sales = new Button();
            SuspendLayout();
            // 
            // clients
            // 
            clients.Location = new Point(560, 183);
            clients.Margin = new Padding(3, 4, 3, 4);
            clients.Name = "clients";
            clients.Size = new Size(170, 88);
            clients.TabIndex = 0;
            clients.Text = "לקוחות";
            clients.UseVisualStyleBackColor = true;
            clients.Click += clients_Click;
            // 
            // products
            // 
            products.Location = new Point(371, 183);
            products.Margin = new Padding(3, 4, 3, 4);
            products.Name = "products";
            products.Size = new Size(170, 88);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // sales
            // 
            sales.Location = new Point(183, 183);
            sales.Margin = new Padding(3, 4, 3, 4);
            sales.Name = "sales";
            sales.Size = new Size(170, 88);
            sales.TabIndex = 0;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(sales);
            Controls.Add(products);
            Controls.Add(clients);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button clients;
        private Button products;
        private Button sales;
    }
}