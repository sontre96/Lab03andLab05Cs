using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Lab05
{
    class Cus_details
    {
        public string strName;

        public void getName()
        {
            Console.WriteLine("Enter your name :");
            strName = Console.ReadLine();
        }
    }
}


