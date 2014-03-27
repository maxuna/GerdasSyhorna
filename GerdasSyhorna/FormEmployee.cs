﻿using System;
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
                    table = database.Products.All().OrderByPrice();
                    break;
                    
                case "Antal på order":
                    table = database.Products.All().OrderByUnitsOnOrder();
                    break;

                case "Kategori":
                    table = database.Products.All().OrderByCategory();
                    break;

                case "Antal i lager":
                    table = database.Products.All().OrderByUnitsInStock();
                    break;

                case "Namn":
                    table = database.Products.All().OrderByProductName();
                    break;
            }

            

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
                    var supplierRow = database.SupplierFromId(supplierId).First();
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
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.Show();
        }
    }
}
