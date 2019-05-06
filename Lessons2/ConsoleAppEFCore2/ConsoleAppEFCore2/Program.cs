//Examples for work with 1)EF Core, 2)Linq
using System;
using static System.Console;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Diagnostics;

namespace ConsoleAppEFCore2
{
    class Program
    {
        //------------------------------------------------------------------------------------------------------
        //EF Core examples
        static void QueringCategories()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Categories:");
                
                IQueryable<Category> cats = db.Categories.Include(c => c.Products);

                foreach (Category c in cats)
                {
                    WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
                }
            }
        }

        static void QueryProducts()
        {
            using(var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                WriteLine("Products:");
                string input;
                decimal price;
                do
                {
                    Write("Enter a price:");
                    input = ReadLine();
                } while (!decimal.TryParse(input, out price));

                IQueryable<Product> prods = db.Products
                    .Where(product => product.Cost > price)
                    .OrderByDescending(product => product.Cost);

                foreach(Product p in prods)
                {
                    WriteLine($"{p.ProductID}: {p.ProductName} costs { p.Cost:$#,##0.00} and has { p.Stock} units in stock.");
                }
            }
        }

        static void QueryWithLike()
        {
            using (var db = new Northwind())
            {
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Write("Enter a product name: ");
                string input = ReadLine();

                IQueryable<Product> prods = db.Products
                    .Where(p => EF.Functions.Like(p.ProductName, $"%{input}%"));

                foreach(Product item in prods)
                {
                    WriteLine($"{item.ProductName} has {item.Stock} units in stock. Discontinued? {item.Discontinued}");
                }
            }
        }

        static bool AddProduct(int categoryID, string productName, decimal? price)
        {
            using (var db = new Northwind())
            {
                var newProduct = new Product
                {
                    CategoryID = categoryID,
                    ProductName = productName,
                    Cost = price
                };

                db.Products.Add(newProduct);
                int affect = db.SaveChanges();
                return (affect == 1);
            }
        }

        static void ListProducts()
        {
            using(var db = new Northwind())
            {
                WriteLine("----------------------------------------------------------------------------");

                WriteLine("| ID | Product Name | Cost | Stock | Disc. |");

                WriteLine("----------------------------------------------------------------------------");

                foreach(var item in db.Products.OrderByDescending(p => p.Cost))
                {
                    WriteLine($"| {item.ProductID:000} | {item.ProductName, -35} | {item.Cost,8:$#,##0.00} | {item.Stock, 5} | {item.Discontinued} |");
                }
            }
        }

        static bool IncreaseProductPrice(string name, decimal amount)
        {
            using(var db = new Northwind())
            {
                Product updateProduct = db.Products.First(p => p.ProductName.StartsWith(name));
                updateProduct.Cost += amount;
                int affected = db.SaveChanges();
                return (affected == 1);
            }
        }

        static int DeleteProducts(string name)
        {
            using(var db = new Northwind())
            {
                IEnumerable<Product> products = db.Products.Where(p => p.ProductName.StartsWith(name));
                db.Products.RemoveRange(products);
                int affected = db.SaveChanges();
                return affected;
            }
        }

        //------------------------------------------------------------------------------------------------------
        //Linq examples
        static void LinqWithArrayOfStrings()
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angel", "Kevin", "Toby", "Creed" };

            var query = names.Where(name => name.Length > 4)
                .OrderBy(name => name.Length).ThenBy(name => name);

            foreach(string item in query)
            {
                WriteLine(item);
            }
        }

        static void LinqWithArrayOfStrings2()
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angel", "Kevin", "Toby", "Creed" };

            var query = from name in names where name.Length > 4 orderby name.Length, name select name;

            foreach (string item in query)
            {
                WriteLine(item);
            }
        }

        private static void Output(IEnumerable<string> cohort, string description = "")
        {
            if (!string.IsNullOrEmpty(description))
            {
                WriteLine(description);
            }
            Write(" ");
            WriteLine(string.Join(", ", cohort.ToArray()));
        }

        static void UseSequency()
        {
            var cohort1 = new string[] { "Rachel", "Gareth", "Jonathan", "George" };

            var cohort2 = new string[] { "Jack", "Stephen", "Daniel", "Jack", "Jared" };

            var cohort3 = new string[] { "Declan", "Jack", "Jack", "Jasmine", "Conor" };

            Output(cohort1, "Cohort 1");
            Output(cohort2, "Cohort 2");
            Output(cohort3, "Cohort 3");
            WriteLine();

            Output(cohort2.Distinct(), "cohort2.Distinct(): removes duplicates");
            Output(cohort2.Union(cohort3), "cohort2.Union(cohort3): combines and removes duplicates");
            Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3): combines but leaves duplicates");
            Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3): items that are in both sequences");
            Output(cohort2.Except(cohort3), "cohort2.Except(cohort3): removes items from the first sequence that are in the second sequence");
            Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matched with {c2}"), "cohort1.Zip(cohort2, (c1, c2) => $\"{c1} matched with {c2}\")" +
            ": matches items based on position in the sequence");
        }

        static void LinqWithEFCore()
        {
            using(var db = new Northwind())
            {
                var query = db.Products
                    .Where(product => product.Cost < 10M)
                    .OrderByDescending(product => product.Cost)
                    .Select(product => new
                    {
                        product.ProductID,
                        product.ProductName,
                        product.Cost
                    });

                WriteLine("Products that cost less than $10:");
                foreach(var item in query)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.Cost:$#,##0.00}");
                }
                WriteLine();
            }
        }

        static void LinqWithEFCore2()
        {
            using (var db = new Northwind())
            {
                var categories = db.Categories.Select(c => new { c.CategoryID, c.CategoryName }).ToArray();

                var products = db.Products.Select(p => new { p.ProductID, p.ProductName, p.CategoryID }).ToArray();

                var queryJoin = categories.Join(products,
                    category => category.CategoryID,
                    product => product.CategoryID,
                    (c, p) => new { c.CategoryName, p.ProductID, p.ProductName }
                    ).OrderBy(p => p.ProductID);

                foreach (var item in queryJoin)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} is in {item.CategoryName}");
                }
                WriteLine();
            }
        }

        static void LinqWithEFCore3()
        {
            using (var db = new Northwind())
            {
                var categories = db.Categories.Select(c => new { c.CategoryID, c.CategoryName }).ToArray();

                var products = db.Products.Select(p => new { p.ProductID, p.ProductName, p.CategoryID }).ToArray();

                var queryJoin = categories.GroupJoin(products,
                    category => category.CategoryID,
                    product => product.CategoryID,
                    (c, Products) => new { c.CategoryName, Products = Products.OrderBy(p => p.ProductName) });

                foreach (var item in queryJoin)
                {
                    WriteLine($"{item.CategoryName} has {item.Products.Count()} products");
                    foreach(var product in item.Products)
                    {
                        WriteLine($" {product.ProductName}");
                    }
                }
                WriteLine();
            }
        }

        static void UsePLINQ()
        {
            var watch = Stopwatch.StartNew();
            Write("Press ENTER to start: ");
            ReadLine();

            watch.Start();
            IEnumerable<int> numbers = Enumerable.Range(1, 2000_000_000);
            var squares = numbers.Select(number => number * 2).ToArray();
            watch.Stop();

            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed milliseconds.");
        }

        static void Main(string[] args)
        {
            //QueringCategories();
            //QueryProducts();
            //QueryWithLike(); 
            //AddProduct(6, "Bob's Burger", 500M);
            //IncreaseProductPrice("Bob", 20M);
            //int deleted = DeleteProducts("Bob");
            //WriteLine($"{deleted} product(s) were deleted");
            //ListProducts();
            //LinqWithArrayOfStrings();

            //UseSequency();
            //LinqWithEFCore();
            //LinqWithEFCore2();
            //LinqWithEFCore3();
            //LinqWithArrayOfStrings2();
            //UsePLINQ();
            ReadLine();
        }
    }
}
