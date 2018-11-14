namespace VAHDR_INVENTORY_1
{
    partial class RestockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockForm));
            this.RestockItemLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRestockSKU = new System.Windows.Forms.TextBox();
            this.lblRestockItemSku = new System.Windows.Forms.Label();
            this.AddRestockLbl = new System.Windows.Forms.Label();
            this.RestockAmountTxtBox = new System.Windows.Forms.TextBox();
            this.RestockItemPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelRestockItemPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestockItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRestockItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RestockItemLbl
            // 
            this.RestockItemLbl.BackColor = System.Drawing.Color.Transparent;
            this.RestockItemLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockItemLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.RestockItemLbl.Location = new System.Drawing.Point(24, 27);
            this.RestockItemLbl.Name = "RestockItemLbl";
            this.RestockItemLbl.Size = new System.Drawing.Size(276, 77);
            this.RestockItemLbl.TabIndex = 6;
            this.RestockItemLbl.Text = "Restock Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RestockAmountTxtBox);
            this.panel1.Controls.Add(this.AddRestockLbl);
            this.panel1.Controls.Add(this.txtRestockSKU);
            this.panel1.Controls.Add(this.lblRestockItemSku);
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 141);
            this.panel1.TabIndex = 7;
            // 
            // txtRestockSKU
            // 
            this.txtRestockSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRestockSKU.Location = new System.Drawing.Point(119, 20);
            this.txtRestockSKU.Multiline = true;
            this.txtRestockSKU.Name = "txtRestockSKU";
            this.txtRestockSKU.Size = new System.Drawing.Size(114, 34);
            this.txtRestockSKU.TabIndex = 31;
            this.txtRestockSKU.TextChanged += new System.EventHandler(this.txtRestockSKU_TextChanged);
            // 
            // lblRestockItemSku
            // 
            this.lblRestockItemSku.BackColor = System.Drawing.Color.Transparent;
            this.lblRestockItemSku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestockItemSku.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestockItemSku.Location = new System.Drawing.Point(14, 20);
            this.lblRestockItemSku.Name = "lblRestockItemSku";
            this.lblRestockItemSku.Size = new System.Drawing.Size(99, 38);
            this.lblRestockItemSku.TabIndex = 30;
            this.lblRestockItemSku.Text = "SKU";
            // 
            // AddRestockLbl
            // 
            this.AddRestockLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddRestockLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRestockLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRestockLbl.Location = new System.Drawing.Point(14, 74);
            this.AddRestockLbl.Name = "AddRestockLbl";
            this.AddRestockLbl.Size = new System.Drawing.Size(99, 38);
            this.AddRestockLbl.TabIndex = 32;
            this.AddRestockLbl.Text = "Amount";
            // 
            // RestockAmountTxtBox
            // 
            this.RestockAmountTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RestockAmountTxtBox.Location = new System.Drawing.Point(119, 74);
            this.RestockAmountTxtBox.Multiline = true;
            this.RestockAmountTxtBox.Name = "RestockAmountTxtBox";
            this.RestockAmountTxtBox.Size = new System.Drawing.Size(114, 34);
            this.RestockAmountTxtBox.TabIndex = 33;
            this.RestockAmountTxtBox.TextChanged += new System.EventHandler(this.RestockAmountTxtBox_TextChanged);
            // 
            // RestockItemPictureBox
            // 
            this.RestockItemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RestockItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RestockItemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RestockItemPictureBox.Image")));
            this.RestockItemPictureBox.Location = new System.Drawing.Point(20, 241);
            this.RestockItemPictureBox.Name = "RestockItemPictureBox";
            this.RestockItemPictureBox.Size = new System.Drawing.Size(74, 72);
            this.RestockItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestockItemPictureBox.TabIndex = 9;
            this.RestockItemPictureBox.TabStop = false;
            this.RestockItemPictureBox.Click += new System.EventHandler(this.RestockItemPictureBox_Click);
            // 
            // CancelRestockItemPictureBox
            // 
            this.CancelRestockItemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelRestockItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelRestockItemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelRestockItemPictureBox.Image")));
            this.CancelRestockItemPictureBox.Location = new System.Drawing.Point(216, 241);
            this.CancelRestockItemPictureBox.Name = "CancelRestockItemPictureBox";
            this.CancelRestockItemPictureBox.Size = new System.Drawing.Size(74, 72);
            this.CancelRestockItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelRestockItemPictureBox.TabIndex = 10;
            this.CancelRestockItemPictureBox.TabStop = false;
            this.CancelRestockItemPictureBox.Click += new System.EventHandler(this.CancelRestockItemPictureBox_Click);
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(312, 337);
            this.Controls.Add(this.CancelRestockItemPictureBox);
            this.Controls.Add(this.RestockItemPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RestockItemLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestockItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRestockItemPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RestockItemLbl;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtRestockSKU;
        private System.Windows.Forms.Label lblRestockItemSku;
        public System.Windows.Forms.TextBox RestockAmountTxtBox;
        private System.Windows.Forms.Label AddRestockLbl;
        private System.Windows.Forms.PictureBox RestockItemPictureBox;
        private System.Windows.Forms.PictureBox CancelRestockItemPictureBox;
    }
}