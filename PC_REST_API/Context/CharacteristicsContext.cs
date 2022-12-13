using Microsoft.EntityFrameworkCore;
using PC_REST_API.Classes;

namespace PC_REST_API.Context
{
    public class CharacteristicsContext : DbContext
    {
        public CharacteristicsContext(DbContextOptions<CharacteristicsContext>options):base(options) 
        {

        }

        public DbSet<Characteristic> Characteristics { get; set; } = null!;
    }
}
