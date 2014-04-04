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
    public partial class FormAddOrChangeProduct : Form
    {
        public FormAddOrChangeProduct(string addOrChange)
        {
            InitializeComponent();

            if (addOrChange == "change")
            {
                buttonAddProduct.Text = "Ändra produkt";

            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);


           byte[] binaryImage = ImageConverter.ToByteArray(pictureBox1.BackgroundImage);

            var productInsert = database.Products.Insert(ProductName: textBoxName.Text, Category: textBoxCategory.Text, Price: (float)numericUpDownPrice.Value,
                UnitsInStock: (float)numericUpDownUnitsInStock.Value, ImageFile: binaryImage);
            string ass = null;
        }

        private void buttonAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All picturesfiles (*.*)|*.*";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(ofd.FileName);
            }

            else
            {
               
            }
        }
    }
}
