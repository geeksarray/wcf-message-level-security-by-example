using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindApp.ProductServiceRef; 

namespace NorthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsClient client = new ProductsClient();
            string cateName = client.GetCategoryName(1);
            Console.WriteLine(cateName);
            Console.Read();
        }
    }
}
