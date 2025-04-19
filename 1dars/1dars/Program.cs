using System.Security.Cryptography.X509Certificates;

namespace _1dars;

internal class Program
{
    static void Main(string[] args)
    {
        var type = "accAUNtt";

        var strategyType = NotifyFactory.GetObject(type);

        var notifyStrategy = new NotifyStrategy(strategyType);
        notifyStrategy.Notify("Keyingi dars kech qolmanglar");

    }

    public static void TestSingleton()
    {
        List<Thread> threads = new List<Thread>();

        for (int i = 0; i < 4; i++)
        {
            var newThread = new Thread(Do);
            newThread.Start();
        }

        Console.WriteLine(MyClass.Counter);
    }

    public static void Do()
    {
        var myClass = MyClass.GetInstance();
    }
}
