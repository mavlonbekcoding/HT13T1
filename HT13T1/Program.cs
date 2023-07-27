Animal animal = new Animal();
animal.MakeSound(); 

Bird bird = new Bird();
bird.MakeSound(); 
bird.Fly();

Mammal mammal = new Mammal();
mammal.MakeSound(); 
mammal.Run(); 

Fish fish = new Fish();
fish.MakeSound();
fish.Swim(); 


Sparrow sparrow = new Sparrow();
sparrow.MakeSound(); 
sparrow.Fly(); 

Tiger tiger = new Tiger();
tiger.MakeSound(); 
tiger.Run(); 

GreatWhiteShark shark = new GreatWhiteShark();
shark.MakeSound(); 
shark.Swim(); 

public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}

public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}

public class Sparrow : Bird
{
    
}

public class Tiger : Mammal
{

}
public class GreatWhiteShark : Fish
{

}


