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
    // Вынесли основные методы в базовый класс, в дальнейшем просто наследуемся и перенимаем свойства
}