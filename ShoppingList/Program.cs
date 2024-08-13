// menu
Dictionary<string, decimal> store = new Dictionary<string, decimal>();
store.Add("apple", 0.99m);
store.Add("banana", 0.59m);
store.Add("cauliflower", 1.59m);
store.Add("dragonfruit", 2.19m);
store.Add("Elderberry", 1.79m);
store.Add("figs", 2.09m);
store.Add("grapefruit", 1.99m);
store.Add("honeydew", 3.49m);

//cart
List<string> cart = new List<string>();

// start
Console.WriteLine("Welcome to the Grand Cirus Market!");
bool runProgram = true;
while (runProgram)
{

    Console.WriteLine(String.Format("{0,11} {1,11}", "Item", "Price"));
    Console.WriteLine(String.Format("{0,11} {1,11}", "===========", "==========="));
    foreach (KeyValuePair<string, decimal> kvp in store)
    {
        Console.WriteLine(String.Format("{0,11} {1,11}", $"{kvp.Key}", $"{kvp.Value}"));
    }
    Console.WriteLine("What item would you like to order?");
    string order = Console.ReadLine();
    if (store.ContainsKey(order))
    {
        Console.WriteLine($"Adding {order} to cart at {store[order]}.");
        cart.Add(order);
    }
    else
    {
        Console.WriteLine($"{order} not found in store.");
    }
    runProgram = GetContinue();
}
    Console.WriteLine("Thanks for your oder!");
    Console.WriteLine("Here's what you got:");
    decimal total = 0;
    foreach (string i in cart)
    {
        Console.WriteLine(String.Format("{0,-11} {1,11}", $"{i}", $"{store[i]}"));
        total = total + store[i];
    }
Console.WriteLine("=======================");
Console.WriteLine(string.Format("{0,-11} {1,11}", "Total is:", $"{total}"));



//methods
static bool GetContinue()
{
    bool result = true;
    while (true)
    {
        Console.WriteLine("Would you like to order anything else? (y/n)");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y" || choice == "yes")
        {
            result = true;
            break;
        }
        else if (choice == "n" || choice == "no")
        {
            result = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
    return result;
}