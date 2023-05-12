int a = 1000, b = 2000, ans = a + b;
string hello = "Hello Welcome! ";
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

Console.Write(hello + ans + "\nEnter username: ");

string userName = Console.ReadLine();

Console.Write("Hi " + userName + "\nWhat brand of car do you like?\n");

for (int i = 0; i < cars.Length; i++)
{
    Console.Write(cars[i]);
    if (i != cars.Length - 1) Console.Write(", ");
    else continue;
}

//Run: dotnet run