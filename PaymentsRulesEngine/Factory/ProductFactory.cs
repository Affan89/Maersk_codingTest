using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    abstract class ProductFactory
    {
        public abstract Product GetPayment();
    }
}
