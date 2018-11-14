namespace VAHDR_INVENTORY_1
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.DeleteUserLabel = new System.Windows.Forms.Label();
            this.CancelDeleteUserPictureBox = new System.Windows.Forms.PictureBox();
            this.SendHomePictureBox = new System.Windows.Forms.PictureBox();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.txtDeleteEmployeeID = new System.Windows.Forms.TextBox();
            this.lblDeleteUserEnterID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDeleteUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendHomePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListBox
            // 
            this.UserListBox.BackColor = System.Drawing.Color.LightGray;
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 18;
            this.UserListBox.Location = new System.Drawing.Point(17, 55);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(403, 130);
            this.UserListBox.TabIndex = 0;
            // 
            // DeleteUserLabel
            // 
            this.DeleteUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeleteUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteUserLabel.Location = new System.Drawing.Point(117, 9);
            this.DeleteUserLabel.Name = "DeleteUserLabel";
            this.DeleteUserLabel.Size = new System.Drawing.Size(254, 77);
            this.DeleteUserLabel.TabIndex = 4;
            this.DeleteUserLabel.Text = "Delete User";
            // 
            // CancelDeleteUserPictureBox
            // 
            this.CancelDeleteUserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelDeleteUserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelDeleteUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelDeleteUserPictureBox.Image")));
            this.CancelDeleteUserPictureBox.Location = new System.Drawing.Point(387, 335);
            this.CancelDeleteUserPictureBox.Name = "CancelDeleteUserPictureBox";
            this.CancelDeleteUserPictureBox.Size = new System.Drawing.Size(74, 72);
            this.CancelDeleteUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelDeleteUserPictureBox.TabIndex = 6;
            this.CancelDeleteUserPictureBox.TabStop = false;
            this.CancelDeleteUserPictureBox.Click += new System.EventHandler(this.CancelDeleteUserPictureBox_Click);
            // 
            // SendHomePictureBox
            // 
            this.SendHomePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SendHomePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendHomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SendHomePictureBox.Image")));
            this.SendHomePictureBox.Location = new System.Drawing.Point(20, 335);
            this.SendHomePictureBox.Name = "SendHomePictureBox";
            this.SendHomePictureBox.Size = new System.Drawing.Size(74, 72);
            this.SendHomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SendHomePictureBox.TabIndex = 7;
            this.SendHomePictureBox.TabStop = false;
            this.SendHomePictureBox.Click += new System.EventHandler(this.SendHomePictureBox_Click);
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteName.Location = new System.Drawing.Point(33, 14);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(247, 38);
            this.lblDeleteName.TabIndex = 22;
            this.lblDeleteName.Text = "Employee Information";
            // 
            // txtDeleteEmployeeID
            // 
            this.txtDeleteEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeleteEmployeeID.Location = new System.Drawing.Point(258, 191);
            this.txtDeleteEmployeeID.Multiline = true;
            this.txtDeleteEmployeeID.Name = "txtDeleteEmployeeID";
            this.txtDeleteEmployeeID.Size = new System.Drawing.Size(162, 34);
            this.txtDeleteEmployeeID.TabIndex = 28;
            this.txtDeleteEmployeeID.TextChanged += new System.EventHandler(this.txtDeleteEmployeeID_TextChanged);
            // 
            // lblDeleteUserEnterID
            // 
            this.lblDeleteUserEnterID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteUserEnterID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUserEnterID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteUserEnterID.Location = new System.Drawing.Point(155, 188);
            this.lblDeleteUserEnterID.Name = "lblDeleteUserEnterID";
            this.lblDeleteUserEnterID.Size = new System.Drawing.Size(97, 38);
            this.lblDeleteUserEnterID.TabIndex = 29;
            this.lblDeleteUserEnterID.Text = "Enter ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.UserListBox);
            this.panel1.Controls.Add(this.lblDeleteName);
            this.panel1.Controls.Add(this.lblDeleteUserEnterID);
            this.panel1.Controls.Add(this.txtDeleteEmployeeID);
            this.panel1.Location = new System.Drawing.Point(20, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 247);
            this.panel1.TabIndex = 30;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendHomePictureBox);
            this.Controls.Add(this.CancelDeleteUserPictureBox);
            this.Controls.Add(this.DeleteUserLabel);
            this.Name = "DeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)(this.CancelDeleteUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendHomePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.Label DeleteUserLabel;
        private System.Windows.Forms.PictureBox CancelDeleteUserPictureBox;
        private System.Windows.Forms.PictureBox SendHomePictureBox;
        private System.Windows.Forms.Label lblDeleteName;
        public System.Windows.Forms.TextBox txtDeleteEmployeeID;
        private System.Windows.Forms.Label lblDeleteUserEnterID;
        private System.Windows.Forms.Panel panel1;
    }
}