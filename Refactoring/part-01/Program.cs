using Refactoring.Part01;

class Program
{
    static void Main(string[] args)
    {

        var notification = new Notification(new EmailChannel());
        notification.Send("customer@example.com", "Welcome!"); // send immediately

        var urgentNotification = new Notification(new SmsChannel(), isUrgent: true);
        urgentNotification.Send("+2010000000", "Server down"); // send + urgent

        var scheduledNotification = new Notification(new WhatsAppChannel(), sendAt: DateTime.Now.AddHours(1));
        scheduledNotification.Send("+2010000000", "Reminder: delivery tomorrow"); // schedule for later

        var complexNotification = new Notification(new EmailChannel(), isUrgent: true, sendAt: DateTime.Now.AddHours(2));
        complexNotification.Send("customer@example.com", "Payment failed"); // send + urgent + schedule for later

        Console.WriteLine("\n______________________________________________________________________________________________________________\n");


        var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
        processor.Process(1001, "customer@example.com");
        Console.WriteLine();

        Console.WriteLine("______________________________________________________________________________________________________________\n");


        var shipping1 = new ShippingCostCalculator(new AramexShippingCostCalculator());
        Console.WriteLine($"Aramex 2kg → {shipping1.Calculate(2)}");

        var shipping2 = new ShippingCostCalculator(new FedExShippingCostCalculator());
        Console.WriteLine($"FedEx 2kg  → {shipping2.Calculate(2)}");

        var shipping3 = new ShippingCostCalculator(new DHLShippingCostCalculator());
        Console.WriteLine($"DHL 2kg  → {shipping3.Calculate(2)}");

        Console.ReadLine();
    }
}