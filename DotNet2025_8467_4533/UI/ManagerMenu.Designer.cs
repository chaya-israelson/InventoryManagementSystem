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
            clients.Location = new Point(490, 137);
            clients.Name = "clients";
            clients.Size = new Size(149, 66);
            clients.TabIndex = 0;
            clients.Text = "לקוחות";
            clients.UseVisualStyleBackColor = true;
            clients.Click += clients_Click;
            // 
            // products
            // 
            products.Location = new Point(325, 137);
            products.Name = "products";
            products.Size = new Size(149, 66);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // sales
            // 
            sales.Location = new Point(160, 137);
            sales.Name = "sales";
            sales.Size = new Size(149, 66);
            sales.TabIndex = 0;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sales);
            Controls.Add(products);
            Controls.Add(clients);
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