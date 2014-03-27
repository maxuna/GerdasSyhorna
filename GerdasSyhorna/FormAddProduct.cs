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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);


            

            var productInsert = database.Products.Insert(ProductName: textBoxName.Text, Category: textBoxCategory.Text, Price: (float)numericUpDownPrice.Value,
                UnitsInStock: (float)numericUpDownUnitsInStock.Value);
            string ass = null;
        }
    }
}
