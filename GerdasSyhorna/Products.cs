using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerdasSyhorna
{
    class Products : System.Windows.Forms.Panel
    {
        public int index;
        public string name;
        public string category;
        public object price;
        public short unitsInStock;
        public short unitsInOrder;
        public byte[] imageFile;
        public object supplierId;
        public string description;



        public Products(int index, string name, string category, object price, short unitsInStock, short unitsInOrder, int? supplierId, byte[] imageFile, string description)
        {
            this.index = index;
            this.name = name;
            this.category = category;
            this.price = price;
            this.unitsInStock = unitsInStock;
            this.unitsInOrder = unitsInOrder;
            this.imageFile = imageFile;
            this.supplierId = supplierId;
            this.description = description;
        }
        public Products(int index, string name, string category, object price, short unitsInStock, short unitsInOrder, int? supplierId, string description)
        {
            this.index = index;
            this.name = name;
            this.category = category;
            this.price = price;
            this.unitsInStock = unitsInStock;
            this.unitsInOrder = unitsInOrder;
            //this.imageFile = ;
            this.description = description;
        }

        public System.Windows.Forms.Button buyButtons = new System.Windows.Forms.Button();
        public System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label();
        public System.Windows.Forms.PictureBox pictureBoxes = new System.Windows.Forms.PictureBox();
        public System.Windows.Forms.Label descriptionLabel = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label priceLabel = new System.Windows.Forms.Label();
        public System.Windows.Forms.NumericUpDown antalNumeric = new System.Windows.Forms.NumericUpDown();
        





    }
}