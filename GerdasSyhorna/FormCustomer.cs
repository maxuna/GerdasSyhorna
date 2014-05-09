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
        int i = 0;

        public FormCustomer()
        {
            InitializeComponent();

            List<Products> Products = new List<GerdasSyhorna.Products>();
            List<Button> buyButtons = new List<Button>();
            List<Label> nameLabel = new List<Label>();

            var database = Database.OpenConnection(Resources.connectionString);
            var asas = database.Products;

            foreach (var item in database.Products.All())
            {
                Products p = new Products(item.ProductId, item.ProductName, item.Category, item.Price, item.UnitsInStock, item.UnitsOnOrder, item.SupplierId, item.ImageFile, item.Description);
                Products.Add(p);
                Button b = new Button();
                buyButtons.Add(b);
                Label l = new Label();
                nameLabel.Add(l);

                flowLayoutPanel1.Controls.Add(((Products)Products[i]));
                (((Products)Products[i]).Height) = 140;
                (((Products)Products[i]).Width) = 900;
                (((Products)Products[i]).BorderStyle) = BorderStyle.Fixed3D;

                ((Products)Products[i]).Controls.Add(((Button)buyButtons[i]));
                (((Button)buyButtons[i]).Height) = 75;
                (((Button)buyButtons[i]).Width) = 140;
                (((Button)buyButtons[i]).Location) = new Point(720, 35);
                (((Button)buyButtons[i]).Image) = Image.FromFile("../../Images/Buy_Button.png");
                ((Button)buyButtons[i]).Click += new EventHandler(buyButton_Click);

                ((Products)Products[i]).Controls.Add(((Label)nameLabel[i]));
                ((Label)nameLabel[i]).Text = "bajs";
                ((Label)nameLabel[i]).Location = new Point(140, 5);
                ((Label)nameLabel[i]).Font = new Font("Times New Roman", 12.0F);
                ((Label)nameLabel[i]).AutoSize = true;
                i++;
            }

        }

    }
}
