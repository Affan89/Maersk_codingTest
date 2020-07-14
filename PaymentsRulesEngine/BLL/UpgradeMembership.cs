using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine
{
    class UpgradeMembership : Product
    {
        private readonly string _productType;
        private string _productName;
        public UpgradeMembership(string Pname)
        {
            _productType = "Upgrade Membership";
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
            Console.WriteLine("Upgraded membership");
            Console.WriteLine("Email Sent");
        }
    }
}
