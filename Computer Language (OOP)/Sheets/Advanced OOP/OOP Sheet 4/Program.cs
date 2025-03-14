using System;


public interface IBeverage
{
    double GetCost();
    string GetDescription();
}

public class Coffee : IBeverage
{
    public double GetCost()
    {
        return 10 ;
    }

    public string GetDescription()
    {
        return "Normal Coffee";
    }
}

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual double GetCost()
    {
        return _beverage.GetCost();
    }

    public virtual string GetDescription()
    {
        return _beverage.GetDescription();
    }
}

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override double GetCost()
    {
        return base.GetCost() + 2;
    } 

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }
}

public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage) { }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IBeverage coffee = new Coffee();
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");

        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()}: ${coffee.GetCost()}");
    }
}