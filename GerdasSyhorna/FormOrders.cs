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
                treeViewOrders.Nodes.Add(order.FirstName + " " + order.LastName);
                if (order.Status != null)
                treeViewOrders.Nodes[treeViewOrders.Nodes.Count - 1].Nodes.Add(order.Status.ToString());

                else
                    treeViewOrders.Nodes[treeViewOrders.Nodes.Count - 1].Nodes.Add("Ohanterad order");
            }

        }
    }
}
