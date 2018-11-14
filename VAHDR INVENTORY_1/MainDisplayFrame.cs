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
    public partial class MainDisplayFrame : Form
    {
        System.IO.StreamReader fileToPrint;
        System.Drawing.Font printFont;
        List<Item> items = new List<Item>();
        List<Accounts> current_account = new List<Accounts>();
        Accounts active_account = new Accounts();
        
        
        AdvanceSearchForm display_advance_search_Form = new AdvanceSearchForm();
        // Declaring global string array
        string[] columnnames = { "SKU", "Category", "ITEM", "COUNT", "PRICE", "DATE", "EXPIRE", "PROMO", "DISCOUNT" };

        // Will search for bin file in directory and assign the FULL path_inventory to string path
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");
        string path_accounts = Path.Combine(Directory.GetCurrentDirectory(), "accounts.bin");

        // Declaring string for search cases
        string search_switch_case = "none";
        string user_search_input;
        int search_index = -1;

        public MainDisplayFrame()
        {
            InitializeComponent();

            //new menustrip renderer created to override our menustrip class properties
            menustripMainDisplay.Renderer = new MyRenderer();
            
            //Setting current_active accounts
            string TempCurrentUsername = LoginForm.CurrentUserName;
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path_accounts, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                current_account = (List<Accounts>)bformatter.Deserialize(stream);
            }
            for (int i = 0; i < current_account.Count(); i++)
            {
                if (current_account[i].getuserName() == TempCurrentUsername)
                {
                    active_account = current_account[i];
                }
            }
            Clear_Data_Grid();
        }

        //new color for renderer
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        //Color table 
        private class MyColors : ProfessionalColorTable
        {
            //Override color item for selected / pressed values
            public override Color MenuItemSelected
            {
                get { return Color.Black; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Black; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Black; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.Black; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.Black; }
            }
            
        }

        private void Load_Data_file()
        {
           //deserialize bin file so it can be read into the List object
           using (Stream stream = File.Open(path, FileMode.Open))
           {
               var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

               items = (List<Item>)bformatter.Deserialize(stream);
           }
           
            DataTable dt = new DataTable();
             
            // Reads first line of text file and add values as columns
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }

            // Reads the rest of the text file and add values in new rows
            int index = 0;
            while (index < items.Count())
            {
                DataRow dr = dt.NewRow();

                string[] values = {items[index].getsku(), items[index].getcategory(), items[index].getitem(), items[index].getcount(), items[index].getprice(), items[index].getdate(), items[index].getexpire(), items[index].getpromo(), items[index].getdiscount() };
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
                ++index;
            }
            dataGridView1.DataSource = dt;
        }

        private void Clear_Data_Grid()
        {

            // Load data from a .txt file
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            DataTable dt = new DataTable();

            // Reads first line of text file and add values as columns
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }

            // Reads the rest of the text file and add values in new rows
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();

            dataGridView1.DataSource = dt;
        }

        private void Search_Data_Source()
        {
            switch (search_switch_case)
            {
                case "SKU":
                    search_index = 0;
                    search_case(search_index, user_search_input);
                    break;
                case "CATEGORY":
                    search_index = 1;
                    search_case(search_index, user_search_input);
                    break;
                case "ITEM":
                    search_index = 2;
                    search_case(search_index, user_search_input);
                    break;
                default:
                    MessageBox.Show("Invalid search entry.");
                    break;
            }

        }

        private void search_case(int num, string user_search_input)
        {
            //deserialize bin file
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                items = (List<Item>)bformatter.Deserialize(stream);
            }


            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }

            // Search according to user selection and updates
            int index = 0;
            while (index < items.Count())
            {
                DataRow dr = dt.NewRow();

                if (items[index].getValue(num) == user_search_input)
                {
                    string[] values = { items[index].getsku(), items[index].getcategory(), items[index].getitem(), items[index].getcount(), items[index].getprice(), items[index].getdate(), items[index].getexpire(), items[index].getpromo(), items[index].getdiscount() };
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                   
                    dt.Rows.Add(dr);
                }else
                {
                    string[] values = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
                }
                ++index;
            }
            dataGridView1.DataSource = dt;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm display_add_form = new AddForm();
            display_add_form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Call Load_Data_File function
            Load_Data_file();
        }

        private void txtSearchFormInput_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 14.0f);
            txtSearchFormInput.Font = UserInput;
            txtSearchFormInput.ForeColor = System.Drawing.Color.Black; 
        }

        private void pctBoxSearch_Click(object sender, EventArgs e)
        {
            user_search_input = txtSearchFormInput.Text;
            Clear_Data_Grid();
            Search_Data_Source();
        }

        private void chkBoxSKU_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxCategory.Checked = false;
            chkBoxItem.Checked = false;
            search_switch_case = "SKU";
        }

        private void chkBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxSKU.Checked = false;
            chkBoxItem.Checked = false;
            search_switch_case = "CATEGORY";
        }

        private void chkBoxItem_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxSKU.Checked = false;
            chkBoxCategory.Checked = false;
            search_switch_case = "ITEM";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItemForm display_delete_item_form = new DeleteItemForm();
            display_delete_item_form.Show();

        }

        private void pctBoxRestock_Click(object sender, EventArgs e)
        {
            RestockForm display_restock_form = new RestockForm();
            display_restock_form.Show();
        }

        private void pctBoxAlert_Click(object sender, EventArgs e)
        {
            AlertForm display_alert_form = new AlertForm();
            display_alert_form.Show();
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SWITCH USER FEATURE IS UNDER MAINTENANCE.");
            LoginForm display_login_form = new LoginForm();
            Close();
            display_login_form.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (active_account.getmanagerStatus() == true)
            {
                AddUserForm display_add_user_form = new AddUserForm();
                display_add_user_form.Show();
            }
            else { MessageBox.Show("Active user is not manager.  Please contact your lead."); }
        }
       
        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            SalesForm display_sales_form = new SalesForm();
            display_sales_form.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (active_account.getmanagerStatus() == true)
            {
                DeleteUserForm display_delete_user_form = new DeleteUserForm();
                display_delete_user_form.Show();
            }
            else { MessageBox.Show("Active user is not manager.  Please contact your lead."); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HelpForm display_help = new HelpForm();
            display_help.Show();
        }

        // Gets a ping from advance_search_form to call .GetData();
        public void Advance_Search_Ping()
        {
            List<string> data = display_advance_search_Form.GetData();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (active_account.getmanagerStatus() == true)
            {
                EditUserForm display_edit_user_form = new EditUserForm();
                display_edit_user_form.Show();
            }
            else { MessageBox.Show("Active user is not manager.  Please contact your lead."); }
        }


        private void menustripMainDisplay_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                items = (List<Item>)bformatter.Deserialize(stream);
            }
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "report.txt"), String.Empty);
            int index = 0;
            while (index < items.Count())
            {

                string[] values = { items[index].getsku(), items[index].getcategory(), items[index].getitem(), items[index].getcount(), items[index].getprice(), items[index].getdate(), items[index].getexpire(), items[index].getpromo(), items[index].getdiscount() };

                for (int i = 0; i < values.Length; i++)
                {
                    File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "report.txt"), (values[i] + " "));
                }
                File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "report.txt"), Environment.NewLine);
                index++;
            }


            fileToPrint = new System.IO.StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "report.txt"));
            printFont = new System.Drawing.Font("Arial", 10);

            //File.WriteAllText("inventory.txt");

            PrintDialog pdi = new PrintDialog();
            pdi.Document = printDocument1;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }
            //printDocument1.Print();
            fileToPrint.Close();
        }
    }
    //item class for each item.
    [Serializable]
    public class Item
    {
        string sku, category, item, count, price, date, expire, promo, discount;

        public void setsku(string s) { sku = s; }
        public void setcategory(string s) { category = s; }
        public void setitem(string s) { item = s; }
        public void setcount(string s) { count = s; }
        public void setprice(string s) { price = s; }
        public void setdate(string s) { date = s; }
        public void setexpire(string s) { expire = s; }
        public void setpromo(string s) { promo = s; }
        public void setdiscount(string s) { discount = s; }

        public string getsku() { return sku; }
        public string getcategory() { return category; }
        public string getitem() { return item; }
        public string getcount() { return count; }
        public string getprice() { return price; }
        public string getdate() { return date; }
        public string getexpire() { return expire; }
        public string getpromo() { return promo; }
        public string getdiscount() { return discount; }

        //for search case
        public string getValue(int num)
        {
            switch (num)
            {
                case 0:
                    return getsku();
                case 1:
                    return getcategory();
                case 2:
                    return getitem();
                default:
                    MessageBox.Show("Invalid search entry.");
                    return "";
            }
        }
    }

    // Account class for each user
    [Serializable]
    public class Accounts
    {
        // Account Information
        string userName, password, firstName, lastName;
        int empID;

        // If Employee is manager then true, else false
        bool managerStatus;

        // Sets class variables of account 
        public void setuserName(string s) { userName = s; }
        public void setpassword(string s) { password = s; }
        public void setfirstName(string s) { firstName = s; }
        public void setlastName(string s) { lastName = s; }
        public void setmanagerStatus(bool m) { managerStatus = m; }
        public void setempID(int _id) { empID = _id; }

        // Get account class variables 
        public string getuserName() { return userName; }
        public string getpassword() { return password; }
        public string getfirstName() { return firstName; }
        public string getlastName() { return lastName; }
        public int getempID() { return empID; }
        public bool getmanagerStatus() { return managerStatus; }

    }
}
