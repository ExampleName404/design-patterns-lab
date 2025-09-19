namespace Launcher.Task1
{
    public class Launcher
    {
        // Лаб 1
        /* Создайте базовый класс: 
        Сотрудник (Employee): Атрибуты – имя, идентификатор сотрудника, должность. Методы – расчет зарплаты.
        */
        public void Start()
        {
            var worker1 = new Worker("Wengalbi", "Na zone", 0, 8);
            var worker2 = new Worker("Ashab", "Raketka", 3000, 8);
            var manager = new Manager("Don Aron Don Don", "President", 1000000, 1000000);

            var AllEmployees = new EmployeesRegistry();
            AllEmployees.AddEmployee(worker1);
            AllEmployees.AddEmployee(worker2);
            AllEmployees.AddEmployee(manager);

            AllEmployees.ShowAllEmployees();
        }
    }

}