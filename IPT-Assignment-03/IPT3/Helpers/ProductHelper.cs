using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT3.Helpers
{
    class ProductHelper
    {
        public void Insert(string name, int price, int catagoryId)
        {
            var product = new Product()
            {
                name = name,
                price = price,
                catagoryId = catagoryId
            };

            var db = new IPT_A_2DbContext();

            db.Products.Add(product);
            db.SaveChanges();
            db.Dispose();
        }
    }
}