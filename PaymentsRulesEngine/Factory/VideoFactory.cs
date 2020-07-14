using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine.Factory
{
    class VideoFactory : ProductFactory
    {
        private string _productName;
        public VideoFactory(string name)
        {
            _productName = name;
        }
        public override Product GetPayment()
        {
            return new Video(_productName);
        }
    }
}
