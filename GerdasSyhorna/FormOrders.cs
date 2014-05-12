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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            var db = Database.OpenConnection(Resources.connectionString);

            var orders = db.SP_OrdersWithCustomers();

            foreach (var order in orders)
            {
                if (order.Status != null)
                treeViewOrders.Nodes.Add(order.FirstName + " " + order.LastName + ":   " + order.Status);

                else
                    treeViewOrders.Nodes.Add(order.FirstName + " " + order.LastName + ":   Obehandlad order");

                var orderDetails = db.Orderdetails.FindAllBy(OrderId: order.OrderId);
                treeViewOrders.Nodes[treeViewOrders.Nodes.Count - 1].Tag = order.OrderId;

                foreach (var detail in orderDetails)
                {
                    var product = db.Products.FindAllBy(ProductId: detail.ProductId).First();
                    treeViewOrders.Nodes[treeViewOrders.Nodes.Count - 1].Nodes.Add( detail.Quantity + " st " + product.ProductName);
                }
            }

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
           
        }

     

        private void buttonRemoveOrder_Click(object sender, EventArgs e)
        {
            Order.RemoveOrder((int)treeViewOrders.SelectedNode.Tag);
            treeViewOrders.SelectedNode.Remove();
        }

        private void FormOrders_Activated(object sender, EventArgs e)
        {
            if (treeViewOrders.SelectedNode.Text.Contains("Behandlad"))
            {
                buttonUnTreated.Text = "Markera som obehandlad";
            }

            else if (treeViewOrders.SelectedNode.Text.Contains("Obehandlad"))
            {
                buttonUnTreated.Text = "Markera som behandlad";
            }

            else
            {
                buttonUnTreated.Text = "-";
            }
        }

        private void treeViewOrders_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }


        private void buttonUntreated_Click(object sender, EventArgs e)
        {
            Order.ChangeStatus((int)treeViewOrders.SelectedNode.Tag, "Obehandlad");
            treeViewOrders.SelectedNode.Text = treeViewOrders.SelectedNode.Text.Replace("Behandlad", "Obehandlad");
        }



        private void buttonTreated_Click_1(object sender, EventArgs e)
        {
            Order.ChangeStatus((int)treeViewOrders.SelectedNode.Tag, "Behandlad");
            treeViewOrders.SelectedNode.Text = treeViewOrders.SelectedNode.Text.Replace("Obehandlad", "Behandlad");
        }

      
    }
}
