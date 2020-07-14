using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine
{
    class Book:Product
    {
        private readonly string _productType;
        private string _productName;
        public Book(string Pname)
        {
            _productType = "Book";
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
            Console.WriteLine("Generate Duplicate Packing Slip For royalty department");
        }
    }
}
