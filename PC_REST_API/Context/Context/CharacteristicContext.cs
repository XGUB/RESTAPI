using Microsoft.EntityFrameworkCore;
using PC_REST_API.Context.EntityConfiguration;
using PC_REST_API.Models;

namespace PC_REST_API.Context.Context;

public class CharacteristicContext : DbContext
{

    /// <summary>
    /// To query PC Characteristics table
    /// </summary>
    public DbSet<CharacteristicModel> Characteristics { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="options"></param>
    public CharacteristicContext(DbContextOptions<CharacteristicContext> options) : base(options)
    {

    }

    /// <summary>
    /// Apply entity type congigurations when the model is creating
    /// </summary>
    /// <param name="modelBuilder"> define entities</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder) => _ = modelBuilder.ApplyConfiguration(new CharacteristicEntityTypeConfiguration());
}
