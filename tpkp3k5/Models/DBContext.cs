using System.Data.Entity;

namespace tpkp3k5.Models
{
    public class kekDBContext : DbContext
    {
        public kekDBContext()
            : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tpkp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bet> Bets { get; set; }
    }
}