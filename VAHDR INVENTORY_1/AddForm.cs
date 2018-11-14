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


    public partial class AddForm : Form
    {
        List<Item> items = new List<Item>();
        Item newitem = new Item();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");

        // Declaring global string array
        string promotion = "NONE";

        public AddForm()
        {
            InitializeComponent();
            promotion = "NONE";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddSku_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddSku.Font = UserInput;
            txtAddSku.ForeColor = System.Drawing.Color.Black;  
        }

        private void txtAddCategory_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddCategory.Font = UserInput;
            txtAddCategory.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAddItem_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddItem.Font = UserInput;
            txtAddItem.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAddPrice_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddPrice.Font = UserInput;
            txtAddPrice.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAddCount_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddCount.Font = UserInput;
            txtAddCount.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAddDate_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddDate.Font = UserInput;
            txtAddDate.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtAddExpiration_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtAddExpiration.Font = UserInput;
            txtAddExpiration.ForeColor = System.Drawing.Color.Black; 
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtDiscount.Font = UserInput;
            txtDiscount.ForeColor = System.Drawing.Color.Black; 
        }

        // This click event will add to text file.  To display updated added items, press VIEW click
        // event again to update data grid.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //deserialize
            using (Stream stream = File.Open(path, FileMode.Open))
           {
               var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

               items = (List<Item>)bformatter.Deserialize(stream);
           }

            newitem.setsku(txtAddSku.Text);
            newitem.setcategory(txtAddCategory.Text);
            newitem.setitem(txtAddItem.Text);
            newitem.setcount(txtAddCount.Text);
            newitem.setprice(txtAddPrice.Text);
            newitem.setdate(txtAddDate.Text);
            newitem.setexpire(txtAddExpiration.Text);
            newitem.setpromo(promotion);
            newitem.setdiscount(txtDiscount.Text);

            items.Add(newitem);

            //serialize
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, items);
            }

            // Closes form
            this.Close();
        }

        // If box is checked promotion is set to "YES"
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            promotion = "YES";

        }
    }
}
