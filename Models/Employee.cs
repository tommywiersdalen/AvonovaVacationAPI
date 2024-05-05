using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvonovaVacation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
        public int VacationDays { get; set; }
        public int VacationDaysLeft { get; set; }
        public int VacationDaysUsed { get; set; }
        public VacationRequest? VacationRequest { get; set; }

    }
}