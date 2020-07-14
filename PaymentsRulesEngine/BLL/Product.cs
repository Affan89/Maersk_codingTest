using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine
{
    abstract class Product
    {
        public abstract string ProductType { get; }
        public abstract string ProductName { get; }
    }
}
