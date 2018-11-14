/*  VAHDR INVENTORY SYSTEM VERSION 2.11
 *  UPDATE: Finalized salesform for cashier use case.
 *  
 *  Made edits to string formatting for edit user, delete user, and cashier listboxes.
 *  Made minor changes to pathings for all forms.
 */

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
    public partial class LoginForm : Form
    {
        // Init. new list of Accounts object
        List<Accounts> account = new List<Accounts>();

        // Will search for bin file in directory and assign the FULL path to string path
        string path = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        // VariableInit
        int loginTries = 0;
        bool success = false;

        //Static variable to send to another form
        public static string CurrentUserName;

        // This executes our InitializeComponent() that is needed for design
        public LoginForm()
        {
            InitializeComponent();
        }


        // Function for getting user input for Username
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 22.0f);          
            txtUsername.Font = UserInput;
            txtUsername.ForeColor = System.Drawing.Color.White;  
        }

        // Function for getting user input for Password
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 22.0f); 
            txtPassword.Font = UserInput;
            txtPassword.ForeColor = System.Drawing.Color.White;
        }

        // Method that checks username/password and init maindisplayform
        // Do not modify
        // -Hieu
        private void Login_User_Password_Check()
        {
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                account = (List<Accounts>)bformatter.Deserialize(stream);
            }

            // Increment login tries
            loginTries++;

            for (int i = 0; i < account.Count(); i++)
            {
                if (txtUsername.Text == account[i].getuserName() && txtPassword.Text == account[i].getpassword())
                {
                    success = true;

                    // Saves into static variable if there is a 'hit'.
                    CurrentUserName = txtUsername.Text;

                    MainDisplayFrame display_form = new MainDisplayFrame();
                    display_form.Show();
                    this.Hide();
                }
            }

            // Prompts user of incorrect username/password
            if (!success)
            {
                MessageBox.Show("Incorrect username and password.");
            }

            // Boots user if too many failed attempts.
            if (loginTries == 5)
            {
                MessageBox.Show("You have made too many attempts.");
                this.Close();
            }
        }

        // Function to init an event for user to login. 
        // Takes 2 param, username & password
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login_User_Password_Check();
            

        }


        //Resetting password
        //Roberto Perez
        private void button1_Click(object sender, EventArgs e)
        {
            PasswordResetform display_PasswordResetform = new PasswordResetform();
            display_PasswordResetform.Show();
        }
    }
}
