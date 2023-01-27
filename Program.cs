Console.WriteLine("What number do you want to see the price of? ");

Console.WriteLine("1 - Rope");         // Possibily change this to for loop to reduce the lines of code. 
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");


int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Rope is 10 Gold");
        break;

    case 2:
        Console.WriteLine("Torches are 15 Gold");
        break; 
    case 3:
    Console.WriteLine("Climbing equipment is 25 Gold");
        break;
    case 4:
    Console.WriteLine("Clean Water is 1 Gold");
        break; 
    case 5:
    Console.WriteLine("Machete is 20 Gold");
        break;
    case 6:
    Console.WriteLine("Canoe is 200 Gold");
        break;
    case 7:
        Console.WriteLine("Food Supplies are 1 Gold");
        break;

    default:
        Console.WriteLine("Please choose another item! ");
        break;
}