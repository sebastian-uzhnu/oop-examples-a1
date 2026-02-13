namespace ConsoleApp30;

public class P1
{
    public abstract class Shape {
        public int X { get; set; }
        public int Y { get; set; }
    
        // Віртуальний метод: має базову логіку, але може бути перевизначений
        public virtual void Draw() {
            Console.WriteLine($"Малюю фігуру за координатами ({X}, {Y})");
        }
    }

    public class Circle : Shape {
        public int Radius { get; set; }
        public override void Draw() {
            Console.WriteLine($"Малюю коло з радіусом {Radius} у точці ({X}, {Y}) ⭕");
        }
    }

    public class Square : Shape {
        public int Side { get; set; }
        public override void Draw() {
            Console.WriteLine($"Малюю квадрат зі стороною {Side} у точці ({X}, {Y}) 🟦");
        }
    }
}