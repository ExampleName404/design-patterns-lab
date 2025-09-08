public abstract class Employee
{

    // Лаб 1
    /* Создайте базовый класс: 
    Сотрудник (Employee): Атрибуты – имя, идентификатор сотрудника, должность. Методы – расчет зарплаты.
    */


    // Инициализация переменных
    private static int _counter = 0;
    public int Id { get; private set; }
    public string? Name { get; set; }
    public string? JobTitle { get; set; }

    // Конструктор для вводы
    public Employee(string name, string jobTitle)
    {
        _counter++;
        this.Id = _counter;
        this.Name = name;
        this.JobTitle = jobTitle;
    }

    // Вывод информации о рабочем
    public virtual void ShowInfo()
    {
        Console.WriteLine($"ID = {Id}, Name = {Name}, JobTitle = {JobTitle}");
    }

    // Расчет зарплать
    public abstract int SalaryCalc();
}