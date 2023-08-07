using System;

class Spaceship
{
     public string Name { get; init; }

     public int Fuel { get; private set; }

     public double Speed { get; set; }

     private string _trajectory;
    public string Trajectory
    {
        set
        {
            _trajectory = value;
            Console.WriteLine($"New trajectory set: {_trajectory}");
        }
    }

    public Spaceship(string name, int fuel, double speed)
    {
        Name = name;
        Fuel = fuel;
        Speed = speed;
    }
}

class Program
{
    static void Main()
    {
        Spaceship spaceship = new Spaceship("Starship", 100, 0);

         Console.WriteLine($"Name: {spaceship.Name}");
        Console.WriteLine($"Fuel: {spaceship.Fuel}");
        Console.WriteLine($"Speed: {spaceship.Speed}");

         spaceship.Speed = 500;
        spaceship.Trajectory = "Moon";

         Console.WriteLine($"Updated Speed: {spaceship.Speed}");
         
    }
}
