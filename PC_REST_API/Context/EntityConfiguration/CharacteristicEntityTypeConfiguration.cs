using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_REST_API.General.Classes;
using PC_REST_API.Models;

namespace PC_REST_API.Context.EntityConfiguration;

/// <summary>
/// PC Characteristics Entity Type Configuration
/// </summary>
public class CharacteristicEntityTypeConfiguration : IEntityTypeConfiguration<CharacteristicModel>
{

    /// <summary>
    /// Configure characteristics
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<CharacteristicModel> builder)
    {
        _ = builder.ToTable(Constants.TableNames.characteristics);
        _ = builder.HasKey(key => key.Id);

        _ = builder.Property(property => property.Brand);
        _ = builder.Property(property => property.Price);
        _ = builder.Property(property => property.Cpu);
    }
}
