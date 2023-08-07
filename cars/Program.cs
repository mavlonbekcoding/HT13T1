using System.Drawing;
var Malibu = new Malibu("Chevrolet", 2015, "Black");
Malibu.Drive();
var Cobalt = new Captiva("Chevrolet", 2015, "Black");
Cobalt.Drive();

public abstract class Car
{
    public string Brand { get; init; }
    public int Year { get; init; }
    public string Color { get; set; }
    public Random rand = new Random();
    public virtual string Show()
    {
        return $"Brendi: {Brand}\nYear: {Year} Color: {Color}";
    }
    public abstract void Drive();
}
public class Malibu : Car
{
    public static int Passengers = 5;
    public readonly int MaxSpeed = 150;
    public static int Sec = 0;
    public Malibu(string brand, int year, string color)
    {
        base.Brand = brand;
        base.Year = year;
        base.Color = color;
    }
    public override string Show()
    {
        return $"Brendi: {Brand}\nYear: {Year}\nColor: {Color}\nPassangers: {Passengers}\nMaxSpeed: {MaxSpeed}";
    }
    public override void Drive()
    {
        int Speed = 0;
        while (Speed < 150)
        {
            Console.WriteLine(Show());
            Console.WriteLine("Speed " + Speed);
            Speed += rand.Next(1, 10);
            Thread.Sleep(1000);
            Console.Clear();

        }
    }
}

public class Captiva : Car
{
    public static int Passengers = 5;
    public readonly int MaxSpeed = 150;
    public static int Sec = 0;

    public Captiva(string brand, int year, string color)
    {
        base.Brand = brand;
        base.Year = year;
        base.Color = color;
    }
    public override string Show()
    {
        return $"Brendi: {Brand}\nYear: {Year}\nColor{Color}\nPassangers: {Passengers}\nMaxSpeed: {MaxSpeed}";
    }
    public override void Drive()
    {
        int Speed = 0;
        while (Speed < 150)
        {
            Console.WriteLine(Show());
            Console.WriteLine("Speed " + Speed);
            Speed += rand.Next(1, 10);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}