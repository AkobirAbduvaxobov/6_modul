namespace _1dars;

public class CompanyAccauntNotify : INotifyMessage
{
    public void Send(string message)
    {
        Console.WriteLine("Accaunt orqali habar ketdi");
    }
}
