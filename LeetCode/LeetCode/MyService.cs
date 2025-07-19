namespace LeetCode;

public class MyService
{
    private static MyService myService;
    private static Object _lock = new Object();
    public Guid Id { get; set; }

    public string Name { get; set; }

    private MyService()
    {
        Id = Guid.NewGuid();
    }

    public static MyService GetInstanse()
    {
        lock (_lock)
        {
            if (myService == null)
            {
                myService = new MyService();
            }
        }

        return myService;
    }
}
