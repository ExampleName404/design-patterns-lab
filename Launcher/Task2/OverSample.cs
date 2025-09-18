public class Singleton
{
    private static Singleton _instance;
    private Singleton()
    {
        // Шаблон одиночки
    }
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                 _instance = new Singleton();

            }
            return _instance;
        }
    }


    public void DoSomething()
    {
        Console.WriteLine("Doing something..."); // как я понял просто тестовый функционал
    }
}


public class Client // Реализация на стороне клиента
{
    public void Execute()
    {
        Singleton.Instance.DoSomething();

    }
}