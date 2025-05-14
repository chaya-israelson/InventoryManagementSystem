namespace UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            management = new Button();
            seller = new Button();
            SuspendLayout();
            // 
            // management
            // 
            management.Location = new Point(442, 179);
            management.Name = "management";
            management.Size = new Size(159, 59);
            management.TabIndex = 0;
            management.Text = "מנהל";
            management.UseVisualStyleBackColor = true;
            management.Click += management_Click;
            // 
            // seller
            // 
            seller.Location = new Point(188, 179);
            seller.Name = "seller";
            seller.Size = new Size(159, 59);
            seller.TabIndex = 1;
            seller.Text = "קופאי";
            seller.UseVisualStyleBackColor = true;
            seller.Click += seller_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seller);
            Controls.Add(management);
            Name = "MainForm";
            Text = "MainForm";
            Load += seller_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button management;
        private Button seller;
    }
}
