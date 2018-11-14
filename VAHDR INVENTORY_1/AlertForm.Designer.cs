namespace VAHDR_INVENTORY_1
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.AlertLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlertListBox = new System.Windows.Forms.ListBox();
            this.ExitAlertPctBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitAlertPctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AlertLabel
            // 
            this.AlertLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlertLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AlertLabel.Location = new System.Drawing.Point(166, 9);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(140, 77);
            this.AlertLabel.TabIndex = 6;
            this.AlertLabel.Text = "Alerts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AlertListBox);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 243);
            this.panel1.TabIndex = 7;
            // 
            // AlertListBox
            // 
            this.AlertListBox.BackColor = System.Drawing.Color.LightGray;
            this.AlertListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertListBox.FormattingEnabled = true;
            this.AlertListBox.ItemHeight = 18;
            this.AlertListBox.Location = new System.Drawing.Point(19, 20);
            this.AlertListBox.Name = "AlertListBox";
            this.AlertListBox.Size = new System.Drawing.Size(405, 202);
            this.AlertListBox.TabIndex = 1;
            // 
            // ExitAlertPctBox
            // 
            this.ExitAlertPctBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitAlertPctBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitAlertPctBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitAlertPctBox.Image")));
            this.ExitAlertPctBox.Location = new System.Drawing.Point(386, 342);
            this.ExitAlertPctBox.Name = "ExitAlertPctBox";
            this.ExitAlertPctBox.Size = new System.Drawing.Size(74, 72);
            this.ExitAlertPctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitAlertPctBox.TabIndex = 33;
            this.ExitAlertPctBox.TabStop = false;
            this.ExitAlertPctBox.Click += new System.EventHandler(this.ExitAlertPctBox_Click);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 438);
            this.Controls.Add(this.ExitAlertPctBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlertLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerts";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitAlertPctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox AlertListBox;
        private System.Windows.Forms.PictureBox ExitAlertPctBox;
    }
}