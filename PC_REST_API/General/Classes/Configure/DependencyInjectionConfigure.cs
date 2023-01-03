using PC_REST_API.Repositories.Classes;
using PC_REST_API.Repositories.Interfaces;
using PC_REST_API.Services.Classes;
using PC_REST_API.Services.Interfaces;

namespace PC_REST_API.General.Classes.Configure
{

    /// <summary>
    /// Dependency Injection Configuration
    /// </summary>
    public class DependencyInjectionConfigure
    {

        /// <summary>
        /// Dependency Injection Configure Service
        /// </summary>
        /// <param name="services"> Service Collection </param>
        public static void ConfigureService(IServiceCollection services)
        {
            _ = services.AddScoped<ICharacteristicRepository, CharacteristicRepository>();
            _ = services.AddScoped<ICharacteristicService, CharacteristicService>();
        }
    }
}
