using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace WpfCSLev2
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> GetEmployee { get; set; } = new ObservableCollection<Employee>() {
            new Employee
            {
                Name = "Константин",
                Surname = "Носков",
                Patronymic = "Иванович",
                Birthday = new DateTime(1981, 12, 29),
                Age = 38,
                Salary = 120000,
                Position="Системный администратор",
                Phone ="1916",
                Email="mymail@somedomain.ru",
                DepartmentId = 2
            }};
        public ObservableCollection<Department> GetDepartment { get; set; } = new ObservableCollection<Department>() {
            new Department {Id = 1, Name = "СКТ" },
            new Department {Id = 2, Name = "бухгалтерия" },
            new Department {Id = 3, Name = "водители" }
        };

    }
}
