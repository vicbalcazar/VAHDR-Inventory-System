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
    public partial class AlertForm : Form
    {
        List<Item> items = new List<Item>();
        string path = Path.Combine(Directory.GetCurrentDirectory(), "inventory.bin");

        public AlertForm()
        {
            InitializeComponent();
            low_alerts();
        }

        private void ExitAlertPctBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void low_alerts()
        {
            string column1, column2, column3;
            //deserialize bin file so it can be read into the List object
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                items = (List<Item>)bformatter.Deserialize(stream);
            }

            for (int i = 0; i < items.Count(); i++)
            {
                if (Int32.Parse(items[i].getcount()) < 5)
                {
                    column1 = "Status: Low Stock";
                    column2 = "Item: " + items[i].getitem();
                    column3 = "Count: " + items[i].getcount();
                    AlertListBox.Items.Add(String.Format("{0} {1} {2}", column1.PadRight(24), column2.PadRight(19), column3.PadRight(10)));
                }
            }
        }
    }
}
