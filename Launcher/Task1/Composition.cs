using System.Collections.Generic;

namespace Launcher.Task1
{
    public class EmployeesRegistry
    {
        // Коллекция сотрудников
        public List<Employee> Employees { get; } = new List<Employee>();

        // Добавление/удаление сотрудников
        public void AddEmployee(Employee employee) => Employees.Add(employee);
        public void RemoveEmployee(Employee employee) => Employees.Remove(employee);

        // Вывод всех сотрудников
        public void ShowAllEmployees()
        {
            foreach (var employee in Employees)
            {
                employee.ShowInfo();
            }
        }
    }
}