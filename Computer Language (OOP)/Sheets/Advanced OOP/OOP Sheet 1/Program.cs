using System ; 

class Flight 
{
    public int flightNumber {get; set;}
    public string destination {get; set;}
    public string flightType {get; set;}
    public virtual int price {get; set;}

    public virtual int CalculateFinalPrice()
    {
        return price;
    }
}

class EconomyFlight : Flight
{

    public override int CalculateFinalPrice()
    {
        return price - price/100*10;
    }
}

class BusinessFlight : Flight
{
    public override int CalculateFinalPrice()
    {
        return price + price/100*30;
    }
}


class Program 
{
    static void Main(string[] args)
    {
        Flight flight1 = new Flight{flightNumber = 202, destination= "Tokyo", flightType= "Normal", price= 2000};
        Console.WriteLine("Flight 1 :");
        Console.WriteLine($"Flight Number: {flight1.flightNumber}");
        Console.WriteLine($"Flight Destination: {flight1.destination}");
        Console.WriteLine($"Flight Type is: {flight1.flightType}");
        Console.WriteLine($"Price is: {flight1.price}");
        Console.WriteLine($"Price Depends on the destination is: {flight1.CalculateFinalPrice()}");
        Console.WriteLine(" "); 

        EconomyFlight flight2 = new EconomyFlight{flightNumber = 203, destination= "Paris", flightType= "Economy", price= 1800};
        Console.WriteLine("Flight 2 :");
        Console.WriteLine($"Flight Number: {flight2.flightNumber}");
        Console.WriteLine($"Flight Destination: {flight2.destination}");
        Console.WriteLine($"Flight Type is: {flight2.flightType}");
        Console.WriteLine($"Price is: {flight2.price}");
        Console.WriteLine($"Price Depends on the destination is: {flight2.CalculateFinalPrice()}");
        Console.WriteLine(" ");

        BusinessFlight flight3 = new BusinessFlight{flightNumber = 204, destination= "Berlin", flightType= "Business", price= 2500};
        Console.WriteLine("Flight 3 :");
        Console.WriteLine($"Flight Number: {flight3.flightNumber}");
        Console.WriteLine($"Flight Destination: {flight3.destination}");
        Console.WriteLine($"Flight Type is: {flight3.flightType}");
        Console.WriteLine($"Price is: {flight3.price}");
        Console.WriteLine($"Price Depends on the destination is: {flight3.CalculateFinalPrice()}");
        
    }
}