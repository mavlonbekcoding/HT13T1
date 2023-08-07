using System;
using System.Collections.Generic;
using System.Threading.Tasks;

abstract class CarRental
{
    public bool IsRented { get; set; }
    public DateTime RentStartTime { get; set; }
    public double Balance { get; set; }
    public string BrandName { get; set; }
    public int Id { get; set; }

    public CarRental(string brandName)
    {
        BrandName = brandName;
    }
}

sealed class Bmw : CarRental
{
    public string ModelName { get; }
    public double RentPricePerHour { get; }

    public Bmw(string modelName) : base("BMW")
    {
        ModelName = modelName;
        RentPricePerHour = 30;
    }
}

sealed class Audi : CarRental
{
    public string ModelName { get; }
    public double RentPricePerHour { get; }

    public Audi(string modelName) : base("Audi")
    {
        ModelName = modelName;
        RentPricePerHour = 20;
    }
}

class CarRentalManagement
{
    public List<CarRental> Cars { get; }

    public CarRentalManagement()
    {
        Cars = new List<CarRental>();
    }

    public void Add(CarRental car)
    {
        Cars.Add(car);
    }

    public async Task Rent(string brandName)
    {
        CarRental car = Cars.Find(c => c.BrandName.Equals(brandName, StringComparison.OrdinalIgnoreCase));

        if (car != null)
        {
            car.RentStartTime = DateTime.Now;
            car.IsRented = true;
            await Task.Delay(5000); // 5 seconds
        }
        else
        {
            Console.WriteLine($"Uzr, hozirda ijaraga {brandName} moshina yo'q.");
        }
    }

    public void Return(CarRental car)
    {
        if (car.IsRented)
        {
            double rentDuration = (DateTime.Now - car.RentStartTime).TotalHours;
            double rentCost = rentDuration * (car is Bmw ? ((Bmw)car).RentPricePerHour : ((Audi)car).RentPricePerHour);
            car.Balance += rentCost;
            car.IsRented = false;
        }
    }

    public void CalculateBalance()
    {
        double totalBalance = 0;

        foreach (CarRental car in Cars)
        {
            totalBalance += car.Balance;
        }

        Console.WriteLine($"Umumiy balance - ${totalBalance}");
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        CarRentalManagement rentalManagement = new CarRentalManagement();

        Bmw bmw1 = new Bmw("X5");
        Bmw bmw2 = new Bmw("M5");
        Audi audi1 = new Audi("A3");
        Bmw bmw3 = new Bmw("X3");

        rentalManagement.Add(bmw1);
        rentalManagement.Add(bmw2);
        rentalManagement.Add(audi1);
        rentalManagement.Add(bmw3);

        await rentalManagement.Rent("BMW");
        rentalManagement.Return(bmw1);

        await rentalManagement.Rent("BMW");
        rentalManagement.Return(bmw2);

        await rentalManagement.Rent("Audi");
        rentalManagement.Return(audi1);

        await rentalManagement.Rent("BMW");
        rentalManagement.Return(bmw3);

        rentalManagement.CalculateBalance();
    }
}
