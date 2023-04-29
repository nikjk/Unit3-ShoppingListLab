Dictionary<string, decimal> menu = new Dictionary<string, decimal>
{
    {"Berries", 2.99m},
    {"Grapes", 7.48m},
    {"Tomatoes", 2.54m},
    {"Lettuce", 1.99m},
    {"Bagels", 3.99m},
    {"Ham", 8.99m},
    {"Pepperoni", 4.39m},
    {"Milk", 1.20m},
    {"Bread", 2.50m},
    {"Eggs", 3.00m},
    {"Cheese", 4.00m},
    {"Butter", 2.00m},
    {"Yogurt", 1.50m},
    {"Cereal", 3.50m},
    {"Pasta", 2.20m},
    {"Rice", 1.80m},
    {"Tomato Sauce", 1.90m}
};

foreach (var item in menu)
{
    Console.WriteLine($"{item.Key}: ${item.Value}");
}

Console.WriteLine("What would you like to add to your shopping list?");

List<string> shoppinglist = new List<string>();

bool loop = true;

do
{
    string userinput = Console.ReadLine();

    if (menu.ContainsKey(userinput))
    {
        shoppinglist.Add(userinput);
    }
    else
    {
        Console.WriteLine("Sorry, that item is not on the menu.");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Your shopping list:");
    foreach (var item in shoppinglist)
    { 
        Console.WriteLine(item); 
    }

    Console.Write("Do you want to add another item? (yes/no): ");
    string response = Console.ReadLine();

    if (response.ToLower() != "yes")
    {
        loop = false;
    }

} while (loop);

Console.WriteLine();
Console.WriteLine();
decimal total = 0;
Console.WriteLine("Your shopping list:");
foreach (var item in shoppinglist)
{
    Console.WriteLine($"{item}: ${menu[item]}");
    total += menu[item];
}

Console.WriteLine($"Total price: ${total}");