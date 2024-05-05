using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvonovaVacation.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime Date { get; set; }
    }
}