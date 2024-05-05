using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvonovaVacation.Models
{
    public class VacationRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysRequested { get; set; }
        public string? Notes { get; set; }
        public bool Approved { get; set; }
        public bool Denied { get; set; }
        public bool Pending { get; set; }


    }
}