abstract class Vehicle
{
    public string brand;
    public int speed;

    public abstract void Move();
}

class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Велосипед їде");
    }
}

class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Літак літає");
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Машина їде");
    }

    public void refill()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car());
        vehicles.Add(new Bicycle());
        vehicles.Add(new Airplane());

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}