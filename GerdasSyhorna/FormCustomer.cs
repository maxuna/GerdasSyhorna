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
    public partial class FormCustomer : Form
    {

        List<PictureBox> pbProducts = new List<PictureBox>();

        public FormCustomer()
        {
            InitializeComponent();

            
            pbProducts.AddRange(new PictureBox[]{pictureBoxProduct1, pictureBoxProduct2});

            var database = Database.OpenConnection(Resources.connectionString);
            foreach (var item in database.Products.All())
            {
                if (item.ImageFile != null)
                    pictureBoxProduct1.Image = ImageConverter.ImageFromByteArray(item.ImageFile);
            }
        }

            

    }
}
