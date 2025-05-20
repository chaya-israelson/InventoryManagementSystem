namespace UI
{
    partial class AddProduct
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
            Clothing = new Button();
            Footwear = new Button();
            ClimbingEquipment = new Button();
            CampingEquipment = new Button();
            AllProduct = new Button();
            AncillaryEquipment = new Button();
            SuspendLayout();
            // 
            // Clothing
            // 
            Clothing.Location = new Point(257, 86);
            Clothing.Name = "Clothing";
            Clothing.Size = new Size(147, 78);
            Clothing.TabIndex = 2;
            Clothing.Text = "Clothing";
            Clothing.UseVisualStyleBackColor = true;
            // 
            // Footwear
            // 
            Footwear.Location = new Point(69, 86);
            Footwear.Name = "Footwear";
            Footwear.Size = new Size(147, 78);
            Footwear.TabIndex = 3;
            Footwear.Text = "Footwear";
            Footwear.UseVisualStyleBackColor = true;
            // 
            // ClimbingEquipment
            // 
            ClimbingEquipment.Location = new Point(257, 316);
            ClimbingEquipment.Name = "ClimbingEquipment";
            ClimbingEquipment.Size = new Size(147, 78);
            ClimbingEquipment.TabIndex = 4;
            ClimbingEquipment.Text = "ClimbingEquipment";
            ClimbingEquipment.UseVisualStyleBackColor = true;
            // 
            // CampingEquipment
            // 
            CampingEquipment.Location = new Point(257, 195);
            CampingEquipment.Name = "CampingEquipment";
            CampingEquipment.Size = new Size(147, 78);
            CampingEquipment.TabIndex = 5;
            CampingEquipment.Text = "CampingEquipment";
            CampingEquipment.UseVisualStyleBackColor = true;
            // 
            // AllProduct
            // 
            AllProduct.Location = new Point(69, 316);
            AllProduct.Name = "AllProduct";
            AllProduct.Size = new Size(147, 78);
            AllProduct.TabIndex = 6;
            AllProduct.Text = "AllProduct";
            AllProduct.UseVisualStyleBackColor = true;
            // 
            // AncillaryEquipment
            // 
            AncillaryEquipment.Location = new Point(69, 195);
            AncillaryEquipment.Name = "AncillaryEquipment";
            AncillaryEquipment.Size = new Size(147, 78);
            AncillaryEquipment.TabIndex = 7;
            AncillaryEquipment.Text = "AncillaryEquipment";
            AncillaryEquipment.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 468);
            Controls.Add(AncillaryEquipment);
            Controls.Add(AllProduct);
            Controls.Add(CampingEquipment);
            Controls.Add(ClimbingEquipment);
            Controls.Add(Footwear);
            Controls.Add(Clothing);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
        }

        #endregion

        private Button Clothing;
        private Button Footwear;
        private Button ClimbingEquipment;
        private Button CampingEquipment;
        private Button AllProduct;
        private Button AncillaryEquipment;
    }
}