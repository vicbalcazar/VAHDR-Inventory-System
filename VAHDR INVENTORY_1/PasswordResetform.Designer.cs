namespace VAHDR_INVENTORY_1
{
    partial class PasswordResetform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetform));
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.txtSearchEmployeeID = new System.Windows.Forms.TextBox();
            this.lblDeleteUserEnterID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.EditUserPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelResetPasswordBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelResetPasswordBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResetPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResetPassword.Location = new System.Drawing.Point(45, 9);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(265, 39);
            this.lblResetPassword.TabIndex = 0;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // txtSearchEmployeeID
            // 
            this.txtSearchEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchEmployeeID.Location = new System.Drawing.Point(158, 76);
            this.txtSearchEmployeeID.Multiline = true;
            this.txtSearchEmployeeID.Name = "txtSearchEmployeeID";
            this.txtSearchEmployeeID.Size = new System.Drawing.Size(162, 34);
            this.txtSearchEmployeeID.TabIndex = 33;
            this.txtSearchEmployeeID.TextChanged += new System.EventHandler(this.txtSearchEmployeeID_TextChanged);
            // 
            // lblDeleteUserEnterID
            // 
            this.lblDeleteUserEnterID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteUserEnterID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteUserEnterID.ForeColor = System.Drawing.Color.White;
            this.lblDeleteUserEnterID.Location = new System.Drawing.Point(26, 76);
            this.lblDeleteUserEnterID.Name = "lblDeleteUserEnterID";
            this.lblDeleteUserEnterID.Size = new System.Drawing.Size(109, 38);
            this.lblDeleteUserEnterID.TabIndex = 32;
            this.lblDeleteUserEnterID.Text = "Enter ID";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Password";
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Location = new System.Drawing.Point(158, 116);
            this.txtChangePassword.Multiline = true;
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(162, 34);
            this.txtChangePassword.TabIndex = 39;
            this.txtChangePassword.TextChanged += new System.EventHandler(this.txtChangePassword_TextChanged);
            // 
            // EditUserPictureBox
            // 
            this.EditUserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EditUserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditUserPictureBox.Image")));
            this.EditUserPictureBox.Location = new System.Drawing.Point(30, 176);
            this.EditUserPictureBox.Name = "EditUserPictureBox";
            this.EditUserPictureBox.Size = new System.Drawing.Size(74, 72);
            this.EditUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditUserPictureBox.TabIndex = 41;
            this.EditUserPictureBox.TabStop = false;
            this.EditUserPictureBox.Click += new System.EventHandler(this.EditUserPictureBox_Click);
            // 
            // CancelResetPasswordBox
            // 
            this.CancelResetPasswordBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelResetPasswordBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelResetPasswordBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelResetPasswordBox.Image")));
            this.CancelResetPasswordBox.Location = new System.Drawing.Point(246, 176);
            this.CancelResetPasswordBox.Name = "CancelResetPasswordBox";
            this.CancelResetPasswordBox.Size = new System.Drawing.Size(74, 72);
            this.CancelResetPasswordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelResetPasswordBox.TabIndex = 42;
            this.CancelResetPasswordBox.TabStop = false;
            this.CancelResetPasswordBox.Click += new System.EventHandler(this.CancelResetPasswordBox_Click);
            // 
            // PasswordResetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 271);
            this.Controls.Add(this.CancelResetPasswordBox);
            this.Controls.Add(this.EditUserPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChangePassword);
            this.Controls.Add(this.txtSearchEmployeeID);
            this.Controls.Add(this.lblDeleteUserEnterID);
            this.Controls.Add(this.lblResetPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordResetform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)(this.EditUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelResetPasswordBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResetPassword;
        public System.Windows.Forms.TextBox txtSearchEmployeeID;
        private System.Windows.Forms.Label lblDeleteUserEnterID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.PictureBox EditUserPictureBox;
        private System.Windows.Forms.PictureBox CancelResetPasswordBox;
    }
}