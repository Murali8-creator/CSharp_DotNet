using EntityFrameworkExample.Data;
using EntityFrameworkExample.Models;


using PizzaContext context = new PizzaContext();

//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};

//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};

//context.Products.Add(deluxeMeat);

//context.SaveChanges();


//var products = context.Products
//                       .Where(p => p.Price > 10.0M)
//                       .OrderBy(p => p.Name); // fluent-api syntax

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;//linq syntax


foreach (Product p in products)
{
    Console.WriteLine($"Id : {p.Id}");
    Console.WriteLine($"Name : {p.Name}");
    Console.WriteLine($"Price : {p.Price}");
    Console.WriteLine(new string('-', 20));

}