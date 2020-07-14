using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine
{
    class MOBILE:Product
    {
        private readonly string _productType;
        private string _productName;
        public MOBILE(string Pname)
        {
            _productType = "Mobile";
            _productName = Pname;
            Process();
        }
        public override string ProductType
        {
            get { return _productType; }
        }
        public override string ProductName
        {
            get { return _productName; }
        }
        public void Process()
        {
            //Due to lack of Time not implementing actual method
            Console.WriteLine("Generate Packing Slip");
        }
    }
}
