using System.Security.Cryptography.X509Certificates;

namespace _1dars;

internal class Program
{
    static void Main(string[] args)
    {
        
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
