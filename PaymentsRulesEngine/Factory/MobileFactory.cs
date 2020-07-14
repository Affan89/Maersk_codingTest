using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    
    class MobileFactory:ProductFactory
    {
        private string _productName;
        public MobileFactory(string name)
        {
            _productName = name;
        }
        public override Product GetPayment()
        {
            return new MOBILE(_productName);
        }
    }
}
