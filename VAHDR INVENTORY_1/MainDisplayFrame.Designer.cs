namespace VAHDR_INVENTORY_1
{
    partial class MainDisplayFrame
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
        /// InitializeComponent().  Please do not modify this portion of the
        /// code. This is the design.
        /// - Hieu
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplayFrame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menustripMainDisplay = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctBoxAlert = new System.Windows.Forms.PictureBox();
            this.pctBoxRestock = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkBoxItem = new System.Windows.Forms.CheckBox();
            this.chkBoxCategory = new System.Windows.Forms.CheckBox();
            this.chkBoxSKU = new System.Windows.Forms.CheckBox();
            this.txtSearchFormInput = new System.Windows.Forms.TextBox();
            this.pctBoxSearch = new System.Windows.Forms.PictureBox();
            this.lblRestock = new System.Windows.Forms.Label();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menustripMainDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRestock)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menustripMainDisplay
            // 
            this.menustripMainDisplay.AutoSize = false;
            this.menustripMainDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menustripMainDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menustripMainDisplay.BackgroundImage")));
            this.menustripMainDisplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menustripMainDisplay.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menustripMainDisplay.Location = new System.Drawing.Point(0, 0);
            this.menustripMainDisplay.Name = "menustripMainDisplay";
            this.menustripMainDisplay.Size = new System.Drawing.Size(1264, 31);
            this.menustripMainDisplay.TabIndex = 1;
            this.menustripMainDisplay.Text = "menuStrip1";
            this.menustripMainDisplay.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menustripMainDisplay_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DimGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.printReportToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printReportToolStripMenuItem.BackgroundImage")));
            this.printReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            this.printReportToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.printReportToolStripMenuItem.Text = "Print Report";
            this.printReportToolStripMenuItem.Click += new System.EventHandler(this.printReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.BackgroundImage")));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchUserToolStripMenuItem,
            this.newUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.editUserToolStripMenuItem});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.accountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // switchUserToolStripMenuItem
            // 
            this.switchUserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchUserToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchUserToolStripMenuItem.BackgroundImage")));
            this.switchUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.switchUserToolStripMenuItem.Name = "switchUserToolStripMenuItem";
            this.switchUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.switchUserToolStripMenuItem.Text = "Switch User";
            this.switchUserToolStripMenuItem.Click += new System.EventHandler(this.switchUserToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newUserToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newUserToolStripMenuItem.BackgroundImage")));
            this.newUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.BackgroundImage")));
            this.deleteUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editUserToolStripMenuItem.BackgroundImage")));
            this.editUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(273, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 510);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdvancedSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 349);
            this.panel1.TabIndex = 4;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdvancedSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnAdvancedSearch.Image")));
            this.btnAdvancedSearch.Location = new System.Drawing.Point(-2, -2);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(224, 95);
            this.btnAdvancedSearch.TabIndex = 10;
            this.btnAdvancedSearch.Text = "Sale            >";
            this.btnAdvancedSearch.UseVisualStyleBackColor = true;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(-2, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 91);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "View          >";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(-2, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 86);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete       >";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(-2, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 95);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add            >";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 166);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pctBoxAlert
            // 
            this.pctBoxAlert.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxAlert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxAlert.BackgroundImage")));
            this.pctBoxAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBoxAlert.Location = new System.Drawing.Point(420, 68);
            this.pctBoxAlert.Name = "pctBoxAlert";
            this.pctBoxAlert.Size = new System.Drawing.Size(132, 113);
            this.pctBoxAlert.TabIndex = 6;
            this.pctBoxAlert.TabStop = false;
            this.pctBoxAlert.Click += new System.EventHandler(this.pctBoxAlert_Click);
            // 
            // pctBoxRestock
            // 
            this.pctBoxRestock.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxRestock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBoxRestock.BackgroundImage")));
            this.pctBoxRestock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctBoxRestock.Location = new System.Drawing.Point(273, 68);
            this.pctBoxRestock.Name = "pctBoxRestock";
            this.pctBoxRestock.Size = new System.Drawing.Size(132, 113);
            this.pctBoxRestock.TabIndex = 7;
            this.pctBoxRestock.TabStop = false;
            this.pctBoxRestock.Click += new System.EventHandler(this.pctBoxRestock_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chkBoxItem);
            this.panel2.Controls.Add(this.chkBoxCategory);
            this.panel2.Controls.Add(this.chkBoxSKU);
            this.panel2.Controls.Add(this.txtSearchFormInput);
            this.panel2.Location = new System.Drawing.Point(12, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 138);
            this.panel2.TabIndex = 8;
            // 
            // chkBoxItem
            // 
            this.chkBoxItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic);
            this.chkBoxItem.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxItem.Location = new System.Drawing.Point(13, 65);
            this.chkBoxItem.Name = "chkBoxItem";
            this.chkBoxItem.Size = new System.Drawing.Size(114, 19);
            this.chkBoxItem.TabIndex = 22;
            this.chkBoxItem.Text = "ITEM";
            this.chkBoxItem.UseVisualStyleBackColor = true;
            this.chkBoxItem.CheckedChanged += new System.EventHandler(this.chkBoxItem_CheckedChanged);
            // 
            // chkBoxCategory
            // 
            this.chkBoxCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic);
            this.chkBoxCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxCategory.Location = new System.Drawing.Point(13, 35);
            this.chkBoxCategory.Name = "chkBoxCategory";
            this.chkBoxCategory.Size = new System.Drawing.Size(131, 24);
            this.chkBoxCategory.TabIndex = 21;
            this.chkBoxCategory.Text = "CATEGORY";
            this.chkBoxCategory.UseVisualStyleBackColor = true;
            this.chkBoxCategory.CheckedChanged += new System.EventHandler(this.chkBoxCategory_CheckedChanged);
            // 
            // chkBoxSKU
            // 
            this.chkBoxSKU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSKU.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBoxSKU.Location = new System.Drawing.Point(13, 3);
            this.chkBoxSKU.Name = "chkBoxSKU";
            this.chkBoxSKU.Size = new System.Drawing.Size(104, 26);
            this.chkBoxSKU.TabIndex = 20;
            this.chkBoxSKU.Text = "SKU";
            this.chkBoxSKU.UseVisualStyleBackColor = true;
            this.chkBoxSKU.CheckedChanged += new System.EventHandler(this.chkBoxSKU_CheckedChanged);
            // 
            // txtSearchFormInput
            // 
            this.txtSearchFormInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchFormInput.Location = new System.Drawing.Point(13, 90);
            this.txtSearchFormInput.Multiline = true;
            this.txtSearchFormInput.Name = "txtSearchFormInput";
            this.txtSearchFormInput.Size = new System.Drawing.Size(104, 34);
            this.txtSearchFormInput.TabIndex = 15;
            this.txtSearchFormInput.TextChanged += new System.EventHandler(this.txtSearchFormInput_TextChanged);
            // 
            // pctBoxSearch
            // 
            this.pctBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxSearch.Image")));
            this.pctBoxSearch.Location = new System.Drawing.Point(157, 273);
            this.pctBoxSearch.Name = "pctBoxSearch";
            this.pctBoxSearch.Size = new System.Drawing.Size(74, 72);
            this.pctBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxSearch.TabIndex = 9;
            this.pctBoxSearch.TabStop = false;
            this.pctBoxSearch.Click += new System.EventHandler(this.pctBoxSearch_Click);
            // 
            // lblRestock
            // 
            this.lblRestock.AutoSize = true;
            this.lblRestock.BackColor = System.Drawing.Color.Transparent;
            this.lblRestock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestock.Location = new System.Drawing.Point(302, 167);
            this.lblRestock.Name = "lblRestock";
            this.lblRestock.Size = new System.Drawing.Size(92, 24);
            this.lblRestock.TabIndex = 10;
            this.lblRestock.Text = "Restock";
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.BackColor = System.Drawing.Color.Transparent;
            this.lblAlerts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerts.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAlerts.Location = new System.Drawing.Point(455, 167);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(59, 24);
            this.lblAlerts.TabIndex = 11;
            this.lblAlerts.Text = "Alert";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1085, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 113);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1124, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(161, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quick";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(154, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Search";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MainDisplayFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 743);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAlerts);
            this.Controls.Add(this.lblRestock);
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pctBoxRestock);
            this.Controls.Add(this.pctBoxAlert);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menustripMainDisplay);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menustripMainDisplay;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDisplayFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VAHDR Inventory System";
            this.menustripMainDisplay.ResumeLayout(false);
            this.menustripMainDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxRestock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustripMainDisplay;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem switchUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctBoxAlert;
        private System.Windows.Forms.PictureBox pctBoxRestock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkBoxItem;
        private System.Windows.Forms.CheckBox chkBoxCategory;
        private System.Windows.Forms.CheckBox chkBoxSKU;
        public System.Windows.Forms.TextBox txtSearchFormInput;
        private System.Windows.Forms.PictureBox pctBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Label lblRestock;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReportToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}