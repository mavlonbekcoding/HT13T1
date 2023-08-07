using System.Globalization;

Console.WriteLine("Massiv o'lchamini kiriting:");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i+1} - elementni kiriting: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
FindMinMax(numbers);

static void FindMinMax(params int[] numbers)
{
    Console.WriteLine($"Max: {numbers.Max()}\nMin: {numbers.Min()}");
}