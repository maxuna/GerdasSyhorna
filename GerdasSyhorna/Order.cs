using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data;

namespace GerdasSyhorna
{
    class Order
    {
        //public int OrderId { get; private set; }

        //public int CustomerId { get; set; }
        //public DateTime OrderDate { get; set; }
        //public string Status { get; set; }


        public Order()
        {

        }

        
        public void CreateOrder(int customerId, DateTime orderDate, Dictionary<string, short> productsAndQuantity)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            database.Order.Insert(CustomerId: customerId, OrderDate: orderDate);

            OrderDetails orderDetails = new OrderDetails(productsAndQuantity);
        }
    }

    class OrderDetails : Order
    {
        public OrderDetails(Dictionary<string, short> paq)
        {
            foreach (var item in paq)
            {
                
            }
        }
    }
}
