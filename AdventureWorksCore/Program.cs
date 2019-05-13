using System;
using System.Linq;
using AdventureWorksCore.Models;
using Microsoft.EntityFrameworkCore;
namespace AdventureWorksCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AdventureWorksContext())
            {
                var query = context.Products.Where(x => x.ProductId == 316);
                foreach(var prodeuct in query)
                {
                    Console.WriteLine($"{prodeuct.ProductId} {prodeuct.Name}");
                    foreach(var i in prodeuct.ProductInventories)
                    {
                        Console.WriteLine($"\t{i.Shelf} {i.ModifiedDate}");

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
