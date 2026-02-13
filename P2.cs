namespace ConsoleApp30;

public class P2
{
    public class Notification {
        public string Message { get; set; }
        public virtual void Send() {
            Console.WriteLine($"Загальне сповіщення: {Message}");
        }
    }

    public class SmsNotification : Notification {
        public string PhoneNumber { get; set; }
        public override void Send() {
            Console.WriteLine($"Відправлено SMS на {PhoneNumber}: {Message} 📱");
        }
    }

    public class EmailNotification : Notification {
        public string Email { get; set; }
        public override void Send() {
            Console.WriteLine($"Відправлено Email на {Email}: {Message} 📧");
        }
    }
}