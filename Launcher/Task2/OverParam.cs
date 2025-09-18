// Излишняя параметризация методов
public class MathOperations
{
    public int Add(int a, int b, bool shouldLog = false)
    {
        return a + b;

        // if (shouldLog)
        // {
        //     Console.WriteLine($"Result: {result}");
        // }
        // Тут две ответственности либо полностью убрать или вынести вывод лога в отдельный метод
    }
}
