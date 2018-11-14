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
    public partial class AddUserForm : Form
    {
        // Init. Accounts object named account
        List<Accounts> account = new List<Accounts>();
        Accounts newAccounts = new Accounts();
        bool managerStatusChecked = false;

        // Gets path of accounts.bin
        string path = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        // Creates rnd object to generate random number
        Random rnd = new Random();

        public AddUserForm()
        {
            InitializeComponent();
        }

        // Cancel event
        private void CancelNewUserPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add new user event
        private void AddNewUserPicBox_Click(object sender, EventArgs e)
        {
            if (txtAddUserName.Text == "" || txtAddPassword.Text == "" || txtAddFirstName.Text == "" || 
                txtAddLastName.Text == "")
            {
                MessageBox.Show("Missing values.  Try again");
            }
            else
            {
                //deserialize
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    account = (List<Accounts>)bformatter.Deserialize(stream);
                }

                // Sets values for newAccounts variables
                newAccounts.setuserName(txtAddUserName.Text);
                newAccounts.setpassword(txtAddPassword.Text);
                newAccounts.setfirstName(txtAddFirstName.Text);
                newAccounts.setlastName(txtAddLastName.Text);
                newAccounts.setmanagerStatus(managerStatusChecked);
                newAccounts.setempID(rnd.Next(100000, 999999));

                // Adds newAccount to account list
                account.Add(newAccounts);

                //serialize
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter.Serialize(stream, account);
                }

                this.Close();
            }
        }

        // Text Box Fonts
        private void txtAddUserName_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddUserName.Font = UserInput;
            txtAddUserName.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtAddPassword_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddPassword.Font = UserInput;
            txtAddPassword.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtAddFirstName_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddFirstName.Font = UserInput;
            txtAddFirstName.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtAddLastName_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddLastName.Font = UserInput;
            txtAddLastName.ForeColor = System.Drawing.Color.Black;  
        }

        // Event for manager checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            managerStatusChecked = true;
        }
    }
}
