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
    public partial class EditUserForm : Form
    {
        List<Accounts> current_account = new List<Accounts>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        public EditUserForm()
        {
            InitializeComponent();
            Load_User_accounts();
        }

        private void CancelDeleteUserPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_User_accounts()
        {
            string column1, column2, column3;
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // Gets firstname & lastname & ID & Username of current accounts
            for (int i = 0; i < current_account.Count(); i++)
            {
                column1 = current_account[i].getfirstName() + " " + current_account[i].getlastName() + "\t";
                column2 = "\tID: " + current_account[i].getempID();
                column3 = "\tUsername: " + current_account[i].getuserName();
                UserListBox.Items.Add(String.Format("{0}{1}{2}", column1.PadRight(20), column2.PadRight(20), column3));
            }

        }

        private void txtDeleteEmployeeID_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtSearchEmployeeID.Font = UserInput;
            txtSearchEmployeeID.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtChangeFirstName_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtChangeFirstName.Font = UserInput;
            txtChangeFirstName.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtChangeLastName_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtChangeLastName.Font = UserInput;
            txtChangeLastName.ForeColor = System.Drawing.Color.Black;  
        }

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
                        if (txtChangeFirstName.Text != "") { current_account[i].setfirstName(txtChangeFirstName.Text); }
                        if (txtChangeLastName.Text != "") { current_account[i].setlastName(txtChangeLastName.Text); }
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
