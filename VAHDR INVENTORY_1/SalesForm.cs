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
    public partial class SalesForm : Form
    {
        List<Item> items = new List<Item>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");
        string search_sku, column1, column2, column3;
        double total = 0.00;
        int count;

        public SalesForm()
        {
            InitializeComponent();
            load_items();
            TotalTextBox.Text = "$0.00";
        }

        private void load_items()
        {
            // Load items into list
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                items = (List<Item>)bformatter.Deserialize(stream);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 20.0f);
            RegisterSku.Font = UserInput;
            RegisterSku.ForeColor = System.Drawing.Color.Black; 
        }

        private void keyPadBtn7_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "7";
        }

        private void keyPadBtn8_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "8";
        }

        private void keyPadBtn9_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "9";
        }

        private void keyPadBtn4_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "4";
        }

        private void keyPadBtn5_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "5";
        }

        private void keyPadBtn6_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "6";
        }

        private void keyPadBtn1_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "1";
        }

        private void keyPadBtn2_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "2";
        }

        private void keyPadBtn3_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "3";
        }

        private void keyPadBtn0_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + "0";
        }

        private void keyPadBtnDot_Click(object sender, EventArgs e)
        {
            RegisterSku.Text = RegisterSku.Text + ".";
        }

        //Enter Button
        private void keyPadBtnSale_Click(object sender, EventArgs e)
        {
            search_sku = RegisterSku.Text;

            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i].getsku() == search_sku && Int32.Parse(items[i].getcount()) > 0)
                {
                    column1 = items[i].getsku() + "\t";
                    column2 = items[i].getitem() + "\t";
                    column3 = "\t$" + items[i].getprice();
                    ShoppingCarListBox.Items.Add(String.Format("{0}{1}{2}", column1.PadRight(5), column2.PadRight(5), column3));

                    // Adds up total
                    total += Double.Parse(items[i].getprice());

                    // Puts total amount into text box
                    TotalTextBox.Text = "$" + total;

                    // Get future inventory
                    count = Int32.Parse(items[i].getcount()) - 1;  

                    // Subtracts from inventory
                    items[i].setcount(Convert.ToString(count));

                }
            }

            RegisterSku.Text = "";
        }

        private void TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 20.0f);
            TotalTextBox.Font = UserInput;
            TotalTextBox.ForeColor = System.Drawing.Color.Black; 
        }

        private void keyPadBtnSell_Click(object sender, EventArgs e)
        {
            //serialize list to be written into the bin file
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, items);
            }

            MessageBox.Show("Purchase complete.");

            this.Close();
        }
    }
}
