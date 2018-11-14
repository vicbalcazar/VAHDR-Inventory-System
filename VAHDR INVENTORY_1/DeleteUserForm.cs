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
    public partial class DeleteUserForm : Form
    {
        List<Accounts> current_account = new List<Accounts>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        public DeleteUserForm()
        {
            InitializeComponent();
            Load_User_accounts();
            
        }

        private void Load_User_accounts()
        {
            string column1, column2;
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // Gets firstname & lastname & ID & Username of current accounts
            for (int i = 0; i < current_account.Count(); i++)
            {
                column1 = (current_account[i].getfirstName() + " " + current_account[i].getlastName() + "\t");
                column2 = (" \tID: " + current_account[i].getempID());
                UserListBox.Items.Add(String.Format("{0} {1}", column1.PadRight(20), column2.PadRight(20)));
            }
        }

        private void CancelDeleteUserPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendHomePictureBox_Click(object sender, EventArgs e)
        {
            // Convert from string to int
            int temp = Int32.Parse(txtDeleteEmployeeID.Text);

            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // Delete user account at index
            for (int i = 0; i < current_account.Count(); i++)
            {
                if (current_account[i].getempID() == temp)
                {
                    current_account.RemoveAt(i);
                }
            }

            //serialize list to be written into the bin file
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, current_account);
            }

            this.Close();
            /*
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // If ID box is not empty
            if (txtDeleteEmployeeID.Text != "")
            {
                 // Delete user account at index
                for (int i = 0; i < current_account.Count(); i++)
                {
                    if (current_account[i].getempID() == Int32.Parse(txtDeleteEmployeeID.Text));
                    {
                        current_account.RemoveAt(i);
                    }
                }
                //serialize list to be written into the bin file
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, current_account);
                }

                this.Close();
            }
            // If ID is empty, display
            else { MessageBox.Show("Please Enter an ID."); }
            */

        }

        private void txtDeleteEmployeeID_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtDeleteEmployeeID.Font = UserInput;
            txtDeleteEmployeeID.ForeColor = System.Drawing.Color.Black; 
        }       
    }
}
