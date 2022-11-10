using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../../products.json"))
            {
                string jsonstring = sr.ReadToEnd();
                Product[] products = JsonSerializer.Deserialize<Product[]>(jsonstring);

                Product maxProduct = products[0];
                foreach (Product e in products)
                {
                    if (e.Price>maxProduct.Price)
                    {
                        maxProduct = e;
                    }
                }
                Console.WriteLine($"{maxProduct.Cod} {maxProduct.Title} {maxProduct.Price}");
                Console.ReadKey();
            }    
        }
    }
}
