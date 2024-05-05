using System.Net.NetworkInformation;
using AvonovaVacation.Models;

namespace AvonovaVacation.Services
{
    public static class EmployeeService
    {
        static List<Employee> Employees { get; }

        static EmployeeService()
        {
            Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                CountryCode = "NO",
                VacationDays = 25,
                VacationDaysLeft = 20,
                VacationDaysUsed = 5,
                VacationRequest = null,

            },
            new Employee
            {
                Id = 2,
                Name = "Jane",
                CountryCode = "NO",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,

            },
            new Employee
            {
                Id = 3,
                Name = "Alice",
                CountryCode = "NO",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,

            },
            new Employee
            {
                Id = 4,
                Name = "Bob",
                CountryCode = "NO",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,


            },
            new Employee
            {
                Id = 5,
                Name = "Charlie",
                CountryCode = "SE",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,

            },
            new Employee
            {
                Id = 6,
                Name = "David",
                CountryCode = "SE",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,

            },
            new Employee
            {
                Id = 7,
                Name = "Eve",
                CountryCode = "SE",
                VacationDays = 25,
                VacationDaysLeft = 25,
                VacationDaysUsed = 0,
                VacationRequest = null,

            },
        };
        }

        public static List<Employee> GetEmployeesByCountryCode(string countryCode)
        {
            return Employees.Where(e => e.CountryCode == countryCode).ToList();
        }

        public static Employee? Get(int id) => Employees.FirstOrDefault(p => p.Id == id);

    }
}