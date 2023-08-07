namespace PersonTasks;

public class Person
{
    private string Name;
    private int Age;
    private string City;
    private readonly string Nationality;

    // Default constructor
    public Person()
    {
        Name = "Mavlonbek";
        Age = 20;
        City = "Andijon";
        Nationality = "Uzbek";
    }

    // Parameterized constructor
    public Person(string name, int age, string city, string nationality)
    {
        Name = name;
        Age = age;
        City = city;
        Nationality = nationality;
    }

    // Copy constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
        City = other.City;
        Nationality = other.Nationality;
    }

    // Static constructor
    static Person()
    {
        // Initializing code for static fields or operations
    }

    public Person(string v1, int v2, string v3)
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}\n" +
                          $"Age: {Age}\n" +
                          $"Nationality: {Nationality}\n" +
                          $"City: {City}\n");
    }
}
