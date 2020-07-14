using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    class UpgradeMemberFactory : ProductFactory
    {
        private string _productName;
        public UpgradeMemberFactory(string name)
        {
            _productName = name;
        }
        public override Product GetPayment()
        {
            return new UpgradeMembership(_productName);
        }
    }
}
