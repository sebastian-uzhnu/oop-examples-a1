namespace ConsoleApp30;

public class P4
{
    // Базовий клас
    public abstract class Hero {
        public string Name { get; set; }
        public int Health { get; set; } = 100;

        // Абстрактний метод — кожен герой б'ється по-своєму
        public abstract void Attack();
    }

// Похідні класи
    public class Warrior : Hero {
        public override void Attack() => Console.WriteLine($"{Name} рубить мечем! ⚔️");
    }

    public class Mage : Hero {
        public override void Attack() => Console.WriteLine($"{Name} випускає вогняну кулю! 🔥");
    }
}