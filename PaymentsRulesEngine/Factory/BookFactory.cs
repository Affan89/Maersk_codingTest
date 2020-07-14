using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    class BookFactory : ProductFactory
    {
        private string _productName;
        public BookFactory(string name)
        {
            _productName = name;
        }
        public override Product GetPayment()
        {
            return new Book(_productName);
        }
    }
}
