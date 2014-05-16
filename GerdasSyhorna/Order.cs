using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Data;

namespace GerdasSyhorna
{
    static class Order
    {
        //public int OrderId { get; private set; }

        //public int CustomerId { get; set; }
        //public DateTime OrderDate { get; set; }
        //public string Status { get; set; }



        
        

        // productQuantityDiscount är en Dictionary<productId, Tuple<antal av produkten, rea på produkten>>
        public static void CreateOrder(int customerId, DateTime orderDate, Dictionary<int, Tuple<short, byte>> productQuantityDiscount)
        {
            var database = Database.OpenConnection(Resources.connectionString);

            database.Order.Insert(CustomerId: customerId, OrderDate: orderDate);

            

            OrderDetails orderDetails = new OrderDetails(productQuantityDiscount, database.SP_LastOrder().First().OrderId);
        }

        public static void RemoveOrder(int id)
        {
            var db = Database.OpenConnection(Resources.connectionString);
            db.OrderDetails.Delete(OrderId: id);
            db.Orders.Delete(OrderId: id);
            
        }

        public static void ChangeStatus(int id, string status)
        {
            var db = Database.OpenConnection(Resources.connectionString);
            db.Orders.UpdateByOrderId(OrderId: id, Status: status);
        }

        //Tar bort varor ifrån lagret utifrån ordern
        public static bool ImplementOrder(int orderId)
        {
            var db = Database.OpenConnection(Resources.connectionString);
            var orderDetails = db.OrderDetails.FindAllBy(OrderId: orderId);

            foreach (var detail in orderDetails)
            {
                //lagerantalet är mindre än var orderdetailen krävde
                if (db.SP_UnitsInStockDifference(detail.ProductId, detail.Quantity, 0).ReturnValue == 0)
                {
                    return false;
                }             
            }

            foreach (var detail in orderDetails)
            {
                //lagerantalet är mindre än var orderdetailen krävde
                db.RemoveUnitsInStock(detail.ProductId, detail.Quantity);
            }



            return true;
        }
    }

    class OrderDetails
    {
        //lägger in detaljer kring specifik order
        public OrderDetails(Dictionary<int, Tuple<short, byte>> pqd, int orderId)
        {
            var db = Database.OpenConnection(Resources.connectionString);

            foreach (var item in pqd)
            {
                db.OrderDetails.Insert(OrderId: orderId, Discount: item.Value.Item2, Quantity: item.Value.Item1, ProductId: item.Key);
            }
        }
    }
}
