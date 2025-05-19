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
            columIdClient = new DataGridViewTextBoxColumn();
            columNameClient = new DataGridViewTextBoxColumn();
            columAddres = new DataGridViewTextBoxColumn();
            ColumnPhon = new DataGridViewTextBoxColumn();
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
            panelDeleteClient.Controls.Add(cancel);
            panelDeleteClient.Controls.Add(OK);
            panelDeleteClient.Controls.Add(Id);
            panelDeleteClient.Controls.Add(insertId);
            panelDeleteClient.Location = new Point(62, 341);
            panelDeleteClient.Name = "panelDeleteClient";
            panelDeleteClient.Size = new Size(497, 100);
            panelDeleteClient.TabIndex = 19;
            panelDeleteClient.Paint += panelDeleteProduct_Paint;
            // 
            // cancel
            // 
            cancel.Location = new Point(158, 64);
            cancel.Margin = new Padding(3, 2, 3, 2);
            cancel.Name = "cancel";
            cancel.Size = new Size(61, 26);
            cancel.TabIndex = 3;
            cancel.Text = "ביטול";
            cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            OK.Location = new Point(257, 64);
            OK.Margin = new Padding(3, 2, 3, 2);
            OK.Name = "OK";
            OK.Size = new Size(61, 26);
            OK.TabIndex = 2;
            OK.Text = "אישור";
            OK.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            Id.Location = new Point(266, 36);
            Id.Name = "Id";
            Id.Size = new Size(95, 20);
            Id.TabIndex = 1;
            Id.Text = "הכנס ת.ז.";
            // 
            // insertId
            // 
            insertId.Location = new Point(60, 36);
            insertId.Margin = new Padding(3, 2, 3, 2);
            insertId.Name = "insertId";
            insertId.Size = new Size(181, 23);
            insertId.TabIndex = 0;
            // 
            // panelAddOrUpdateClient
            // 
            panelAddOrUpdateClient.Controls.Add(panelDeleteClient);
            panelAddOrUpdateClient.Controls.Add(insertAddId);
            panelAddOrUpdateClient.Controls.Add(addId);
            panelAddOrUpdateClient.Controls.Add(insertAddPhon);
            panelAddOrUpdateClient.Controls.Add(insertAddAddres);
            panelAddOrUpdateClient.Controls.Add(insertAddNameClient);
            panelAddOrUpdateClient.Controls.Add(addOrUpdate);
            panelAddOrUpdateClient.Controls.Add(addPhon);
            panelAddOrUpdateClient.Controls.Add(addAddres);
            panelAddOrUpdateClient.Controls.Add(addNameClient);
            panelAddOrUpdateClient.Location = new Point(167, 26);
            panelAddOrUpdateClient.Name = "panelAddOrUpdateClient";
            panelAddOrUpdateClient.Size = new Size(324, 370);
            panelAddOrUpdateClient.TabIndex = 18;
            panelAddOrUpdateClient.Paint += panelAddOrUpdateProduct_Paint;
            // 
            // insertAddId
            // 
            insertAddId.Location = new Point(102, 212);
            insertAddId.Name = "insertAddId";
            insertAddId.Size = new Size(119, 23);
            insertAddId.TabIndex = 10;
            // 
            // addId
            // 
            addId.Location = new Point(239, 215);
            addId.Name = "addId";
            addId.Size = new Size(103, 32);
            addId.TabIndex = 9;
            addId.Text = "ת.ז.";
            // 
            // insertAddPhon
            // 
            insertAddPhon.Location = new Point(102, 161);
            insertAddPhon.Name = "insertAddPhon";
            insertAddPhon.Size = new Size(119, 23);
            insertAddPhon.TabIndex = 8;
            // 
            // insertAddAddres
            // 
            insertAddAddres.Location = new Point(102, 115);
            insertAddAddres.Name = "insertAddAddres";
            insertAddAddres.Size = new Size(119, 23);
            insertAddAddres.TabIndex = 7;
            // 
            // insertAddNameClient
            // 
            insertAddNameClient.Location = new Point(102, 69);
            insertAddNameClient.Name = "insertAddNameClient";
            insertAddNameClient.Size = new Size(119, 23);
            insertAddNameClient.TabIndex = 6;
            // 
            // addOrUpdate
            // 
            addOrUpdate.Location = new Point(163, 279);
            addOrUpdate.Name = "addOrUpdate";
            addOrUpdate.Size = new Size(71, 38);
            addOrUpdate.TabIndex = 5;
            addOrUpdate.Text = "הוסף";
            addOrUpdate.UseVisualStyleBackColor = true;
            // 
            // addPhon
            // 
            addPhon.Location = new Point(239, 161);
            addPhon.Name = "addPhon";
            addPhon.Size = new Size(103, 32);
            addPhon.TabIndex = 4;
            addPhon.Text = "פלאפון";
            // 
            // addAddres
            // 
            addAddres.Location = new Point(239, 112);
            addAddres.Name = "addAddres";
            addAddres.Size = new Size(103, 32);
            addAddres.TabIndex = 2;
            addAddres.Text = "כתובת";
            // 
            // addNameClient
            // 
            addNameClient.Location = new Point(239, 69);
            addNameClient.Name = "addNameClient";
            addNameClient.Size = new Size(103, 32);
            addNameClient.TabIndex = 1;
            addNameClient.Text = "שם לקוח";
            // 
            // dataGridViewAllClient
            // 
            dataGridViewAllClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllClient.Columns.AddRange(new DataGridViewColumn[] { columIdClient, columNameClient, columAddres, ColumnPhon });
            dataGridViewAllClient.Location = new Point(0, 3);
            dataGridViewAllClient.Name = "dataGridViewAllClient";
            dataGridViewAllClient.RowHeadersWidth = 51;
            dataGridViewAllClient.RowTemplate.Height = 25;
            dataGridViewAllClient.Size = new Size(475, 320);
            dataGridViewAllClient.TabIndex = 0;
            dataGridViewAllClient.CellContentClick += dataGridViewAllProduct_CellContentClick;
            // 
            // columIdClient
            // 
            columIdClient.HeaderText = "ת.ז.";
            columIdClient.MinimumWidth = 6;
            columIdClient.Name = "columIdClient";
            columIdClient.Width = 125;
            // 
            // columNameClient
            // 
            columNameClient.HeaderText = "שם לקוח";
            columNameClient.MinimumWidth = 6;
            columNameClient.Name = "columNameClient";
            columNameClient.Width = 125;
            // 
            // columAddres
            // 
            columAddres.HeaderText = "כתובת";
            columAddres.MinimumWidth = 6;
            columAddres.Name = "columAddres";
            columAddres.Width = 125;
            // 
            // ColumnPhon
            // 
            ColumnPhon.HeaderText = "טלפון";
            ColumnPhon.Name = "ColumnPhon";
            // 
            // panelAllClient
            // 
            panelAllClient.Controls.Add(dataGridViewAllClient);
            panelAllClient.Location = new Point(36, 38);
            panelAllClient.Name = "panelAllClient";
            panelAllClient.Size = new Size(475, 361);
            panelAllClient.TabIndex = 17;
            panelAllClient.Paint += panelAllProduct_Paint;
            // 
            // updetClient
            // 
            updetClient.Location = new Point(545, 346);
            updetClient.Name = "updetClient";
            updetClient.Size = new Size(207, 53);
            updetClient.TabIndex = 16;
            updetClient.Text = "עדכון לקוח";
            updetClient.UseVisualStyleBackColor = true;
            updetClient.Click += updetClient_Click;
            // 
            // panelClientDetails
            // 
            panelClientDetails.Controls.Add(Phon);
            panelClientDetails.Controls.Add(label6);
            panelClientDetails.Controls.Add(Addres);
            panelClientDetails.Controls.Add(label4);
            panelClientDetails.Controls.Add(label3);
            panelClientDetails.Controls.Add(nameClient);
            panelClientDetails.Location = new Point(117, 143);
            panelClientDetails.Margin = new Padding(3, 2, 3, 2);
            panelClientDetails.Name = "panelClientDetails";
            panelClientDetails.Size = new Size(343, 231);
            panelClientDetails.TabIndex = 15;
            panelClientDetails.Paint += panelProductDetails_Paint;
            // 
            // Phon
            // 
            Phon.Location = new Point(177, 61);
            Phon.Name = "Phon";
            Phon.Size = new Size(97, 23);
            Phon.TabIndex = 5;
            Phon.Text = "טלפון";
            // 
            // label6
            // 
            label6.Location = new Point(74, 61);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // Addres
            // 
            Addres.Location = new Point(177, 37);
            Addres.Name = "Addres";
            Addres.Size = new Size(97, 23);
            Addres.TabIndex = 3;
            Addres.Text = "כתובת";
            // 
            // label4
            // 
            label4.Location = new Point(74, 37);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.Location = new Point(74, 13);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // nameClient
            // 
            nameClient.Location = new Point(177, 13);
            nameClient.Name = "nameClient";
            nameClient.Size = new Size(97, 23);
            nameClient.TabIndex = 0;
            nameClient.Text = ":שם לקוח";
            // 
            // panelShowClient
            // 
            panelShowClient.Controls.Add(idClient);
            panelShowClient.Controls.Add(showIdClient);
            panelShowClient.Location = new Point(117, 63);
            panelShowClient.Name = "panelShowClient";
            panelShowClient.Size = new Size(343, 75);
            panelShowClient.TabIndex = 14;
            panelShowClient.Paint += panelShowProduct_Paint;
            // 
            // idClient
            // 
            idClient.Location = new Point(243, 36);
            idClient.Name = "idClient";
            idClient.Size = new Size(95, 20);
            idClient.TabIndex = 1;
            idClient.Text = "הכנס ת.ז.";
            // 
            // showIdClient
            // 
            showIdClient.Location = new Point(31, 36);
            showIdClient.Margin = new Padding(3, 2, 3, 2);
            showIdClient.Name = "showIdClient";
            showIdClient.Size = new Size(181, 23);
            showIdClient.TabIndex = 0;
            showIdClient.KeyDown += showIdClient_KeyDown;
            // 
            // deleteClient
            // 
            deleteClient.Location = new Point(545, 264);
            deleteClient.Name = "deleteClient";
            deleteClient.Size = new Size(207, 53);
            deleteClient.TabIndex = 10;
            deleteClient.Text = "מחק לקוח";
            deleteClient.UseVisualStyleBackColor = true;
            deleteClient.Click += deleteClient_Click;
            // 
            // addClient
            // 
            addClient.Location = new Point(545, 187);
            addClient.Name = "addClient";
            addClient.Size = new Size(207, 53);
            addClient.TabIndex = 11;
            addClient.Text = "הוסף לקוח";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // AllClients
            // 
            AllClients.Location = new Point(545, 111);
            AllClients.Name = "AllClients";
            AllClients.Size = new Size(207, 53);
            AllClients.TabIndex = 12;
            AllClients.Text = "כל הלקוחות";
            AllClients.UseVisualStyleBackColor = true;
            AllClients.Click += AllClients_Click;
            // 
            // ShowClient
            // 
            ShowClient.Location = new Point(545, 37);
            ShowClient.Name = "ShowClient";
            ShowClient.Size = new Size(207, 53);
            ShowClient.TabIndex = 13;
            ShowClient.Text = "הצג לקוח";
            ShowClient.UseVisualStyleBackColor = true;
            ShowClient.Click += ShowClient_Click;
            // 
            // ClientShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAddOrUpdateClient);
            Controls.Add(panelAllClient);
            Controls.Add(updetClient);
            Controls.Add(panelClientDetails);
            Controls.Add(panelShowClient);
            Controls.Add(deleteClient);
            Controls.Add(addClient);
            Controls.Add(AllClients);
            Controls.Add(ShowClient);
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
        private DataGridViewTextBoxColumn columIdClient;
        private DataGridViewTextBoxColumn columNameClient;
        private DataGridViewTextBoxColumn columAddres;
        private DataGridViewTextBoxColumn ColumnPhon;
        private TextBox insertAddId;
        private Label addId;
    }
}