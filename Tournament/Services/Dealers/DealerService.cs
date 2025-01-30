namespace Tournament.Services.Dealers
{
    using System.Linq;
    using Tournament.Data;

    public class DealerService : IDealerService
    {
        private readonly TournamentDbContext data;

        public DealerService(TournamentDbContext data) 
            => this.data = data;

        public bool IsDealer(string userId)
            => this.data
                .Dealers
                .Any(d => d.UserId == userId);

        public int IdByUser(string userId)
            => this.data
                .Dealers
                .Where(d => d.UserId == userId)
                .Select(d => d.Id)
                .FirstOrDefault();
    }
}
