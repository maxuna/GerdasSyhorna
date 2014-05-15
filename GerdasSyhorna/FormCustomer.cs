using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple.Data;

namespace GerdasSyhorna
{
    public partial class FormCustomer : Form
    {
        int i = 0;
        List<Products> Products = new List<GerdasSyhorna.Products>();
        List<TextBox> varukorg = new List<TextBox>();
        Label antal = new Label();
        int yled = 0;
        List<int> amountItems = new List<int>();
        int totalPrice = 0;
        string namnVarukorg = "";
       
        public FormCustomer()
        {
            InitializeComponent();

            var database = Database.OpenConnection(Resources.connectionString);
            var asas = database.Products;




            foreach (var item in database.Products.All())
            {
                Products p = new Products(item.ProductId, item.ProductName, item.Category, item.Price, item.UnitsInStock, item.UnitsOnOrder, item.SupplierId, item.ImageFile, item.Description);
                Products.Add(p);
               
                

                flowLayoutPanel1.Controls.Add(((Products)Products[i]));
                (((Products)Products[i]).Height) = 200;
                (((Products)Products[i]).Width) = 900;
                (((Products)Products[i]).BorderStyle) = BorderStyle.Fixed3D;

                ((Products)Products[i]).Controls.Add(Products[i].buyButtons);
                (Products[i].buyButtons).Height = 75;
                (Products[i].buyButtons).Width = 140;
                (Products[i].buyButtons).Location = new Point(750, 115);
                (Products[i].buyButtons).Image = Image.FromFile("../../Images/Buy_Button.png");
                (Products[i].buyButtons).Tag = i;
                (Products[i].buyButtons).Click += new EventHandler(buyButton_Click);

                ((Products)Products[i]).Controls.Add(Products[i].nameLabel);
                (Products[i].nameLabel).Text = item.ProductName;
                (Products[i].nameLabel).Location = new Point(205, 5);
                (Products[i].nameLabel).Font = new Font("Times New Roman", 20.0F);
                (Products[i].nameLabel).AutoSize = true;
                
                ((Products)Products[i]).Controls.Add(Products[i].pictureBoxes);
                (Products[i].pictureBoxes).Location = new Point(5, 5);
                (Products[i].pictureBoxes).Size = new Size(200, 200);
                //((PictureBox)pictureBoxes[i]).Image = ImageConverter.ImageFromByteArray(item.imageFile);
                (Products[i].pictureBoxes).BorderStyle = BorderStyle.FixedSingle;

                ((Products)Products[i]).Controls.Add(Products[i].descriptionLabel);
                (Products[i].descriptionLabel).Width = 340;
                (Products[i].descriptionLabel).Location = new Point(205, 40);
                (Products[i].descriptionLabel).Text = Products[i].description + Environment.NewLine + Environment.NewLine + "Antal kvar i lager: " + Products[i].unitsInStock;
                (Products[i].descriptionLabel).BorderStyle = BorderStyle.FixedSingle;
                (Products[i].descriptionLabel).AutoSize = true;

                ((Products)Products[i]).Controls.Add(Products[i].priceLabel);
                (Products[i].priceLabel).Location = new Point(650, 5);
                (Products[i].priceLabel).Font = new Font("Times New Roman", 20.0F);
                (Products[i].priceLabel).Text = "Pris: " + Products[i].price.ToString() + "kr";
                (Products[i].priceLabel).AutoSize = true;

                ((Products)Products[i]).Controls.Add((Label)antal);
                antal.Location = new Point(650, 40);
                antal.AutoSize = true;
                antal.Text = "Antal: ";
                
                ((Products)Products[i]).Controls.Add(Products[i].antalNumeric);
                (Products[i].antalNumeric).Location = new Point(750, 40);
                (Products[i].antalNumeric).Value = 1;
                (Products[i].antalNumeric).Minimum = 1;
                (Products[i].antalNumeric).Maximum = item.UnitsInStock;

                i++;
            }
            
            TextBox vl = new TextBox();
            varukorg.Add(vl);
            panel1.Controls.Add((TextBox)varukorg[0]);
            varukorg[0].Text = "Inga varor i kundvagnen.";
            varukorg[0].Size = new Size(462, 15);
            varukorg[0].ReadOnly = true;
            yled += 25;

        }
        public void buyButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var index = btn.Tag;
            if (amountItems.Count == 0)
            {
                varukorg[0].Text = (Products[(int)index]).antalNumeric.Value.ToString() + "x " +  (Products[(int)index]).nameLabel.Text + "\t" + (Products[(int)index]).price.ToString() + "Kr";
                amountItems.Add((int)index);
                //totalPrice = ((Products[(int)index]).antalNumeric.Value) * ((Products[(int)index]).price);
            }
            else
            {
                if (amountItems.Contains((int)index))
                {
                   int i = amountItems.IndexOf((int)index);
                   Products[i].antalNumeric.Value++; 
                   varukorg[i].Text = (Products[(int)index]).antalNumeric.Value.ToString() + "x " + (Products[(int)index]).nameLabel.Text + "\t" + (Products[(int)index]).price.ToString() + "Kr";

                    
                }
                else
                {
                    TextBox vl = new TextBox();
                    varukorg.Add(vl);
                    panel1.Controls.Add((varukorg[varukorg.Count-1]));
                    varukorg[varukorg.Count-1].Text = (Products[(int)index]).antalNumeric.Value.ToString() + "x " + (Products[(int)index]).nameLabel.Text + "\t" + (Products[(int)index]).price.ToString() + "Kr";
                    varukorg[varukorg.Count-1].Size = new Size(462, 15);
                    varukorg[varukorg.Count-1].ReadOnly = true;
                    varukorg[varukorg.Count - 1].Location = new Point(0,yled);
                    yled += 25;
                    amountItems.Add((int)index); 
                }
            }

            



             
        }

    }
}
