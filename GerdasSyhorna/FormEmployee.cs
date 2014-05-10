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


            //sätter in rätt lager värde utifrån orderdetaljer
            database.SP_UpdUnitsOnOrder();
            
            
            //Stored proc som retunerar info ifrån produkttabellen
            var productCounts = database.SP_ProductCount(0, 0, 0).OutputValues;



            List<ComboBoxItem> SearchboxItems = new List<ComboBoxItem>();
            foreach (var item in listViewProducts.Columns)
            {
                comboBoxSearch.Items.Add((item as ColumnHeader).Text);
            }
            comboBoxSearch.SelectedIndex = 0;

          
            foreach (var item in productCounts)
            {
                if(item.Key == "rowCount")
                {
                    
                    labelP.Text += item.Value.ToString();
                }
                else if (item.Key == "rowCountWithImage")
                {
                    labelPWithImage.Text += item.Value.ToString();
                }
                else if (item.Key == "rowCountWithSupplier")
                {
                    labelPWithSupplier.Text += item.Value.ToString();
                }
               
            }


            foreach (var product in database.Products.All())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductName;
                lvi.SubItems.AddRange(new string[] { product.Category, product.Price.ToString(), product.UnitsInStock.ToString(), product.UnitsOnOrder.ToString()});
                lvi.Tag = new List<object> {product.SupplierId, product.ImageFile, product.ProductId};
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

                case "Produktnamn":
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
                lvi.Tag = new List<object> {product.SupplierId, product.ImageFile, product.ProductId};
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
            FormProduct formAddProduct = new FormProduct();
            
            formAddProduct.Show();
        }

        private void buttonChangeProduct_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count != 1)
            {
                return;
            }
            //hämtar den valda produktens id ifrån tabellen
            int productId = (int)((listViewProducts.SelectedItems[0].Tag as List<object>)[2]);
            
            FormProduct FormChangeProduct = new ChangeProduct(productId);
            FormChangeProduct.Show();
            

        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
        }









        





        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            dynamic specifiedproducts;

            if (textBoxSearch.Text != "")
                specifiedproducts = database.SP_ProductSearch(textBoxSearch.Text, comboBoxSearch.Text);

            else
                specifiedproducts = database.Products.All();

            listViewProducts.Items.Clear();

            foreach (var product in specifiedproducts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductName;
                lvi.SubItems.AddRange(new string[] { product.Category, product.Price.ToString(), product.UnitsInStock.ToString(), product.UnitsOnOrder.ToString() });
                lvi.Tag = new List<object> { product.SupplierId, product.ImageFile, product.ProductId };
                listViewProducts.Items.Add(lvi);
            }


        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }

    }
}
