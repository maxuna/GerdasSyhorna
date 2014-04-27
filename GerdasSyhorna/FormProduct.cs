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
    public partial class FormProduct : Form
    {
        
      
        public FormProduct()
        {
            InitializeComponent();
            var database = Database.OpenConnection(Resources.connectionString);
            
            //lägger in leverantörerna i boxen med dess data
            foreach (var item in database.Suppliers.All())
            {
                ComboBoxItem cbItem = new ComboBoxItem() { Text = item.CompanyName, Value = item };

                comboBoxSupplier.Items.Add(cbItem);
            }
            
        }

        public virtual void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            byte[] binaryImage = null;
            
            if(pictureBox1.BackgroundImage != null)
           binaryImage = ImageConverter.ToByteArray(pictureBox1.BackgroundImage);




            dynamic selectedSupplier;

            if (comboBoxSupplier.SelectedItem.Equals("Ingen"))
                selectedSupplier = null;

            else
                selectedSupplier = ((comboBoxSupplier.SelectedItem as ComboBoxItem).Value as dynamic);



            //sätter in den nya produkten i databasen
            database.Products.Insert(ProductName: textBoxName.Text, Category: textBoxCategory.Text, Price: (float)numericUpDownPrice.Value,
                UnitsInStock: (short)numericUpDownUnitsInStock.Value, ImageFile: binaryImage, SupplierId: selectedSupplier.SupplierId);

            this.Dispose();
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












    public class ChangeProduct : FormProduct
    {
        int id;
      

        public ChangeProduct(int id)
        {

            this.Controls.Find("buttonAddProduct", false)[0].Text = "Ändra produkt";

            var database = Database.OpenConnection(Resources.connectionString);

            var product = database.Products.FindAllByProductId(id).First();

            if(product.ImageFile != null)
            pictureBox1.BackgroundImage = ImageConverter.ImageFromByteArray(product.ImageFile);
            
            this.id = id;
            
            //ger rutorna nuvarande värde hos produkten
            textBoxName.Text = product.ProductName;
            textBoxCategory.Text = product.Category;
            numericUpDownPrice.Value = (decimal)product.Price;
            numericUpDownUnitsInStock.Value = (decimal)product.UnitsInStock;
            if(product.SupplierId != null)
            comboBoxSupplier.Text = database.SP_SupplierFromId(product.SupplierId).First().CompanyName;

            
        }
            
        // "buttonChangeProduct"
        public override void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            byte[] binaryImage = null;

            if (pictureBox1.BackgroundImage != null)
                binaryImage = ImageConverter.ToByteArray(pictureBox1.BackgroundImage);


            
            dynamic selectedSupplier; 

            if (comboBoxSupplier.SelectedItem.Equals("Ingen"))
                selectedSupplier = null;

            else
               selectedSupplier = ((comboBoxSupplier.SelectedItem as ComboBoxItem).Value as dynamic);



            //ersätter produkten i databasen
                database.Products.UpdateByProductId(ProductId: id, ProductName: textBoxName.Text,
                Category: textBoxCategory.Text, Price: (float)numericUpDownPrice.Value, UnitsInStock: (short)numericUpDownUnitsInStock.Value,
                ImageFile: binaryImage, SupplierId: selectedSupplier.SupplierId);

                this.Dispose();
        }

    }
}
