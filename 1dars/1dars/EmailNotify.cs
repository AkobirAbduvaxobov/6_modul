namespace _1dars;

public class EmailNotify : INotifyMessage
{
    public void Send(string message)
    {
        Console.WriteLine("Email orqali habar ketdi");
    }
}
