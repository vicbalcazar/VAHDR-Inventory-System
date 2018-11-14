namespace VAHDR_INVENTORY_1
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            this.DeleteUserLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchEmployeeID = new System.Windows.Forms.TextBox();
            this.lblDeleteUserEnterID = new System.Windows.Forms.Label();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.CancelEditUserPictureBox = new System.Windows.Forms.PictureBox();
            this.txtChangeFirstName = new System.Windows.Forms.TextBox();
            this.txtChangeLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditUserPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelEditUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteUserLabel
            // 
            this.DeleteUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUserLabel.Location = new System.Drawing.Point(221, 9);
            this.DeleteUserLabel.Name = "DeleteUserLabel";
            this.DeleteUserLabel.Size = new System.Drawing.Size(254, 77);
            this.DeleteUserLabel.TabIndex = 5;
            this.DeleteUserLabel.Text = "Edit User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearchEmployeeID);
            this.panel1.Controls.Add(this.lblDeleteUserEnterID);
            this.panel1.Controls.Add(this.UserListBox);
            this.panel1.Location = new System.Drawing.Point(28, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 240);
            this.panel1.TabIndex = 31;
            // 
            // txtSearchEmployeeID
            // 
            this.txtSearchEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchEmployeeID.Location = new System.Drawing.Point(494, 189);
            this.txtSearchEmployeeID.Multiline = true;
            this.txtSearchEmployeeID.Name = "txtSearchEmployeeID";
            this.txtSearchEmployeeID.Size = new System.Drawing.Size(162, 34);
            this.txtSearchEmployeeID.TabIndex = 31;
            this.txtSearchEmployeeID.TextChanged += new System.EventHandler(this.txtDeleteEmployeeID_TextChanged);
            // 
            // lblDeleteUserEnterID
            // 
            this.lblDeleteUserEnterID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteUserEnterID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUserEnterID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteUserEnterID.Location = new System.Drawing.Point(391, 189);
            this.lblDeleteUserEnterID.Name = "lblDeleteUserEnterID";
            this.lblDeleteUserEnterID.Size = new System.Drawing.Size(97, 38);
            this.lblDeleteUserEnterID.TabIndex = 30;
            this.lblDeleteUserEnterID.Text = "Enter ID";
            // 
            // UserListBox
            // 
            this.UserListBox.BackColor = System.Drawing.Color.LightGray;
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 18;
            this.UserListBox.Location = new System.Drawing.Point(17, 17);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(639, 166);
            this.UserListBox.TabIndex = 0;
            // 
            // CancelEditUserPictureBox
            // 
            this.CancelEditUserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelEditUserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelEditUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelEditUserPictureBox.Image")));
            this.CancelEditUserPictureBox.Location = new System.Drawing.Point(633, 387);
            this.CancelEditUserPictureBox.Name = "CancelEditUserPictureBox";
            this.CancelEditUserPictureBox.Size = new System.Drawing.Size(74, 72);
            this.CancelEditUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelEditUserPictureBox.TabIndex = 32;
            this.CancelEditUserPictureBox.TabStop = false;
            this.CancelEditUserPictureBox.Click += new System.EventHandler(this.CancelDeleteUserPictureBox_Click);
            // 
            // txtChangeFirstName
            // 
            this.txtChangeFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChangeFirstName.Location = new System.Drawing.Point(356, 326);
            this.txtChangeFirstName.Multiline = true;
            this.txtChangeFirstName.Name = "txtChangeFirstName";
            this.txtChangeFirstName.Size = new System.Drawing.Size(162, 34);
            this.txtChangeFirstName.TabIndex = 33;
            this.txtChangeFirstName.TextChanged += new System.EventHandler(this.txtChangeFirstName_TextChanged);
            // 
            // txtChangeLastName
            // 
            this.txtChangeLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChangeLastName.Location = new System.Drawing.Point(356, 377);
            this.txtChangeLastName.Multiline = true;
            this.txtChangeLastName.Name = "txtChangeLastName";
            this.txtChangeLastName.Size = new System.Drawing.Size(162, 34);
            this.txtChangeLastName.TabIndex = 34;
            this.txtChangeLastName.TextChanged += new System.EventHandler(this.txtChangeLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(222, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(222, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 34);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name";
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChangePassword.Location = new System.Drawing.Point(356, 426);
            this.txtChangePassword.Multiline = true;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(162, 34);
            this.txtChangePassword.TabIndex = 37;
            this.txtChangePassword.TextChanged += new System.EventHandler(this.txtChangePassword_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(222, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password";
            // 
            // EditUserPictureBox
            // 
            this.EditUserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EditUserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditUserPictureBox.Image")));
            this.EditUserPictureBox.Location = new System.Drawing.Point(28, 387);
            this.EditUserPictureBox.Name = "EditUserPictureBox";
            this.EditUserPictureBox.Size = new System.Drawing.Size(74, 72);
            this.EditUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditUserPictureBox.TabIndex = 39;
            this.EditUserPictureBox.TabStop = false;
            this.EditUserPictureBox.Click += new System.EventHandler(this.EditUserPictureBox_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Controls.Add(this.EditUserPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChangeLastName);
            this.Controls.Add(this.txtChangeFirstName);
            this.Controls.Add(this.CancelEditUserPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteUserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelEditUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteUserLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.PictureBox CancelEditUserPictureBox;
        private System.Windows.Forms.Label lblDeleteUserEnterID;
        public System.Windows.Forms.TextBox txtSearchEmployeeID;
        public System.Windows.Forms.TextBox txtChangeFirstName;
        public System.Windows.Forms.TextBox txtChangeLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox EditUserPictureBox;
    }
}