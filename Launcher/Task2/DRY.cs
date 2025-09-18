public class OrderService

{
    public double CalulateTotalPrice(int quantity,int price) // Создали отдельный метод, по хорошему он должен быть вынесен отдельно
    {
         return quantity * price;
    }
    public void CreateOrder(string productName, int quantity, double price)

    {

       

        Console.WriteLine($"Order for {productName} created. Total: {CalulateTotalPrice}");

    }

    public void UpdateOrder(string productName, int quantity, double price)

    {

        double totalPrice = quantity * price;

        Console.WriteLine($"Order for {productName} updated. New total: {CalulateTotalPrice}");

    }

}

public class Car
{
    public string Name { get; set; }
    public void Start()
    {
        Console.WriteLine($"{Name} is starting");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} is stopping");
    }

}

public class Truck : Car
{
    
}
