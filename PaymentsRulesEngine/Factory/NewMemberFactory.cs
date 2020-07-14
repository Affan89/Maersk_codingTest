using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    class NewMemberFactory : ProductFactory
    {
        private string _productName;
        public NewMemberFactory(string name)
        {
            _productName = name;
        }
        public override Product GetPayment()
        {
            return new NewMembership(_productName);
        }
    }
}
