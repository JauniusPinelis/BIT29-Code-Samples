// See https://aka.ms/new-console-template for more information
using ShopItemLists.Models;

Console.WriteLine("Hello, World!");

List<ShopItem> shopItems = new List<ShopItem>();

shopItems.Add(new ShopItem()
{
    Name = "Ice Cream",
    Price = 2.2M,
    Quantity = 10
});

shopItems.Add(new ShopItem()
{
    Name = "Candy",
    Price = 0.9M,
    Quantity = 3
});

shopItems.Add(new ShopItem()
{
    Name = "Cake",
    Price = 15.0M,
    Quantity = 0
});

shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwitch",
    Price = 3.0M,
    Quantity = 3,
    Expired = true
});

shopItems.Add(new ShopItem()
{
    Name = "Expired Sandwitch",
    Price = 3.0M,
    Quantity = 3,
    Expired = true
});

// Comment cntrl + K and Cntrl + C
// UnComment cntrl + K and Cntrl + U

//// You cannot simply print complex objects
////Console.WriteLine(shopItems);

//foreach (ShopItem item in shopItems)
//{
//    Console.WriteLine($"{item.Name} {item.Expired}");
//}

//// Using linq
//// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
//shopItems.ForEach(item => Console.WriteLine($"{item.Name} {item.Expired}"));


// Filtering

// Filter not Expired prodcuts
//List<ShopItem> notExpiredShopItems = new List<ShopItem>();

//foreach (var item in shopItems)
//{
//    if (item.Expired == false)
//    {
//        notExpiredShopItems.Add(item);
//    }
//}

//List<ShopItem> notExpiredShopItemsWithLinq = shopItems.Where(item => item.Expired == false).ToList();

//notExpiredShopItemsWithLinq.ForEach(item => Console.WriteLine($"{item.Name} {item.Expired}"));



// Select
// I want to get all unique names of shopItems

//List<string> uniqueNames = new List<string>();

//foreach (var shopItem in shopItems)
//{
//    var uniqueName = shopItem.Name;
//    if (!uniqueNames.Contains(uniqueName))
//    {
//        uniqueNames.Add(uniqueName);
//    }
//}

//List<string> uniqueNamesWithLinq = shopItems.Select(x => x.Name).Distinct().ToList();

//uniqueNamesWithLinq.ForEach(name => Console.WriteLine(name));

// Functional programming

//Get The first item by name that is not expired

//ShopItem firstShopItem = shopItems.Where(s => !s.Expired).OrderBy(s => s.Name).First();

//Console.WriteLine(firstShopItem.Name);

//Get The biggest quantity of an item
// There are many way to get
int largestQuantity = shopItems.OrderByDescending(s => s.Quantity).Select(s => s.Quantity).First();

Console.WriteLine(largestQuantity);

// Check if item named "Apple" exists

bool doesExist = shopItems.Any(si => si.Name.ToLower() == "apple");

// Get FirstItem where Quantity is more than 100

ShopItem item = shopItems.Where(i => i.Quantity > 100).FirstOrDefault();

if (item != null)
{
    Console.WriteLine(item.Name);
}

