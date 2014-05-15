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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            buttonRemoveOrder.BackColor = Color.LightSalmon;
            buttonEndOrder.BackColor = Color.LightGreen;

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
            if (treeViewOrders.SelectedNode == null)
            {
                return;
            }

            MessageBox.Show("Är du säker på att du vill ta bort ordern?", "", MessageBoxButtons.YesNo);
            Order.RemoveOrder((int)treeViewOrders.SelectedNode.Tag);
            treeViewOrders.SelectedNode.Remove();
        }

        private void FormOrders_Activated(object sender, EventArgs e)
        {
            
        }

        private void treeViewOrders_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }



        private void buttonEndOrder_Click(object sender, EventArgs e)
        {
            if (treeViewOrders.SelectedNode == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Är du säker på att du vill avsluta ordern?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
        }

      
    }
}
