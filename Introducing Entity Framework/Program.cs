using IntroducingEntityFramework.Data;
using IntroducingEntityFramework.Models;

using IntroducingEntityFrameworkContext context = new IntroducingEntityFrameworkContext();


//Use this function to add a new item into the Products table.
void AddItemToDatabase(String productName, decimal productPrice)
{

    Product menuItem = new Product()
    {
        Name = productName,
        Price = productPrice
    };
    context.Products.Add(menuItem);
}

//AddItemToDatabase("Bolognese Spaghetti", 9.99M);
//AddItemToDatabase("Pizza Margherita", 12.99M);

//context.SaveChanges();

//Search method (looking for items above 10.00 in price) using LINQ
//var products = from product in context.Products
//               where product.Price >10.00M
//               orderby product.Name
//               select product;

//foreach(Product p in products)
//{
//    Console.WriteLine($"ID:     {p.Id}");
//    Console.WriteLine($"Name:   {p.Name}");
//    Console.WriteLine($"Price:  {p.Price}");
//    Console.WriteLine(new string('-', 20));
//}

