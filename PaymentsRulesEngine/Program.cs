using PaymentsRulesEngine.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory = null;
            Console.Write("Enter the product type you would like to process: ");
            string pro = Console.ReadLine();
            Console.Write("Enter the product name you would like to process: ");
            string name = Console.ReadLine();

            Console.WriteLine("*********************");
            switch (pro.ToLower())
            {
                case "mobile":
                    factory = new MobileFactory(name.ToLower());
                    break;
                case "book":
                    factory = new BookFactory(name.ToLower());
                    break;
                case "video":
                    factory = new VideoFactory(name.ToLower());
                    break;
                case "new membership":
                    factory = new NewMemberFactory(name.ToLower());
                    break;
                case "upgrade membership":
                    factory = new UpgradeMemberFactory(name.ToLower());
                    break;
                default:
                    break;
            }
            if (factory != null)
            {
                Product prod = factory.GetPayment();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Product need to be added to repository");
                Console.ReadLine();
            }
        }
    }
}
