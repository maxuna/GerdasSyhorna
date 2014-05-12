using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            List<Label> descriptionLabel = new List<Label>();
            List<Label> priceLabel = new List<Label>();
            List<NumericUpDown> antalNumeric = new List<NumericUpDown>();
            Label antal = new Label();
            
            var database = Database.OpenConnection(Resources.connectionString);
            var asas = database.Products;

            

            foreach (var item in database.Products.All())
            {
                Products p = new Products(item.ProductId, item.ProductName, item.Category, item.Price, item.UnitsInStock, item.UnitsOnOrder, item.SupplierId, item.ImageFile, item.Description);
                Products.Add(p);
                Button b = new Button();
                buyButtons.Add(b);
                Label nl = new Label();
                nameLabel.Add(nl);
                PictureBox pb = new PictureBox();
                pictureBoxes.Add(pb);
                Label dl = new Label();
                descriptionLabel.Add(dl);
                Label pl = new Label();
                priceLabel.Add(pl);
                NumericUpDown an = new NumericUpDown();
                antalNumeric.Add(an);

                flowLayoutPanel1.Controls.Add(((Products)Products[i]));
                (((Products)Products[i]).Height) = 200;
                (((Products)Products[i]).Width) = 900;
                (((Products)Products[i]).BorderStyle) = BorderStyle.Fixed3D;

                ((Products)Products[i]).Controls.Add(((Button)buyButtons[i]));
                (((Button)buyButtons[i]).Height) = 75;
                (((Button)buyButtons[i]).Width) = 140;
                (((Button)buyButtons[i]).Location) = new Point(750, 115);
                (((Button)buyButtons[i]).Image) = Image.FromFile("../../Images/Buy_Button.png");
                ((Button)buyButtons[i]).Click += new EventHandler(buyButton_Click);

                ((Products)Products[i]).Controls.Add(((Label)nameLabel[i]));
                ((Label)nameLabel[i]).Text = item.ProductName;
                ((Label)nameLabel[i]).Location = new Point(205, 5);
                ((Label)nameLabel[i]).Font = new Font("Times New Roman", 20.0F);
                ((Label)nameLabel[i]).AutoSize = true;

                ((Products)Products[i]).Controls.Add(((PictureBox)pictureBoxes[i]));
                ((PictureBox)pictureBoxes[i]).Location = new Point(5, 5);
                ((PictureBox)pictureBoxes[i]).Size = new Size(200, 200);
                //((PictureBox)pictureBoxes[i]).Image = ImageConverter.ImageFromByteArray(item.imageFile);
                ((PictureBox)pictureBoxes[i]).BorderStyle = BorderStyle.FixedSingle;

                ((Products)Products[i]).Controls.Add(((Label)descriptionLabel[i]));
                ((Label)descriptionLabel[i]).Width = 340;
                ((Label)descriptionLabel[i]).Location = new Point(205, 40);
                ((Label)descriptionLabel[i]).Text = item.Description + Environment.NewLine + Environment.NewLine + "Antal kvar i lager: " + item.UnitsInStock;
                ((Label)descriptionLabel[i]).BorderStyle = BorderStyle.FixedSingle;
                ((Label)descriptionLabel[i]).AutoSize = true;

                ((Products)Products[i]).Controls.Add(((Label)priceLabel[i]));
                ((Label)priceLabel[i]).Location = new Point(650, 5);
                ((Label)priceLabel[i]).Font = new Font("Times New Roman", 20.0F);
                ((Label)priceLabel[i]).Text = "Pris: " + item.price.ToString() + "kr";
                ((Label)priceLabel[i]).AutoSize = true;

                ((Products)Products[i]).Controls.Add(antal);
                antal.Location = new Point(650, 40);
                antal.AutoSize = true;
                antal.Text = "Antal: ";
                
                ((Products)Products[i]).Controls.Add((NumericUpDown)antalNumeric[i]);
                ((NumericUpDown)antalNumeric[i]).Location = new Point(750, 40);
                ((NumericUpDown)antalNumeric[i]).Value = 1;
                ((NumericUpDown)antalNumeric[i]).Minimum = 1;
                ((NumericUpDown)antalNumeric[i]).Maximum = item.UnitsInStock;

                


                i++;
            }


        }
        

    }
}
