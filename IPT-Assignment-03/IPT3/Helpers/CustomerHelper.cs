using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT3.Helpers
{
    class CustomerHelper
    {
        public void Insert(string name, string address, string email)
        {
            var customer = new Customer()
            {
                Name = name,
                Email = email,
                address = address
            };

            var db = new IPT_A_2DbContext();

            db.Customers.Add(customer);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
