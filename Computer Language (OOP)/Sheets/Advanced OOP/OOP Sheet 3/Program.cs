using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(string message);
}
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

public class Order : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string orderStatus;

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void UpdateOrderStatus(string status)
    {
        orderStatus = status;
        Notify($"Order status updated to: {orderStatus}");
    }
}


public class Customer : IObserver
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received notification: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        Customer customer1 = new Customer("Abdo");
        Customer customer2 = new Customer("Monier");

        order.Attach(customer1);
        order.Attach(customer2);

        order.UpdateOrderStatus("Processing");
        order.UpdateOrderStatus("Shipped");

        order.Detach(customer1);

        order.UpdateOrderStatus("Delivered");
    }


}