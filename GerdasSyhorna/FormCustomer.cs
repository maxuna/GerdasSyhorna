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
        List<Button> buyButtons = new List<Button>();
        List<Label> nameLabel = new List<Label>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<Label> descriptionLabel = new List<Label>();
        List<Label> priceLabel = new List<Label>();
        List<NumericUpDown> antalNumeric = new List<NumericUpDown>();
        Label antal = new Label();
        List<TextBox> varukorg = new List<TextBox>();
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

                ((Products)Products[i]).Controls.Add((Label)antal);
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
            int index = buyButtons.IndexOf(btn);
            

            if (amountItems.Contains(index))
            {
                int i = amountItems.IndexOf(index);
                antalNumeric[index].Value++;
                namnVarukorg = Regex.Match(priceLabel[index].Text, @"\d+").Value;
                varukorg[i].Text = "x" + (antalNumeric[index].Value).ToString() + "  " + nameLabel[index].Text + " á" + "\t" + "\t" + (Int32.Parse(namnVarukorg)).ToString() + " Kr";
                amountItems.Remove(index);
                totalPrice += i * Int32.Parse(namnVarukorg);  
            }
            else
            {
                if (varukorg[0].Text == "Inga varor i kundvagnen.")
                {
                    namnVarukorg = Regex.Match(priceLabel[index].Text, @"\d+").Value;
                    varukorg[0].Text = "x" + antalNumeric[index].Value.ToString() + "  " + nameLabel[index].Text + " á" + "\t" + "\t" + (Int32.Parse(namnVarukorg)).ToString() + " Kr";
                }
                else
                {
                    TextBox vl = new TextBox();
                    varukorg.Add(vl);
                    panel1.Controls.Add((TextBox)varukorg[varukorg.Count - 1]);
                    namnVarukorg = Regex.Match(priceLabel[index].Text, @"\d+").Value;
                    varukorg[varukorg.Count - 1].Text = "x" + antalNumeric[index].Value.ToString() + "  " + nameLabel[index].Text + " á" + "\t" + "\t" + (Int32.Parse(namnVarukorg)).ToString() + " Kr";
                    varukorg[varukorg.Count - 1].Size = new Size(462, 15);
                    varukorg[varukorg.Count - 1].ReadOnly = true;
                    varukorg[varukorg.Count - 1].Location = new Point(0, yled);
                    yled += 25;
                    totalPrice += (int)(antalNumeric[index].Value) * Int32.Parse(namnVarukorg);
                }
            }
            amountItems.Add(index);
            totalPriceLabel.Text = totalPrice.ToString();
            
        }

    }
}
