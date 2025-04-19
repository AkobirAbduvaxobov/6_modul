namespace _1dars;

public class NotifyFactory
{
    public static INotifyMessage GetObject(string type)
    {
        if(type.ToLower() == "sms") return new SmsNotify();
        if(type.ToLower() == "email") return new EmailNotify();
        if(type.ToLower() == "accaunt") return new CompanyAccauntNotify();
        throw new Exception($"Such type : {type} not exists");
    }
}
