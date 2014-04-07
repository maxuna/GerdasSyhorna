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

    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            var database = Database.OpenConnection(Resources.connectionString);

            

            foreach (var product in database.Products.All())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductName;
                lvi.SubItems.AddRange(new string[] { product.Category, product.Price.ToString(), product.UnitsInStock.ToString(), product.UnitsOnOrder.ToString()});
                lvi.Tag = new List<object> {product.SupplierId, product.ImageFile};
                listViewProducts.Items.Add(lvi);
            }

            foreach (ColumnHeader item in listViewProducts.Columns)
            {
                item.Tag = false;
            }
        }

       

      

        private void listViewProducts_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listViewProducts.Items.Clear();
            ColumnHeader ch = listViewProducts.Columns[e.Column];
            var database = Database.OpenConnection(Resources.connectionString);

            //listan ordnar sig beroende på vilken kolumn man klickade på
            var table = (dynamic)null;
            SimpleQuery dsdf;
            
            switch (ch.Text)
            {
                case "Pris":
                    if(ch.Tag.Equals(false))
                    table = database.Products.All().OrderByPrice(); 
                    else
                        table = database.Products.All().OrderByPriceDescending(); 
                    break;
                    
                case "Antal på order":
                    if (ch.Tag.Equals(false))
                    table = database.Products.All().OrderByUnitsOnOrder();
                    else
                        table = database.Products.All().OrderByUnitsOnOrderDescending();
                    break;

                case "Kategori":
                    if (ch.Tag.Equals(false))
                        table = database.Products.All().OrderByCategory();
                    else
                        
                        table = database.Products.All().OrderByCategoryDescending();
                    break;

                case "Antal i lager":
                    if (ch.Tag.Equals(false))
                    table = database.Products.All().OrderByUnitsInStock();
                    else
                        table = database.Products.All().OrderByUnitsInStockDescending();
                    break;

                case "Namn":
                    if (ch.Tag.Equals(false))
                    table = database.Products.All().OrderByProductName();
                    else
                        table = database.Products.All().OrderByProductNameDescending();
                    break;
            }

            //kolumnens state, om t.ex. priset ska sorteras från lägsta eller högsta värdet
            ch.Tag = ch.Tag.Equals(true) ? false : true;

            foreach (var product in table)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductName;
                lvi.SubItems.AddRange(new string[] { product.Category, product.Price.ToString(), product.UnitsInStock.ToString(), product.UnitsOnOrder.ToString()});
                lvi.Tag = new List<object> {product.SupplierId, product.ImageFile};
                listViewProducts.Items.Add(lvi);
            }
        }



        private void listViewProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 1 || listViewProducts.SelectedItems.Count < 1)
            {
                return;
            }

            ListViewItem lvi = listViewProducts.SelectedItems[0];

            if (lvi.Tag == null)
            {
                return;
            }

            //Listview raderna innehåller leverantörsId i Tag
            var supplierId = (lvi.Tag as List<object>)[0];
            var database = Database.OpenConnection(Resources.connectionString);
            if (supplierId != null)
            {
                try
                {
                    var supplierRow = database.SP_SupplierFromId(supplierId).First();
                    textBoxSupplier.Text = supplierRow.CompanyName + "\r\n" + supplierRow.Address + "\r\n" + supplierRow.Telephone;
                }
                   
                catch (InvalidOperationException) { }
               
               
            }
            else
            {
                textBoxSupplier.Text = null;
            }

            //hämtar bild ifrån databasen och koverterar den
            byte[] binaryImage = (listViewProducts.SelectedItems[0].Tag as List<object>)[1] as byte[];
            if (binaryImage == null)
            {
                pictureBox.BackgroundImage = null;
                return;
            }

            pictureBox.BackgroundImage = ImageConverter.ImageFromByteArray(binaryImage);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddOrChangeProduct formAddProduct = new FormAddOrChangeProduct("add");
            formAddProduct.Show();
        }

        private void buttonChangeProduct_Click(object sender, EventArgs e)
        {
            FormAddOrChangeProduct formChangeProduct = new FormAddOrChangeProduct("change");
            formChangeProduct.Show();
          

        }

    }
}
