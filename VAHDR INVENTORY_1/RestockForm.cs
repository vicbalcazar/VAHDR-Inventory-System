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
    public partial class RestockForm : Form
    {
        List<Item> items = new List<Item>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");

        public RestockForm()
        {
            InitializeComponent();
        }

        private void CancelRestockItemPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestockItemPictureBox_Click(object sender, EventArgs e)
        {
            int tempTotal;
            
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                items = (List<Item>)bformatter.Deserialize(stream);
            }

            if (RestockAmountTxtBox.Text != "" && txtRestockSKU.Text != "")
            {
                // This codeblock will search for correct sku and update current count
                for (int i = 0; i < items.Count(); i++)
                {
                    if (items[i].getsku() == txtRestockSKU.Text)
                    {
                        // Convert string to int
                        tempTotal = Int32.Parse(items[i].getcount()) + Int32.Parse(RestockAmountTxtBox.Text);

                        // Convert int to string, and call setcount()
                        items[i].setcount(Convert.ToString(tempTotal));

                        //serialize
                        using (Stream stream = File.Open(path, FileMode.Create))
                        {
                            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                            bformatter.Serialize(stream, items);
                        }

                        this.Close();
                    }
                }
            }
            else { MessageBox.Show("Invalid Entries."); }
        }

        private void txtRestockSKU_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtRestockSKU.Font = UserInput;
            txtRestockSKU.ForeColor = System.Drawing.Color.Black;  
        }

        private void RestockAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            RestockAmountTxtBox.Font = UserInput;
            RestockAmountTxtBox.ForeColor = System.Drawing.Color.Black;  
        }
    }
}
