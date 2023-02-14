using System;
using System.Collections.Generic;
using Strategy_p.Abstractions.Implementation;
using Strategy_p.Domain.Enums;

namespace Strategy_p
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, ProductTitle = "Pen", Price = 30, CreatedDate = DateTime.Now },
                new Product() { Id = 3, ProductTitle = "Notebook", Price = 100, CreatedDate = DateTime.Now },
                new Product() { Id = 4, ProductTitle = "Book", Price = 200, CreatedDate = DateTime.Now },
            };

            Console.WriteLine("Please select a sort type : ");
            Console.WriteLine("Sort Id By Asc : 0");
            Console.WriteLine("Sort Id By Desc : 1");
            Console.WriteLine("Sort Name By Asc : 2");
            Console.WriteLine("Sort Name By Desc : 3");
            Console.WriteLine("Sort Price By Asc : 4");
            Console.WriteLine("Sort Price By Desc : 5");

            int enumValue = Convert.ToInt32(Console.ReadLine());
            var selectionEnum = (SortSelectionEnum)enumValue;
            Console.WriteLine($"Selected Sort Type : {enumValue}".ToString());
            var context = new Context();
            List<Product> result = new List<Product>();
            switch (selectionEnum)
            {
                case SortSelectionEnum.IdAscending:
                    context.SetStrategy(new SortByIdAscStrategy());
                    result = context.Sort(products);
                    break;
                case SortSelectionEnum.IdDescending:
                    context.SetStrategy(new SortByIdDescStrategy());
                    result = context.Sort(products);
                    break;

                case SortSelectionEnum.NameDescending:
                    context.SetStrategy(new SortByNameDescStrategy());
                    result = context.Sort(products);
                    break;

                case SortSelectionEnum.NameAscending:
                    context.SetStrategy(new SortByNameAscStrategy());
                    result = context.Sort(products);
                    break;

                case SortSelectionEnum.PriceAscending:
                    context.SetStrategy(new SortByPriceAscStrategy());
                    result = context.Sort(products);
                    break;

                case SortSelectionEnum.PriceDescending:
                    context.SetStrategy(new SortByPriceDescStrategy());
                    result = context.Sort(products);
                    break;
            }
            foreach (var listItem in result)
            {
                Console.WriteLine("Id : " + listItem.Id);
                Console.WriteLine("Title : " + listItem.ProductTitle);
                Console.WriteLine("Price : " + listItem.Price);
                Console.WriteLine("----------------------");
            }

            Console.ReadLine();
        }
    }
}
