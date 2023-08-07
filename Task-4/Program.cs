using System.Net.Cache;

string Name;

byte[] Age;

bool IsMerried;


DisplayInfo(name: "Mavlonbek", age: 19, false);

static void DisplayInfo(string name, byte age, bool isMarried)
{
    Console.WriteLine($"Name: {name}\nAge: {age}\nIsMerried: {isMarried}");
}