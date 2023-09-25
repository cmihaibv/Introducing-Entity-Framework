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

AddItemToDatabase("Bolognese Spaghetti", 9.99M);
AddItemToDatabase("Pizza Margherita", 12.99M);

context.SaveChanges();