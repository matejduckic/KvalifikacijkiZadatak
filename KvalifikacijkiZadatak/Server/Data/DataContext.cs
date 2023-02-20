using KvalifikacijkiZadatak.Shared;
using Microsoft.EntityFrameworkCore;

namespace KvalifikacijkiZadatak.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Strojevi> Strojevis { get; set; }
        public DbSet<Kvarovi> Kvarovis { get; set; }
    }
}
