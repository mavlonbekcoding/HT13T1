using System.Drawing;
Console.WriteLine("hj");
var Malibu = new Malibu("Chevrolet",2015,"Black");
Malibu.Drive();

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
    public Malibu(string brand, int year,string color)
    { 
       base.Brand = brand;
       base.Year = year;
       base.Color = color;
    }
    public override string Show()
    {
        return $"Brendi: {Brand}\nYear: {Year}\nColor{Color}\nPassangers: {Passengers}\nMaxSpeed{MaxSpeed}";
    }
    public override void Drive()
    {
        int Speed = 0;
        while(Speed < 150)
        {
            Console.WriteLine(Show());
            Console.WriteLine("Speed "+ Speed  );
            Speed += rand.Next(1, 10);
            Console.Clear();
            Thread.Sleep(1000);
        }
    }
}

public class Captiva : Car
{
    public static int Passengers = 5;
    public readonly int MaxSpeed = 150;

    public Captiva(string brand, int year, string color)
    {
        Brand = brand;
        Year = year;
        Color = color;
    }
    public override string Show()
    {
        return $"Brendi: { Brand}\nYear: { Year}\nColor{ Color}\nPassangers: { Passengers}\nMaxSpeed: { MaxSpeed}";
    }
    public override void Drive()
    {
        throw new NotImplementedException();
    }
}