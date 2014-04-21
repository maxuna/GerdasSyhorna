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
            ComboBox supplierBox = (this.Controls.Find("comboBoxSupplier", false)[0] as ComboBox);

            foreach (var item in database.Suppliers)
            {
                ComboBoxItem cbItem = new ComboBoxItem() { Text = item.CompanyName, Value = item };

                supplierBox.Items.Add(cbItem);
            }
            
        }

        public virtual void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);


           byte[] binaryImage = ImageConverter.ToByteArray(pictureBox1.BackgroundImage);

            //sätter in den nya produkten i databasen
            var productInsert = database.Products.Insert(ProductName: textBoxName.Text, Category: textBoxCategory.Text, Price: (float)numericUpDownPrice.Value,
                UnitsInStock: (short)numericUpDownUnitsInStock.Value, ImageFile: binaryImage);
           
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
            this.Controls.Find("PictureBox1", false)[0].BackgroundImage = ImageConverter.ImageFromByteArray(product.ImageFile);

            this.id = id;

            //ger rutorna nuvarande värde hos produkten
            this.Controls.Find("textBoxName", false)[0].Text = product.ProductName;
            this.Controls.Find("textBoxCategory", false)[0].Text = product.Category;
            (this.Controls.Find("numericUpDownPrice", false)[0] as NumericUpDown).Value = (decimal)product.Price;
            (this.Controls.Find("numericUpDownUnitsInStock", false)[0] as NumericUpDown).Value = (decimal)product.UnitsInStock;
            (this.Controls.Find("comboBoxSupplier", false)[0] as ComboBox).Text = database.SP_SupplierFromId(product.SupplierId).First().CompanyName;

            
        }
            

        public override void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);


            string name = this.Controls.Find("textBoxName", false)[0].Text;
            string category = this.Controls.Find("textBoxCategory", false)[0].Text;
            float price = (float)(this.Controls.Find("numericUpDownPrice", false)[0] as NumericUpDown).Value;
            short inStock = (short)(this.Controls.Find("numericUpDownUnitsInStock", false)[0] as NumericUpDown).Value;

            //ersätter produkten i databasen
            var updateProduct = database.Products.UpdateById(Id: id, ProductName: name, Category: category, Price: price, UnitsInStock: inStock);
        }

    }
}
