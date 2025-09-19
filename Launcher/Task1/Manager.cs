namespace Launcher.Task1
{
    public class Manager : Employee
    {
        /* Менеджер (Manager): Атрибуты – фиксированная зарплата, премия. Метод – расчет зарплаты. */
        public int FixedSalary { get; set; }
        public int Award { get; set; }

        // Конструктор
        public Manager(string name, string jobTitle, int fixSalary, int award)
            : base(name, jobTitle)
        {
            this.FixedSalary = fixSalary;
            this.Award = award;
        }

        // Тоже переписываем полиморфизм)
        public override int SalaryCalc()
        {
            return FixedSalary + Award;
        }

        // Опять переписываем метод
        public override void ShowInfo()
        {
            Console.WriteLine($"ID = {Id}, Name = {Name}, JobTitle = {JobTitle}, Total Salary = {SalaryCalc()}");
        }
    }
}