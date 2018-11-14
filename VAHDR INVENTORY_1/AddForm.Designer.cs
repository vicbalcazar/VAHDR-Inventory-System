namespace VAHDR_INVENTORY_1
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtAddExpiration = new System.Windows.Forms.TextBox();
            this.lblAddDiscount = new System.Windows.Forms.Label();
            this.txtAddDate = new System.Windows.Forms.TextBox();
            this.lblAddExpire = new System.Windows.Forms.Label();
            this.txtAddSku = new System.Windows.Forms.TextBox();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddSku = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctBoxAddExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAddExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtAddExpiration);
            this.panel1.Controls.Add(this.lblAddDiscount);
            this.panel1.Controls.Add(this.txtAddDate);
            this.panel1.Controls.Add(this.lblAddExpire);
            this.panel1.Controls.Add(this.txtAddSku);
            this.panel1.Controls.Add(this.lblAddDate);
            this.panel1.Controls.Add(this.txtAddCategory);
            this.panel1.Controls.Add(this.txtAddItem);
            this.panel1.Controls.Add(this.txtAddPrice);
            this.panel1.Controls.Add(this.txtAddCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAddPrice);
            this.panel1.Controls.Add(this.lblAddItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAddSku);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 267);
            this.panel1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(252, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 36);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Promotion";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiscount.Location = new System.Drawing.Point(388, 107);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(120, 34);
            this.txtDiscount.TabIndex = 18;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtAddExpiration
            // 
            this.txtAddExpiration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddExpiration.Location = new System.Drawing.Point(388, 58);
            this.txtAddExpiration.Multiline = true;
            this.txtAddExpiration.Name = "txtAddExpiration";
            this.txtAddExpiration.Size = new System.Drawing.Size(120, 34);
            this.txtAddExpiration.TabIndex = 16;
            this.txtAddExpiration.TextChanged += new System.EventHandler(this.txtAddExpiration_TextChanged);
            // 
            // lblAddDiscount
            // 
            this.lblAddDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblAddDiscount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDiscount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddDiscount.Location = new System.Drawing.Point(248, 107);
            this.lblAddDiscount.Name = "lblAddDiscount";
            this.lblAddDiscount.Size = new System.Drawing.Size(113, 38);
            this.lblAddDiscount.TabIndex = 9;
            this.lblAddDiscount.Text = "Discount";
            // 
            // txtAddDate
            // 
            this.txtAddDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddDate.Location = new System.Drawing.Point(388, 11);
            this.txtAddDate.Multiline = true;
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.Size = new System.Drawing.Size(120, 34);
            this.txtAddDate.TabIndex = 15;
            this.txtAddDate.TextChanged += new System.EventHandler(this.txtAddDate_TextChanged);
            // 
            // lblAddExpire
            // 
            this.lblAddExpire.BackColor = System.Drawing.Color.Transparent;
            this.lblAddExpire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddExpire.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddExpire.Location = new System.Drawing.Point(246, 58);
            this.lblAddExpire.Name = "lblAddExpire";
            this.lblAddExpire.Size = new System.Drawing.Size(135, 38);
            this.lblAddExpire.TabIndex = 7;
            this.lblAddExpire.Text = "Expiration";
            // 
            // txtAddSku
            // 
            this.txtAddSku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddSku.Location = new System.Drawing.Point(122, 11);
            this.txtAddSku.Multiline = true;
            this.txtAddSku.Name = "txtAddSku";
            this.txtAddSku.Size = new System.Drawing.Size(120, 34);
            this.txtAddSku.TabIndex = 14;
            this.txtAddSku.TextChanged += new System.EventHandler(this.txtAddSku_TextChanged);
            // 
            // lblAddDate
            // 
            this.lblAddDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddDate.Location = new System.Drawing.Point(248, 7);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(113, 38);
            this.lblAddDate.TabIndex = 6;
            this.lblAddDate.Text = "Date";
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddCategory.Location = new System.Drawing.Point(121, 58);
            this.txtAddCategory.Multiline = true;
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(120, 34);
            this.txtAddCategory.TabIndex = 13;
            this.txtAddCategory.TextChanged += new System.EventHandler(this.txtAddCategory_TextChanged);
            // 
            // txtAddItem
            // 
            this.txtAddItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddItem.Location = new System.Drawing.Point(122, 107);
            this.txtAddItem.Multiline = true;
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(120, 34);
            this.txtAddItem.TabIndex = 12;
            this.txtAddItem.TextChanged += new System.EventHandler(this.txtAddItem_TextChanged);
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddPrice.Location = new System.Drawing.Point(122, 162);
            this.txtAddPrice.Multiline = true;
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(120, 34);
            this.txtAddPrice.TabIndex = 11;
            this.txtAddPrice.TextChanged += new System.EventHandler(this.txtAddPrice_TextChanged);
            // 
            // txtAddCount
            // 
            this.txtAddCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddCount.Location = new System.Drawing.Point(122, 217);
            this.txtAddCount.Multiline = true;
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(120, 34);
            this.txtAddCount.TabIndex = 10;
            this.txtAddCount.TextChanged += new System.EventHandler(this.txtAddCount_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddPrice.Location = new System.Drawing.Point(3, 162);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(113, 38);
            this.lblAddPrice.TabIndex = 5;
            this.lblAddPrice.Text = "Price";
            // 
            // lblAddItemName
            // 
            this.lblAddItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItemName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddItemName.Location = new System.Drawing.Point(3, 107);
            this.lblAddItemName.Name = "lblAddItemName";
            this.lblAddItemName.Size = new System.Drawing.Size(113, 38);
            this.lblAddItemName.TabIndex = 4;
            this.lblAddItemName.Text = "Item";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // lblAddSku
            // 
            this.lblAddSku.BackColor = System.Drawing.Color.Transparent;
            this.lblAddSku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSku.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddSku.Location = new System.Drawing.Point(3, 11);
            this.lblAddSku.Name = "lblAddSku";
            this.lblAddSku.Size = new System.Drawing.Size(113, 38);
            this.lblAddSku.TabIndex = 1;
            this.lblAddSku.Text = "SKU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctBoxAddExit
            // 
            this.pctBoxAddExit.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxAddExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBoxAddExit.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxAddExit.Image")));
            this.pctBoxAddExit.Location = new System.Drawing.Point(448, 377);
            this.pctBoxAddExit.Name = "pctBoxAddExit";
            this.pctBoxAddExit.Size = new System.Drawing.Size(74, 72);
            this.pctBoxAddExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxAddExit.TabIndex = 4;
            this.pctBoxAddExit.TabStop = false;
            this.pctBoxAddExit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(545, 461);
            this.Controls.Add(this.pctBoxAddExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAHDR Inventory System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAddExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddSku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddItemName;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblAddExpire;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtAddExpiration;
        private System.Windows.Forms.Label lblAddDiscount;
        private System.Windows.Forms.TextBox txtAddDate;
        private System.Windows.Forms.TextBox txtAddSku;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctBoxAddExit;
    }
}