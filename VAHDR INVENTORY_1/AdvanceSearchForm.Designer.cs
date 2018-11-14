namespace VAHDR_INVENTORY_1
{
    partial class AdvanceSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceSearchForm));
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.pctBoxSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBoxPromotion = new System.Windows.Forms.CheckBox();
            this.txtAdvanceDate = new System.Windows.Forms.TextBox();
            this.chkBoxExpire = new System.Windows.Forms.CheckBox();
            this.chkBoxPrice = new System.Windows.Forms.CheckBox();
            this.chkBoxLow = new System.Windows.Forms.CheckBox();
            this.chkBoxDate = new System.Windows.Forms.CheckBox();
            this.CancelNewUserPicBox = new System.Windows.Forms.PictureBox();
            this.txtAdvancePrice = new System.Windows.Forms.TextBox();
            this.txtAdvanceExpire = new System.Windows.Forms.TextBox();
            this.txtAdvanceLowStock = new System.Windows.Forms.TextBox();
            this.txtAdvancePromo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNewUserPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUserLabel.Location = new System.Drawing.Point(3, 9);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(346, 75);
            this.AddUserLabel.TabIndex = 3;
            this.AddUserLabel.Text = "Advance Search";
            // 
            // pctBoxSearch
            // 
            this.pctBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxSearch.Image")));
            this.pctBoxSearch.Location = new System.Drawing.Point(30, 377);
            this.pctBoxSearch.Name = "pctBoxSearch";
            this.pctBoxSearch.Size = new System.Drawing.Size(74, 72);
            this.pctBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxSearch.TabIndex = 25;
            this.pctBoxSearch.TabStop = false;
            this.pctBoxSearch.Click += new System.EventHandler(this.pctBoxSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAdvancePromo);
            this.panel1.Controls.Add(this.txtAdvanceLowStock);
            this.panel1.Controls.Add(this.txtAdvanceExpire);
            this.panel1.Controls.Add(this.txtAdvancePrice);
            this.panel1.Controls.Add(this.chkBoxPromotion);
            this.panel1.Controls.Add(this.txtAdvanceDate);
            this.panel1.Controls.Add(this.chkBoxExpire);
            this.panel1.Controls.Add(this.chkBoxPrice);
            this.panel1.Controls.Add(this.chkBoxLow);
            this.panel1.Controls.Add(this.chkBoxDate);
            this.panel1.Location = new System.Drawing.Point(30, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 284);
            this.panel1.TabIndex = 4;
            // 
            // chkBoxPromotion
            // 
            this.chkBoxPromotion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxPromotion.Location = new System.Drawing.Point(13, 232);
            this.chkBoxPromotion.Name = "chkBoxPromotion";
            this.chkBoxPromotion.Size = new System.Drawing.Size(111, 26);
            this.chkBoxPromotion.TabIndex = 26;
            this.chkBoxPromotion.Text = "Promotion";
            this.chkBoxPromotion.UseVisualStyleBackColor = true;
            this.chkBoxPromotion.CheckedChanged += new System.EventHandler(this.chkBoxPromotion_CheckedChanged);
            // 
            // txtAdvanceDate
            // 
            this.txtAdvanceDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdvanceDate.Location = new System.Drawing.Point(133, 13);
            this.txtAdvanceDate.Multiline = true;
            this.txtAdvanceDate.Name = "txtAdvanceDate";
            this.txtAdvanceDate.Size = new System.Drawing.Size(125, 34);
            this.txtAdvanceDate.TabIndex = 25;
            this.txtAdvanceDate.TextChanged += new System.EventHandler(this.txtSearchFormInput_TextChanged);
            // 
            // chkBoxExpire
            // 
            this.chkBoxExpire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxExpire.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxExpire.Location = new System.Drawing.Point(13, 127);
            this.chkBoxExpire.Name = "chkBoxExpire";
            this.chkBoxExpire.Size = new System.Drawing.Size(111, 26);
            this.chkBoxExpire.TabIndex = 24;
            this.chkBoxExpire.Text = "Expiration";
            this.chkBoxExpire.UseVisualStyleBackColor = true;
            this.chkBoxExpire.CheckedChanged += new System.EventHandler(this.chkBoxExpire_CheckedChanged);
            // 
            // chkBoxPrice
            // 
            this.chkBoxPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxPrice.Location = new System.Drawing.Point(13, 71);
            this.chkBoxPrice.Name = "chkBoxPrice";
            this.chkBoxPrice.Size = new System.Drawing.Size(104, 26);
            this.chkBoxPrice.TabIndex = 23;
            this.chkBoxPrice.Text = "PRICE";
            this.chkBoxPrice.UseVisualStyleBackColor = true;
            this.chkBoxPrice.CheckedChanged += new System.EventHandler(this.chkBoxPrice_CheckedChanged);
            // 
            // chkBoxLow
            // 
            this.chkBoxLow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxLow.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxLow.Location = new System.Drawing.Point(13, 179);
            this.chkBoxLow.Name = "chkBoxLow";
            this.chkBoxLow.Size = new System.Drawing.Size(123, 26);
            this.chkBoxLow.TabIndex = 22;
            this.chkBoxLow.Text = "Low Stock";
            this.chkBoxLow.UseVisualStyleBackColor = true;
            this.chkBoxLow.CheckedChanged += new System.EventHandler(this.chkBoxLow_CheckedChanged);
            // 
            // chkBoxDate
            // 
            this.chkBoxDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxDate.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxDate.Location = new System.Drawing.Point(13, 13);
            this.chkBoxDate.Name = "chkBoxDate";
            this.chkBoxDate.Size = new System.Drawing.Size(104, 26);
            this.chkBoxDate.TabIndex = 21;
            this.chkBoxDate.Text = "Date";
            this.chkBoxDate.UseVisualStyleBackColor = true;
            this.chkBoxDate.CheckedChanged += new System.EventHandler(this.chkBoxDate_CheckedChanged);
            // 
            // CancelNewUserPicBox
            // 
            this.CancelNewUserPicBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelNewUserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelNewUserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelNewUserPicBox.Image")));
            this.CancelNewUserPicBox.Location = new System.Drawing.Point(246, 377);
            this.CancelNewUserPicBox.Name = "CancelNewUserPicBox";
            this.CancelNewUserPicBox.Size = new System.Drawing.Size(74, 72);
            this.CancelNewUserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelNewUserPicBox.TabIndex = 26;
            this.CancelNewUserPicBox.TabStop = false;
            this.CancelNewUserPicBox.Click += new System.EventHandler(this.CancelNewUserPicBox_Click);
            // 
            // txtAdvancePrice
            // 
            this.txtAdvancePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdvancePrice.Location = new System.Drawing.Point(133, 71);
            this.txtAdvancePrice.Multiline = true;
            this.txtAdvancePrice.Name = "txtAdvancePrice";
            this.txtAdvancePrice.Size = new System.Drawing.Size(125, 34);
            this.txtAdvancePrice.TabIndex = 27;
            this.txtAdvancePrice.TextChanged += new System.EventHandler(this.txtAdvancePrice_TextChanged);
            // 
            // txtAdvanceExpire
            // 
            this.txtAdvanceExpire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdvanceExpire.Location = new System.Drawing.Point(133, 127);
            this.txtAdvanceExpire.Multiline = true;
            this.txtAdvanceExpire.Name = "txtAdvanceExpire";
            this.txtAdvanceExpire.Size = new System.Drawing.Size(125, 34);
            this.txtAdvanceExpire.TabIndex = 28;
            this.txtAdvanceExpire.TextChanged += new System.EventHandler(this.txtAdvanceExpire_TextChanged);
            // 
            // txtAdvanceLowStock
            // 
            this.txtAdvanceLowStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdvanceLowStock.Location = new System.Drawing.Point(133, 179);
            this.txtAdvanceLowStock.Multiline = true;
            this.txtAdvanceLowStock.Name = "txtAdvanceLowStock";
            this.txtAdvanceLowStock.Size = new System.Drawing.Size(125, 34);
            this.txtAdvanceLowStock.TabIndex = 29;
            this.txtAdvanceLowStock.TextChanged += new System.EventHandler(this.txtAdvanceLowStock_TextChanged);
            // 
            // txtAdvancePromo
            // 
            this.txtAdvancePromo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdvancePromo.Location = new System.Drawing.Point(133, 232);
            this.txtAdvancePromo.Multiline = true;
            this.txtAdvancePromo.Name = "txtAdvancePromo";
            this.txtAdvancePromo.Size = new System.Drawing.Size(125, 34);
            this.txtAdvancePromo.TabIndex = 27;
            this.txtAdvancePromo.TextChanged += new System.EventHandler(this.txtAdvancePromo_TextChanged);
            // 
            // AdvanceSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 471);
            this.Controls.Add(this.CancelNewUserPicBox);
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddUserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvanceSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Search";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNewUserPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.PictureBox pctBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CancelNewUserPicBox;
        private System.Windows.Forms.CheckBox chkBoxExpire;
        private System.Windows.Forms.CheckBox chkBoxPrice;
        private System.Windows.Forms.CheckBox chkBoxLow;
        private System.Windows.Forms.CheckBox chkBoxDate;
        public System.Windows.Forms.TextBox txtAdvanceDate;
        private System.Windows.Forms.CheckBox chkBoxPromotion;
        public System.Windows.Forms.TextBox txtAdvancePromo;
        public System.Windows.Forms.TextBox txtAdvanceLowStock;
        public System.Windows.Forms.TextBox txtAdvanceExpire;
        public System.Windows.Forms.TextBox txtAdvancePrice;
    }
}