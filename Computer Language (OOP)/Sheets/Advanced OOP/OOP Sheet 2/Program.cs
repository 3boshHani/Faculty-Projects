using System;

public interface IPaymentStrategy 
{
    decimal ProcessPayment(decimal amount);
    string PaymentName();
}
class CreditCardPayment : IPaymentStrategy
{
    public decimal ProcessPayment(decimal amount)
        {
            return amount;
        }
    public string PaymentName()
        {
            return "Credit Card";
        }
}

class PayPalPayment : IPaymentStrategy
{
    public decimal ProcessPayment(decimal amount)
        {
            return amount;
        }
    public string PaymentName()
        {
            return "PayPal";
        }
}
class BitcoinPayment : IPaymentStrategy
{
    public decimal ProcessPayment(decimal amount)
        {
            return amount;
        }
    public string PaymentName()
        {
            return "BitCoin";
        }
}

class ShoppingCart
{
    public decimal TotalAmount{get;set;}
    IPaymentStrategy paymentStrategy;
    public ShoppingCart(decimal totalAmount)
    {
        TotalAmount = totalAmount;
        paymentStrategy = new CreditCardPayment();
    }
    public void SetPaymentMethod(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }
    public string MethodName()
    {
        return paymentStrategy.PaymentName();
    }

    public decimal Checkout()
    {
        return paymentStrategy.ProcessPayment(TotalAmount);
    }
}

class Program 
{
    static void Main(string[] args)
    {
        ShoppingCart cart1 = new ShoppingCart(2000);
        cart1.SetPaymentMethod(new CreditCardPayment());
        Console.WriteLine("1's Cart has 3 items :");
        Console.WriteLine("1's Cart amount to pay 2000");
        Console.WriteLine($"Payment method ---> {cart1.MethodName()}");
        Console.WriteLine($"Total :{cart1.Checkout()}");
        Console.WriteLine(" ");

        ShoppingCart cart2 = new ShoppingCart(6000);
        cart2.SetPaymentMethod(new PayPalPayment());
        Console.WriteLine("2's Cart has 4 items :");
        Console.WriteLine("2's Cart amount to pay 6000");
        Console.WriteLine($"Payment method ---> {cart2.MethodName()}");
        Console.WriteLine($"Total :{cart2.Checkout()}");
        Console.WriteLine(" ");

        ShoppingCart cart3 = new ShoppingCart(3000);
        cart3.SetPaymentMethod(new BitcoinPayment());
        Console.WriteLine("3's Cart has 5 items :");
        Console.WriteLine("3's Cart amount to pay 3000");
        Console.WriteLine($"Payment method ---> {cart3.MethodName()}");
        Console.WriteLine($"Total :{cart3.Checkout()}");
        Console.WriteLine(" ");
    }
}