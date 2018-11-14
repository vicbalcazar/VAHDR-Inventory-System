using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAHDR_INVENTORY_1
{
    public partial class AdvanceSearchForm : Form
    {
        public AdvanceSearchForm()
        {
            InitializeComponent();
        }

        private void CancelNewUserPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchFormInput_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAdvanceDate.Font = UserInput;
            txtAdvanceDate.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAdvancePrice_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAdvancePrice.Font = UserInput;
            txtAdvancePrice.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAdvanceExpire_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAdvanceExpire.Font = UserInput;
            txtAdvanceExpire.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAdvanceLowStock_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAdvanceLowStock.Font = UserInput;
            txtAdvanceLowStock.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAdvancePromo_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAdvancePromo.Font = UserInput;
            txtAdvancePromo.ForeColor = System.Drawing.Color.Black; 
        }

        // Pings maindisplayform to call public .getdata() to try and return
        // values from this current form
        private void pctBoxSearch_Click(object sender, EventArgs e)
        {
            //return search_data;
            MainDisplayFrame ping = new MainDisplayFrame();
            ping.Advance_Search_Ping();
        }

        private void chkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxDate.Checked = true;
        }

        private void chkBoxPrice_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxPrice.Checked = true;
        }

        private void chkBoxExpire_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxExpire.Checked = true;
        }

        private void chkBoxLow_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxLow.Checked = true;
        }

        private void chkBoxPromotion_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxPromotion.Checked = true;
        }

        // Public method that can be accessed by other forms
        public List<string> GetData()
        {
            List<string> search_data = new List<string>();
            if (chkBoxDate.Checked == true) { search_data.Add(txtAdvanceDate.Text); }
            if (chkBoxPrice.Checked == true) { search_data.Add(txtAdvancePrice.Text); }
            if (chkBoxExpire.Checked == true) { search_data.Add(txtAdvanceExpire.Text); }
            if (chkBoxLow.Checked == true) { search_data.Add(txtAdvanceLowStock.Text); }
            if (chkBoxPromotion.Checked == true) { search_data.Add(txtAdvancePromo.Text); }
            return search_data;
        }
    }
}
