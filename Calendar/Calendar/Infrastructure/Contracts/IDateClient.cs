using Calendar.Infrastructure.Entities;
using Refit;

namespace Calendar.Infrastructure.Contracts
{
    public interface IDateClient
    {
        [Get("/api/v3/PublicHolidays/{year}/{countryCode}")]
        public Task<List<NagerModel>> GetHolidays(int year, string countryCode);
    }
}
