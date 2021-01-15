using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT3.Helpers
{
    class CatagoryHelper
    {
        public void Insert(string desc)
        {
            var catagory = new Catagory()
            {
                desc = desc
            };

            var db = new IPT_A_2DbContext();

            db.Catagories.Add(catagory);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
