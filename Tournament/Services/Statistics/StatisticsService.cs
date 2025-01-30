namespace Tournament.Services.Statistics
{
    using System.Linq;
    using Tournament.Data;

    public class StatisticsService : IStatisticsService
    {
        private readonly TournamentDbContext data;

        public StatisticsService(TournamentDbContext data)
            => this.data = data;

        public StatisticsServiceModel Total()
        {
            var totalCars = this.data.Cars.Count();
            var totalUsers = this.data.Users.Count();

            return new StatisticsServiceModel
            {
                TotalCars = totalCars,
                TotalUsers = totalUsers
            };
        }
    }
}
