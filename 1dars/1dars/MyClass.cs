namespace _1dars;

public class MyClass
{
    private static MyClass instance;
    public static int Counter = 0;
    private static Object Lock = new Object();

    private MyClass()
    {
        
    }

    public static MyClass GetInstance()
    {
        if (instance == null)
        {
            lock(Lock)
            {
                if(instance == null)
                {
                    instance = new MyClass();
                    Counter++;
                }
            }
        }

        return instance;
    }
}
