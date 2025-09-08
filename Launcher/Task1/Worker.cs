public class Worker : Employee
{
    /*
    Рабочий (Worker): Атрибуты – ставка за час, количество часов. Метод – расчет зарплаты.
    */

    // Атроибуты, ставка за час + кол часов
    public int HourlyRate { get; set; }
    public int TotalHours { get; set; }

    // Переписанный конструктор
    public Worker(string name, string jobTitle, int hourlyRate, int totalHours)
    : base(name, jobTitle)
    {
        this.HourlyRate = hourlyRate;
        this.TotalHours = totalHours;
    }

    // Расчет ЗП пусть будет часы на ставку полиморфизм)
     public override int SalaryCalc()
    {
        return HourlyRate * TotalHours;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"ID = {Id}, Name = {Name}, JobTitle = {JobTitle}, Total Salary = {SalaryCalc()}");
    }
}