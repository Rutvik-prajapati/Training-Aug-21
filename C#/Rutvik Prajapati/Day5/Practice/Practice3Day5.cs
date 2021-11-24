using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTask.Day5.Practice
{
    //3. Store a product information in map object. Key will be a product 
    //    item and value will be the price of that product.Search the 
    //    product by product name.
    class Practice3Day5
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("Book", 50);
            productList.Add("Box", 100);
            productList.Add("Pen", 20);
            productList.Add("pencil", 10);
            productList.Add("Power Bank", 550);

            
            foreach (var item in productList)
            {
                Console.WriteLine("Product Name : {0} And Price : {1}",item.Key,item.Value);
            }

            Console.WriteLine("\n Search By Product Name..");
            Console.WriteLine("Enter Product Name..");
            var productName = Console.ReadLine();
            if (productList.ContainsKey(productName))
            {
                Console.WriteLine("searched product name : {0} ",productName);
            }
            else
            {
                Console.WriteLine("Enter Valid Product name");
            }
            Console.ReadLine();
        }
    }
}
