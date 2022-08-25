using OrderForProductsWithDb.Data;
using OrderForProductsWithDb.Models;


// Create

            using OrderForProductsContext context = new OrderForProductsContext();

//Product laptop = new Product()
//{
//    Name = "HP Pavillion 15",
//    Price = 420M
//};

//context.Products.Add(laptop);

//Product phone = new Product()
//{
//    Name = "Samsung Galaxy A9 Star",
//    Price = 190M
//};

//context.Products.Add(phone);
//context.SaveChanges();






// Update

//var pavillion = context.Products.Where(x => x.Name == "HP Pavillion 15").First();

//if (pavillion is Product)
//{

//    pavillion.Price = 800M;
//}
//context.SaveChanges();


// Delete


var product = context.Products.Where(x => x.Name == "HP Pavillion 15").FirstOrDefault();

if (product is Product)
{
    context.Remove(product);
}
context.SaveChanges();


// Read

foreach (var con in context.Products)
            {
                Console.WriteLine($"{con.Id}, {con.Name},  {con.Price}");
            }
