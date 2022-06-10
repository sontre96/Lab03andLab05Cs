using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Lab05
{
    class Grocery_items
    {
        public void Ord_grocery()
        {
            Cus_details objCust1 = new Cus_details();
            objCust1.getName();
            Console.WriteLine("Hello {0} ", objCust1.strName);
            Console.WriteLine("You have ordered grocery items");
        }
    }

    class Bakery_items
    {
        public void Ord_bakery()
        {
            Cus_details objCust2 = new Cus_details();
            objCust2.getName();
            Console.WriteLine("Hello {0} ", objCust2.strName);
            Console.WriteLine("You have ordered  bakery items");
        }
    }
}
