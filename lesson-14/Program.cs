Animal eagle = new Eagle();
eagle.FunFact();

Animal Wolf = new Wolf();
Wolf.FunFact();

Animal Lion = new Lion();
Lion.FunFact();

public  class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("Birds always fly");
    }
}

public class Eagle : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Eagles are unmatched in space");
    }
}

public class Wolf : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Wolves do not play in the circus");
    }
}

public class Lion : Animal
{
    public void FunFact()
    {
        Console.WriteLine("Lions are the king of the jungle");
    }
}