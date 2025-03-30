using System;
using System.Security.Cryptography.X509Certificates;
public enum BattaryType 
{
    LiIon,
    NiMh,
    NiCd
}
public class Battary
{
    public string Model { get; set;}    

    public int Idletime { get; set;}    

    public int Talktime { get; set;} 
    public BattaryType Type {get ;set ;}   

}
class MobilePhone
{
    public string Model { get; set;}
    public string Manufacturer { get; set;}
    public int Price { get; set;}
    public string Owner { get; set;}    

    public Battary BattaryInfo { get; set;}

    public double Screensize { get; set;} 
    public int Colors { get; set;}    

    public static MobilePhone Nokia = new MobilePhone
    {
        Model = "Nokia 99",
        Manufacturer = "Nokia",
        Price = 600,
        Owner = "Abdo Hani",
        BattaryInfo = new Battary
        {
            Model="Pro-25",
            Idletime = 120,
            Talktime = 10,
            Type = BattaryType.LiIon,
        },
        Colors = 16,
        Screensize = 4
    };

    public static void DisplayInfo(MobilePhone phone)
    {
        Console.WriteLine($"Model is {phone.Model}");
        Console.WriteLine($"Manufacturer is {phone.Manufacturer}");
        Console.WriteLine($"Owner is {phone.Owner}");
        Console.WriteLine($"Price is {phone.Price}");
        Console.WriteLine($"Battary Model is {phone.BattaryInfo.Model}");
        Console.WriteLine($"Battary Type is {phone.BattaryInfo.Type}");
        Console.WriteLine($"Idle Time in hours is {phone.BattaryInfo.Idletime}");
        Console.WriteLine($"Talk Time in hours is {phone.BattaryInfo.Talktime}");
        Console.WriteLine($"Screen Size is {phone.Screensize} Inches");
        Console.WriteLine($"Colors are {phone.Colors}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        MobilePhone iphone = new MobilePhone()
        {
            Model = "Iphone 19",
            Manufacturer = "Apple",
            Price = 20000,
            Owner = "Monier el 5ater",
            BattaryInfo  = new Battary
            {
                Model="Ultra-26",
                Talktime= 200,
                Idletime= 300,
                Type = BattaryType.LiIon,
            },
            Colors = 16,
            Screensize = 10
        };

        Console.WriteLine("Information About Nokia 99 :");
        MobilePhone.DisplayInfo(MobilePhone.Nokia);
        Console.WriteLine();
        Console.WriteLine("Information About IPhone 19 :");
        MobilePhone.DisplayInfo(iphone);
    }
}