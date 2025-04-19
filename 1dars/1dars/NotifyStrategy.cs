namespace _1dars;

public class NotifyStrategy
{
    private readonly INotifyMessage _strategy;
    public NotifyStrategy(INotifyMessage strategy)
    {
        _strategy = strategy;
    }

    public void Notify(string message)
    {
        _strategy.Send(message);
    }
}
