using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple.Data;

namespace GerdasSyhorna
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void buttonInsertSupplier_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            database.Suppliers.Insert(CompanyName: textBoxName.Text, Address: textBoxAddress.Text, Telephone: textBoxTelephone.Text, Email: textBoxEmail);

            this.Dispose();
        }

        private void buttonUpdateSupplier_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            database.Products.Update(CompanyName: textBoxName2.Text, Address: textBoxAddress2.Text, Telephone2: textBoxTelephone2.Text, Email: textBoxEmail2.Text);
            
        }

       

        private void comboBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            var Supplier = (comboBoxSupplier.SelectedItem as ComboBoxItem).Value as dynamic;

            textBoxAddress2.Text = Supplier.Address;
            textBoxEmail2.Text = Supplier.Email;
            textBoxName2.Text = Supplier.CompanyName;
            textBoxTelephone2.Text = Supplier.Telephone;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (tabControl1.SelectedIndex == 1 && comboBoxSupplier.Items.Count == 0)
            {
                var database = Database.OpenConnection(Resources.connectionString);
                foreach (var item in database.Suppliers.All())
                {
                    ComboBoxItem cbItem = new ComboBoxItem() { Text = item.CompanyName, Value = item };

                    comboBoxSupplier.Items.Add(cbItem);
                }
            }
        }
    }
}
