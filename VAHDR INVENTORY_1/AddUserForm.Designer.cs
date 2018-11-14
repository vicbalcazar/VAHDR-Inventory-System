namespace VAHDR_INVENTORY_1
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.AddUserLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.lblAddUserName = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.CancelNewUserPicBox = new System.Windows.Forms.PictureBox();
            this.AddNewUserPicBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNewUserPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUserPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserLabel
            // 
            this.AddUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddUserLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddUserLabel.Location = new System.Drawing.Point(48, 9);
            this.AddUserLabel.Name = "AddUserLabel";
            this.AddUserLabel.Size = new System.Drawing.Size(378, 75);
            this.AddUserLabel.TabIndex = 2;
            this.AddUserLabel.Text = "Create New User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lblAddLastName);
            this.panel1.Controls.Add(this.lblAddFirstName);
            this.panel1.Controls.Add(this.lblAddPassword);
            this.panel1.Controls.Add(this.lblAddUserName);
            this.panel1.Controls.Add(this.txtAddLastName);
            this.panel1.Controls.Add(this.txtAddFirstName);
            this.panel1.Controls.Add(this.txtAddPassword);
            this.panel1.Controls.Add(this.txtAddUserName);
            this.panel1.Location = new System.Drawing.Point(41, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 299);
            this.panel1.TabIndex = 3;
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddLastName.Location = new System.Drawing.Point(28, 193);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(150, 38);
            this.lblAddLastName.TabIndex = 22;
            this.lblAddLastName.Text = "LAST NAME";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddFirstName.Location = new System.Drawing.Point(28, 136);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(150, 38);
            this.lblAddFirstName.TabIndex = 21;
            this.lblAddFirstName.Text = "FIRST NAME";
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddPassword.Location = new System.Drawing.Point(28, 78);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(150, 38);
            this.lblAddPassword.TabIndex = 20;
            this.lblAddPassword.Text = "PASSWORD";
            // 
            // lblAddUserName
            // 
            this.lblAddUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddUserName.Location = new System.Drawing.Point(28, 20);
            this.lblAddUserName.Name = "lblAddUserName";
            this.lblAddUserName.Size = new System.Drawing.Size(150, 38);
            this.lblAddUserName.TabIndex = 19;
            this.lblAddUserName.Text = "USERNAME";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddLastName.Location = new System.Drawing.Point(184, 193);
            this.txtAddLastName.Multiline = true;
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(177, 34);
            this.txtAddLastName.TabIndex = 18;
            this.txtAddLastName.TextChanged += new System.EventHandler(this.txtAddLastName_TextChanged);
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddFirstName.Location = new System.Drawing.Point(184, 136);
            this.txtAddFirstName.Multiline = true;
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(177, 34);
            this.txtAddFirstName.TabIndex = 17;
            this.txtAddFirstName.TextChanged += new System.EventHandler(this.txtAddFirstName_TextChanged);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(184, 78);
            this.txtAddPassword.Multiline = true;
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(177, 34);
            this.txtAddPassword.TabIndex = 16;
            this.txtAddPassword.TextChanged += new System.EventHandler(this.txtAddPassword_TextChanged);
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(184, 20);
            this.txtAddUserName.Multiline = true;
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(177, 34);
            this.txtAddUserName.TabIndex = 15;
            this.txtAddUserName.TextChanged += new System.EventHandler(this.txtAddUserName_TextChanged);
            // 
            // CancelNewUserPicBox
            // 
            this.CancelNewUserPicBox.BackColor = System.Drawing.Color.Transparent;
            this.CancelNewUserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelNewUserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("CancelNewUserPicBox.Image")));
            this.CancelNewUserPicBox.Location = new System.Drawing.Point(330, 410);
            this.CancelNewUserPicBox.Name = "CancelNewUserPicBox";
            this.CancelNewUserPicBox.Size = new System.Drawing.Size(74, 72);
            this.CancelNewUserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelNewUserPicBox.TabIndex = 5;
            this.CancelNewUserPicBox.TabStop = false;
            this.CancelNewUserPicBox.Click += new System.EventHandler(this.CancelNewUserPicBox_Click);
            // 
            // AddNewUserPicBox
            // 
            this.AddNewUserPicBox.BackColor = System.Drawing.Color.Transparent;
            this.AddNewUserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNewUserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AddNewUserPicBox.Image")));
            this.AddNewUserPicBox.Location = new System.Drawing.Point(56, 410);
            this.AddNewUserPicBox.Name = "AddNewUserPicBox";
            this.AddNewUserPicBox.Size = new System.Drawing.Size(74, 72);
            this.AddNewUserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddNewUserPicBox.TabIndex = 6;
            this.AddNewUserPicBox.TabStop = false;
            this.AddNewUserPicBox.Click += new System.EventHandler(this.AddNewUserPicBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(184, 248);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 22);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Manager";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 513);
            this.Controls.Add(this.AddNewUserPicBox);
            this.Controls.Add(this.CancelNewUserPicBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddUserLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelNewUserPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUserPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AddUserLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CancelNewUserPicBox;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.Label lblAddUserName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.PictureBox AddNewUserPicBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}