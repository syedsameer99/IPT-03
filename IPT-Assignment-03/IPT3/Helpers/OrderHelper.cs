using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT3.Helpers
{
    class OrderHelper
    {
        public void Insert(int customerId, int productId, int quentity)
        {
            var order = new Order()
            {
                CustomerId = customerId,
                ProductId = productId,
                Qty = quentity
            };

            var db = new IPT_A_2DbContext();

            db.Orders.Add(order);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
