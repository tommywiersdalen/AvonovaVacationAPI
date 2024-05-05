using System.Security.Cryptography.X509Certificates;
using AvonovaVacation.Models;

namespace AvonovaVacation.Services;

public static class HolidayService
{
    static List<Holiday> Holidays { get; }
    static HolidayService()
    {
        Holidays = new List<Holiday>
        {
            new Holiday
            {
                Id = 1,
                Name = "New Year's Day",
                Date = new DateTime(2024, 1, 1),
            },
            new Holiday
            {
                Id = 2,
                Name = "Good Friday",
                Date = new DateTime(2024, 4, 15),
            },
            new Holiday
            {
                Id = 3,
                Name = "Easter Monday",
                Date = new DateTime(2024, 4, 18),
            },
            new Holiday
            {
                Id = 4,
                Name = "May Day",
                Date = new DateTime(2024, 5, 1),
            },
            new Holiday
            {
                Id = 5,
                Name = "Ascension Day",
                Date = new DateTime(2024, 5, 26),
            },
            new Holiday
            {
                Id = 6,
                Name = "National Day",
                Date = new DateTime(2024, 6, 6),
            },
            new Holiday
            {
                Id = 7,
                Name = "Midsummer's Day",
                Date = new DateTime(2024, 6, 24),
            },
            new Holiday
            {
                Id = 8,
                Name = "All Saints' Day",
                Date = new DateTime(2024, 11, 5),
            },
            new Holiday
            {
                Id = 9,
                Name = "Christmas Day",
                Date = new DateTime(2024, 12, 25),
            },
            new Holiday
            {
                Id = 10,
                Name = "Boxing Day",
                Date = new DateTime(2024, 12, 26),
            },
        };

    }
    public static List<Holiday> GetAll() => Holidays;
}