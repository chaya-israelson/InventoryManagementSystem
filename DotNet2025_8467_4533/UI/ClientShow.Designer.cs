namespace UI
{
    partial class ClientShow
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
            panelDeleteClient = new Panel();
            cancel = new Button();
            OK = new Button();
            Id = new Label();
            insertId = new TextBox();
            panelAddOrUpdateClient = new Panel();
            insertAddId = new TextBox();
            addId = new Label();
            insertAddPhon = new TextBox();
            insertAddAddres = new TextBox();
            insertAddNameClient = new TextBox();
            addOrUpdate = new Button();
            addPhon = new Label();
            addAddres = new Label();
            addNameClient = new Label();
            dataGridViewAllClient = new DataGridView();
            panelAllClient = new Panel();
            updetClient = new Button();
            panelClientDetails = new Panel();
            Phon = new Label();
            label6 = new Label();
            Addres = new Label();
            label4 = new Label();
            label3 = new Label();
            nameClient = new Label();
            panelShowClient = new Panel();
            idClient = new Label();
            showIdClient = new TextBox();
            deleteClient = new Button();
            addClient = new Button();
            AllClients = new Button();
            ShowClient = new Button();
            panelDeleteClient.SuspendLayout();
            panelAddOrUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllClient).BeginInit();
            panelAllClient.SuspendLayout();
            panelClientDetails.SuspendLayout();
            panelShowClient.SuspendLayout();
            SuspendLayout();
            // 
            // panelDeleteClient
            // 
            panelDeleteClient.BackColor = Color.Transparent;
            panelDeleteClient.Controls.Add(cancel);
            panelDeleteClient.Controls.Add(OK);
            panelDeleteClient.Controls.Add(Id);
            panelDeleteClient.Controls.Add(insertId);
            panelDeleteClient.Location = new Point(182, 201);
            panelDeleteClient.Margin = new Padding(3, 4, 3, 4);
            panelDeleteClient.Name = "panelDeleteClient";
            panelDeleteClient.Size = new Size(568, 133);
            panelDeleteClient.TabIndex = 19;
            panelDeleteClient.Paint += panelDeleteProduct_Paint;
            // 
            // cancel
            // 
            cancel.Location = new Point(242, 86);
            cancel.Name = "cancel";
            cancel.Size = new Size(70, 35);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            OK.Location = new Point(371, 86);
            OK.Name = "OK";
            OK.Size = new Size(70, 35);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // Id
            // 
            Id.Location = new Point(377, 49);
            Id.Name = "Id";
            Id.Size = new Size(109, 27);
            Id.TabIndex = 1;
            Id.Text = "הכנס ת.ז.";
            // 
            // insertId
            // 
            insertId.Location = new Point(178, 49);
            insertId.Name = "insertId";
            insertId.Size = new Size(180, 27);
            insertId.TabIndex = 0;
            // 
            // panelAddOrUpdateClient
            // 
            panelAddOrUpdateClient.BackColor = Color.Transparent;
            panelAddOrUpdateClient.Controls.Add(insertAddId);
            panelAddOrUpdateClient.Controls.Add(addId);
            panelAddOrUpdateClient.Controls.Add(insertAddPhon);
            panelAddOrUpdateClient.Controls.Add(insertAddAddres);
            panelAddOrUpdateClient.Controls.Add(insertAddNameClient);
            panelAddOrUpdateClient.Controls.Add(addOrUpdate);
            panelAddOrUpdateClient.Controls.Add(addPhon);
            panelAddOrUpdateClient.Controls.Add(addAddres);
            panelAddOrUpdateClient.Controls.Add(addNameClient);
            panelAddOrUpdateClient.Location = new Point(332, 73);
            panelAddOrUpdateClient.Margin = new Padding(3, 4, 3, 4);
            panelAddOrUpdateClient.Name = "panelAddOrUpdateClient";
            panelAddOrUpdateClient.Size = new Size(370, 493);
            panelAddOrUpdateClient.TabIndex = 18;
            panelAddOrUpdateClient.Paint += panelAddOrUpdateProduct_Paint;
            // 
            // insertAddId
            // 
            insertAddId.Location = new Point(117, 283);
            insertAddId.Margin = new Padding(3, 4, 3, 4);
            insertAddId.Name = "insertAddId";
            insertAddId.Size = new Size(135, 27);
            insertAddId.TabIndex = 10;
            // 
            // addId
            // 
            addId.Location = new Point(273, 287);
            addId.Name = "addId";
            addId.Size = new Size(118, 43);
            addId.TabIndex = 9;
            addId.Text = "ת.ז.";
            // 
            // insertAddPhon
            // 
            insertAddPhon.Location = new Point(117, 215);
            insertAddPhon.Margin = new Padding(3, 4, 3, 4);
            insertAddPhon.Name = "insertAddPhon";
            insertAddPhon.Size = new Size(135, 27);
            insertAddPhon.TabIndex = 8;
            // 
            // insertAddAddres
            // 
            insertAddAddres.Location = new Point(117, 153);
            insertAddAddres.Margin = new Padding(3, 4, 3, 4);
            insertAddAddres.Name = "insertAddAddres";
            insertAddAddres.Size = new Size(135, 27);
            insertAddAddres.TabIndex = 7;
            // 
            // insertAddNameClient
            // 
            insertAddNameClient.Location = new Point(117, 92);
            insertAddNameClient.Margin = new Padding(3, 4, 3, 4);
            insertAddNameClient.Name = "insertAddNameClient";
            insertAddNameClient.Size = new Size(135, 27);
            insertAddNameClient.TabIndex = 6;
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(186, 372);
            addOrUpdate.Margin = new Padding(3, 4, 3, 4);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(81, 51);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            addOrUpdate.Click += addOrUpdate_Click;
            // 
            // addPhon
            // 
            addPhon.Location = new Point(273, 215);
            addPhon.Name = "addPhon";
            addPhon.Size = new Size(118, 43);
            addPhon.TabIndex = 4;
            addPhon.Text = "פלאפון";
            // 
            // addAddres
            // 
            addAddres.Location = new Point(273, 149);
            addAddres.Name = "addAddres";
            addAddres.Size = new Size(118, 43);
            addAddres.TabIndex = 2;
            addAddres.Text = "כתובת";
            // 
            // addNameClient
            // 
            addNameClient.Location = new Point(273, 92);
            addNameClient.Name = "addNameClient";
            addNameClient.Size = new Size(118, 43);
            addNameClient.TabIndex = 1;
            addNameClient.Text = "שם לקוח";
            // 
            // dataGridViewAllClient
            // 
            dataGridViewAllClient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewAllClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllClient.Location = new Point(0, 30);
            dataGridViewAllClient.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllClient.Name = "dataGridViewAllClient";
            dataGridViewAllClient.RowHeadersWidth = 51;
            dataGridViewAllClient.RowTemplate.Height = 25;
            dataGridViewAllClient.Size = new Size(543, 427);
            dataGridViewAllClient.TabIndex = 0;
            dataGridViewAllClient.CellContentClick += dataGridViewAllProduct_CellContentClick;
            // 
            // panelAllClient
            // 
            panelAllClient.BackColor = Color.Transparent;
            panelAllClient.Controls.Add(dataGridViewAllClient);
            panelAllClient.Location = new Point(182, 89);
            panelAllClient.Margin = new Padding(3, 4, 3, 4);
            panelAllClient.Name = "panelAllClient";
            panelAllClient.Size = new Size(543, 481);
            panelAllClient.TabIndex = 17;
            panelAllClient.Paint += panelAllProduct_Paint;
            // 
            // updetClient
            // 
            updetClient.Location = new Point(759, 466);
            updetClient.Margin = new Padding(3, 4, 3, 4);
            updetClient.Name = "updetClient";
            updetClient.Size = new Size(237, 71);
            updetClient.TabIndex = 16;
            updetClient.Text = "עדכון לקוח";
            updetClient.UseVisualStyleBackColor = true;
            updetClient.Click += updetClient_Click;
            // 
            // panelClientDetails
            // 
            panelClientDetails.BackColor = Color.Transparent;
            panelClientDetails.Controls.Add(Phon);
            panelClientDetails.Controls.Add(label6);
            panelClientDetails.Controls.Add(Addres);
            panelClientDetails.Controls.Add(label4);
            panelClientDetails.Controls.Add(label3);
            panelClientDetails.Controls.Add(nameClient);
            panelClientDetails.Location = new Point(314, 192);
            panelClientDetails.Name = "panelClientDetails";
            panelClientDetails.Size = new Size(392, 308);
            panelClientDetails.TabIndex = 15;
            panelClientDetails.Paint += panelProductDetails_Paint;
            // 
            // Phon
            // 
            Phon.Location = new Point(222, 104);
            Phon.Name = "Phon";
            Phon.Size = new Size(111, 31);
            Phon.TabIndex = 5;
            Phon.Text = "טלפון";
            // 
            // label6
            // 
            label6.Location = new Point(105, 104);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // Addres
            // 
            Addres.Location = new Point(222, 67);
            Addres.Name = "Addres";
            Addres.Size = new Size(111, 31);
            Addres.TabIndex = 3;
            Addres.Text = "כתובת";
            // 
            // label4
            // 
            label4.Location = new Point(105, 67);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.Location = new Point(105, 30);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // nameClient
            // 
            nameClient.Location = new Point(222, 30);
            nameClient.Name = "nameClient";
            nameClient.Size = new Size(111, 31);
            nameClient.TabIndex = 0;
            nameClient.Text = ":שם לקוח";
            // 
            // panelShowClient
            // 
            panelShowClient.BackColor = Color.Transparent;
            panelShowClient.Controls.Add(idClient);
            panelShowClient.Controls.Add(showIdClient);
            panelShowClient.Location = new Point(314, 85);
            panelShowClient.Margin = new Padding(3, 4, 3, 4);
            panelShowClient.Name = "panelShowClient";
            panelShowClient.Size = new Size(392, 100);
            panelShowClient.TabIndex = 14;
            panelShowClient.Paint += panelShowProduct_Paint;
            // 
            // idClient
            // 
            idClient.Location = new Point(278, 48);
            idClient.Name = "idClient";
            idClient.Size = new Size(109, 27);
            idClient.TabIndex = 1;
            idClient.Text = "הכנס ת.ז.";
            // 
            // showIdClient
            // 
            showIdClient.Location = new Point(55, 48);
            showIdClient.Name = "showIdClient";
            showIdClient.Size = new Size(186, 27);
            showIdClient.TabIndex = 0;
            showIdClient.KeyDown += showIdClient_KeyDown;
            // 
            // deleteClient
            // 
            deleteClient.Location = new Point(759, 357);
            deleteClient.Margin = new Padding(3, 4, 3, 4);
            deleteClient.Name = "deleteClient";
            deleteClient.Size = new Size(237, 71);
            deleteClient.TabIndex = 10;
            deleteClient.Text = "מחק לקוח";
            deleteClient.UseVisualStyleBackColor = true;
            deleteClient.Click += deleteClient_Click;
            // 
            // addClient
            // 
            addClient.Location = new Point(759, 254);
            addClient.Margin = new Padding(3, 4, 3, 4);
            addClient.Name = "addClient";
            addClient.Size = new Size(237, 71);
            addClient.TabIndex = 11;
            addClient.Text = "הוסף לקוח";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // AllClients
            // 
            AllClients.Location = new Point(759, 153);
            AllClients.Margin = new Padding(3, 4, 3, 4);
            AllClients.Name = "AllClients";
            AllClients.Size = new Size(237, 71);
            AllClients.TabIndex = 12;
            AllClients.Text = "כל הלקוחות";
            AllClients.UseVisualStyleBackColor = true;
            AllClients.Click += AllClients_Click;
            // 
            // ShowClient
            // 
            ShowClient.Location = new Point(759, 54);
            ShowClient.Margin = new Padding(3, 4, 3, 4);
            ShowClient.Name = "ShowClient";
            ShowClient.Size = new Size(237, 71);
            ShowClient.TabIndex = 13;
            ShowClient.Text = "הצג לקוח";
            ShowClient.UseVisualStyleBackColor = true;
            ShowClient.Click += ShowClient_Click;
            // 
            // ClientShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.world_tourism_day_coronavirus_pandemic_travel_accessories_objects_flat_lay_143683_4760;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 600);
            Controls.Add(panelDeleteClient);
            Controls.Add(panelAddOrUpdateClient);
            Controls.Add(panelAllClient);
            Controls.Add(updetClient);
            Controls.Add(panelClientDetails);
            Controls.Add(panelShowClient);
            Controls.Add(deleteClient);
            Controls.Add(addClient);
            Controls.Add(AllClients);
            Controls.Add(ShowClient);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientShow";
            Text = "ClientShow";
            panelDeleteClient.ResumeLayout(false);
            panelDeleteClient.PerformLayout();
            panelAddOrUpdateClient.ResumeLayout(false);
            panelAddOrUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllClient).EndInit();
            panelAllClient.ResumeLayout(false);
            panelClientDetails.ResumeLayout(false);
            panelShowClient.ResumeLayout(false);
            panelShowClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDeleteClient;
        private Button cancel;
        private Button OK;
        private Label Id;
        private TextBox insertId;
        private Panel panelAddOrUpdateClient;
        private TextBox insertAddPhon;
        private TextBox insertAddAddres;
        private TextBox insertAddNameClient;
        private Button addOrUpdate;
        private Label addPhon;
        private Label addAddres;
        private Label addNameClient;
        private Panel panelAllClient;
        private DataGridView dataGridViewAllClient;
        private Button updetClient;
        private Panel panelClientDetails;
        private Label listSales;
        private ListBox listBoxSales;
        private Label quantityInStock;
        private Label label8;
        private Label Phon;
        private Label label6;
        private Label Addres;
        private Label label4;
        private Label label3;
        private Label nameClient;
        private Panel panelShowClient;
        private Label idClient;
        private TextBox showIdClient;
        private Button deleteClient;
        private Button addClient;
        private Button AllClients;
        private Button ShowClient;
        private TextBox insertAddId;
        private Label addId;
    }
}