namespace ConsoleApp30;

public class P3
{
    public class Vehicle {
        public string Model { get; set; }
        public virtual void Move() => Console.WriteLine($"{Model} їде по дорозі.");
    }

    public class Airplane : Vehicle {
        public override void Move() => Console.WriteLine($"{Model} злітає в небо! ✈️");
    }

    public class Boat : Vehicle {
        public override void Move() => Console.WriteLine($"{Model} пливе по воді. 🚤");
    }
}