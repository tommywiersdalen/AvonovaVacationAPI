using AvonovaVacation.Models;

namespace AvonovaVacation.Services
{
    public class CountryContextService
    {
        public static CountryContext CountryContext { get; private set; }
        static CountryContextService()
        {
            CountryContext = new CountryContext { CountryCode = "SE" };
        }

        public static CountryContext GetCountryContext()
        {
            return CountryContext;
        }

        public static async void ChangeCountryContext(string newCountryCode)
        {
            CountryContext countryContext = GetCountryContext();
            countryContext.CountryCode = newCountryCode;
        }

    }
}