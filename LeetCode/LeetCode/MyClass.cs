namespace LeetCode;

public class MyClass
{
    private static MyClass myClass;
    public Guid Id { get; set; }
    private MyClass()
    {
        Id = Guid.NewGuid();
    }

    public static MyClass GetInstanse()
    {
        if (myClass == null)
        {
            myClass = new MyClass();
        }


        return myClass;
    }
}
