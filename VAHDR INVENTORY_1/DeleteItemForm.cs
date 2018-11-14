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
    public partial class DeleteItemForm : Form
    {
        List<Item> items = new List<Item>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");

        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void txtDeleteSKU_TextChanged(object sender, EventArgs e)
        {
            Font UserInput = new Font("Ubuntu", 18.0f);
            txtDeleteSKU.Font = UserInput;
            txtDeleteSKU.ForeColor = System.Drawing.Color.Black;  
        }

        private void CancelDeleteItemPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteItemPictureBox_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                items = (List<Item>)bformatter.Deserialize(stream);
            }

            // This will remove item at index
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i].getsku() == txtDeleteSKU.Text)
                {
                    items.RemoveAt(i);
                }
            }

            //serialize list to be written into the bin file
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, items);
            }

            this.Close();
        }
    }
}
