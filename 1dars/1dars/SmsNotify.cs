namespace _1dars;

public class SmsNotify : INotifyMessage
{
    public void Send(string message)
    {
        Console.WriteLine("SMS orqali habar ketdi");
    }
}
