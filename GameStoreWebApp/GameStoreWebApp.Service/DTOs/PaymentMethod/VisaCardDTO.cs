namespace GameStoreWebApp.Service.DTOs.PaymentMethod;

public class VisaCardDTO
{
    public string Holder { get; set; }
    public string CardNumber { get; set; }
    public int MonthExpire { get; set; }
    public int YearExpire { get; set; }
    public int Cvv2 { get; set; }
}
