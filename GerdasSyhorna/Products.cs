using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerdasSyhorna
{
    class Products : System.Windows.Forms.Label
    {
        public int index;
        public int name;
        public string category;
        public double price;
        public int unitsInStock;
        public int unitsInOrder;
        public byte[] imageFile;
        public string description;


        public Products(int index, int name, string category, double price, int unitsInStock, int unitsInOrder, byte[]imageFile, string description)
        { 
            this.index = index;
            this.name = name;
            this.category = category;
            this.price = price;
            this.unitsInStock = unitsInStock;
            this.unitsInOrder = unitsInOrder;
            this.imageFile = imageFile;
            this.description = description;
        }
        public Products(int index, int name, string category, double price, int unitsInStock, int unitsInOrder, string description)
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






    }
}
