//Version 2.06
//This form is to reset password if user wish forgets his/her password. 
//User must be able to know his/her account ID.

using System;
using System.IO;
using System.Collections;
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
    public partial class PasswordResetform : Form
    {
        List<Accounts> current_account = new List<Accounts>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        public PasswordResetform()
        {
            InitializeComponent();
            //protects password characters from being visible.
            txtChangePassword.PasswordChar = '*';
        }

        private void CancelResetPasswordBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This function will ask for user's ID in order to proceed with the password reset
        private void txtSearchEmployeeID_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtSearchEmployeeID.Font = UserInput;
            txtSearchEmployeeID.ForeColor = System.Drawing.Color.Black;

        }

        //Function to get new password and update it from the binary file
        private void txtChangePassword_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtChangePassword.Font = UserInput;
            txtChangePassword.ForeColor = System.Drawing.Color.Black;
        }

        private void EditUserPictureBox_Click(object sender, EventArgs e)
        {
            bool success = true;
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // If not empty, then make changes to selected ID
            if (txtSearchEmployeeID.Text != "")
            {
                for (int i = 0; i < current_account.Count(); i++)
                {
                    if (current_account[i].getempID() == Int32.Parse(txtSearchEmployeeID.Text))
                    {
                        // If not empty, then assign to correct element
                        if (txtChangePassword.Text != "") { current_account[i].setpassword(txtChangePassword.Text); }

                        //serialize list to be written into the bin file
                        using (Stream stream = File.Open(path, FileMode.Create))
                        {
                            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                            bformatter.Serialize(stream, current_account);
                        }

                        // Sets a sentinel value to exit loop
                        i = current_account.Count() - 1;

                        // Change success to true
                        success = true;

                        // Closes form
                        this.Close();
                        MessageBox.Show("User password has been reset successfully");
                    }
                    else { success = false; }
                }
                // If not valid ID, display.
                if (!success) { MessageBox.Show("Invalid ID"); }
            }
            // If no ID is entered.
            else { MessageBox.Show("Please Enter an ID."); }
        }

    }
}
