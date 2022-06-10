using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Lab05
{
    class InvalidInput : ApplicationException
    {
        public InvalidInput() : base("enter a number greater than Zero") {}
    }
}
