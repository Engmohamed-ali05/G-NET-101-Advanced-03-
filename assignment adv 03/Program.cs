using System.Drawing;

namespace assignment_adv_03
{
    internal class Program
    {
        static void Main(string[] args) {
            #region Q1 : assignment session 2 Task 03.2 — Transform Product
            /*


                        class Product
                    {
                        public int Id { get; set; }
                        public string Name { get; set; }
                        public string Category { get; set; }
                        public double Price { get; set; }
                        public int Stock { get; set; }
                    }

                    class Program
                    {
                        static List<Product> catalog = new List<Product>
            {
                new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
                };


                        static List<T> TransformProducts<T>(
                            List<Product> products,
                            Func<Product, T> function)
                        {
                            List<T> result = new List<T>();

                            foreach (Product p in products)
                            {
                                result.Add(function(p));
                            }

                            return result;
                        }

                        static void Main(string[] args)
                        {

                            Console.WriteLine("--- Summary List ---");

                            List<string> summary = TransformProducts(
                                catalog,
                                p => $"{p.Name} (${p.Price})"
                            );

                            foreach (string item in summary)
                            {
                                Console.WriteLine(item);
                            }

                            Console.WriteLine();


                            Console.WriteLine("--- Price Labels ---");

                            List<string> labels = TransformProducts(
                                catalog,
                                p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}"
                            );

                            foreach (string item in labels)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }

                        */
            #endregion

            #region Q2 : assignment session 2 Task 03.3 — Filter Product

            /*   class Product
           {
               public int Id { get; set; }
               public string Name { get; set; }
               public string Category { get; set; }
               public double Price { get; set; }
               public int Stock { get; set; }
           }

           class Program
           {
               static List<Product> catalog = new List<Product>
   {
       new Product { Id = 1, Name = "laptop", Category = "electronics", Price = 1200, Stock = 10 },
       new Product { Id = 2, Name = "phone", Category = "electronics", Price = 800, Stock = 25 },
       new Product { Id = 3, Name = "t--shirt", Category = "clothing", Price = 30, Stock = 100 },
       new Product { Id = 4, Name = "jeans", Category = "clothing", Price = 60, Stock = 50 },
       new Product { Id = 5, Name = "chocolate", Category = "food", Price = 5, Stock = 200 },
       new Product { Id = 6, Name = "coffee Beans", Category = "food   ", Price = 15, Stock = 80 },
       new Product { Id = 7, Name = "C# Book", Category = "books", Price = 45, Stock = 30 },
       new Product { Id = 8, Name = "novel", Category = "books", Price = 20, Stock = 60 },
       new Product { Id = 9, Name = "  headphones", Category = "electronics", Price = 150, Stock = 40 },
       new Product { Id = 10, Name = "jacket", Category = "clothing", Price = 90, Stock = 15 }
       };

               static List<Product> FilterProducts(
                   List<Product> products,
                   Predicate<Product> condition)
               {
                   List<Product> result = new List<Product>();

                   foreach (Product p in products)
                   {
                       if (condition(p))
                       {
                           result.Add(p);
                       }
                   }

                   return result;
               }

               static void Main(string[] args)
               {
                   Console.WriteLine("--- Low-Stock Alert ---");

                   List<Product> lowStock = FilterProducts(
                       catalog,
                       p => p.Stock < 20
                   );

                   foreach (Product p in lowStock)
                   {
                       Console.WriteLine(
                           $"[LOW STOCK] {p.Name}: only {p.Stock} left!"
                       );
                   }
               }
           }





               */



            #endregion


            #region Q1 :assigment 3
            /* 1- Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65


                 List<int> grades = new List<int>

                 {
                    85, 92, 78, 95, 88, 70, 100, 65

                 };*/
            #endregion

            #region Q2
            2- Print the collection, Count, first and last grade

                Console.WriteLine(string.Join(grades));

            Console.WriteLine("Count:" + grades.Count);
            Console.WriteLine("First Grade:" + grades.First());
            Console.WriteLine("Last Grade:" + grades.Last());

            #endregion









        }
    }
}
