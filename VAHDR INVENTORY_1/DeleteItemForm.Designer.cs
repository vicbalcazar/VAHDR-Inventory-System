namespace VAHDR_INVENTORY_1
{
    partial class DeleteItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemForm));
            this.DeleteItemLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDeleteSKU = new System.Windows.Forms.TextBox();
            this.lblDeleteItemSku = new System.Windows.Forms.Label();
            this.DeleteItemPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelDeleteItemPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDeleteItemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteItemLbl
            // 
            this.DeleteItemLbl.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteItemLbl.Location = new System.Drawing.Point(12, 9);
            this.DeleteItemLbl.Name = "DeleteItemLbl";
            this.DeleteItemLbl.Size = new System.Drawing.Size(254, 77);
            this.DeleteItemLbl.TabIndex = 5;
            this.DeleteItemLbl.Text = "Delete Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDeleteSKU);
            this.panel1.Controls.Add(this.lblDeleteItemSku);
            this.panel1.Location = new System.Drawing.Point(31, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 132);
            this.panel1.TabIndex = 6;
            // 
            // txtDeleteSKU
            // 
            this.txtDeleteSKU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeleteSKU.Location = new System.Drawing.Point(18, 61);
            this.txtDeleteSKU.Multiline = true;
            this.txtDeleteSKU.Name = "txtDeleteSKU";
            this.txtDeleteSKU.Size = new System.Drawing.Size(162, 34);
            this.txtDeleteSKU.TabIndex = 31;
            this.txtDeleteSKU.TextChanged += new System.EventHandler(this.txtDeleteSKU_TextChanged);
            // 
            // lblDeleteItemSku
            // 
            this.lblDeleteItemSku.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteItemSku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteItemSku.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteItemSku.Location = new System.Drawing.Point(34, 20);
            this.lblDeleteItemSku.Name = "lblDeleteItemSku";
            this.lblDeleteItemSku.Size = new System.Drawing.Size(124, 38);
            this.lblDeleteItemSku.TabIndex = 30;
            this.lblDeleteItemSku.Text = "Enter SKU";
            // 
            // DeleteItemPictureBox
            // 
            this.DeleteItemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteItemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItemPictureBox.Image")));
            this.DeleteItemPictureBox.Location = new System.Drawing.Point(31, 239);
            this.DeleteItemPictureBox.Name = "DeleteItemPictureBox";
            this.DeleteItemPictureBox.Size = new System.Drawing.Size(74, 72);
            this.DeleteItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteItemPictureBox.TabIndex = 8;
            this.DeleteItemPictureBox.TabStop = false;
            this.DeleteItemPictureBox.Click += new System.EventHandler(this.DeleteItemPictureBox_Click);
            // 
            // CancelDeleteItemPictureBox
            // 
            this.CancelDeleteItemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelDeleteItemPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelDeleteItemPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelDeleteItemPictureBox.Image")));
            this.CancelDeleteItemPictureBox.Location = new System.Drawing.Point(156, 239);
            this.CancelDeleteItemPictureBox.Name = "CancelDeleteItemPictureBox";
            this.CancelDeleteItemPictureBox.Size = new System.Drawing.Size(74, 72);
            this.CancelDeleteItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelDeleteItemPictureBox.TabIndex = 9;
            this.CancelDeleteItemPictureBox.TabStop = false;
            this.CancelDeleteItemPictureBox.Click += new System.EventHandler(this.CancelDeleteItemPictureBox_Click);
            // 
            // DeleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(267, 337);
            this.Controls.Add(this.CancelDeleteItemPictureBox);
            this.Controls.Add(this.DeleteItemPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteItemLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDeleteItemPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DeleteItemLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox DeleteItemPictureBox;
        private System.Windows.Forms.PictureBox CancelDeleteItemPictureBox;
        private System.Windows.Forms.Label lblDeleteItemSku;
        public System.Windows.Forms.TextBox txtDeleteSKU;
    }
}