using PC_REST_API.Models;

namespace PC_REST_API.Services.Interfaces
{
    public interface ICharacteristicService
    {
        /// <summary>
        /// Get Characteristic
        /// </summary>
        /// <param name="characteristicId"></param>
        /// <returns></returns>
        Task<CharacteristicModel> GetCharacteristic(int characteristicId);

        /// <summary>
        /// Create Characteristic
        /// </summary>
        /// <param name="characteristic"> Characteristic model </param>
        /// <returns></returns>
        Task<CharacteristicModel> PostCharacteristic(CharacteristicModel characteristic);

        /// <summary>
        /// Update Characteristic
        /// </summary>
        /// <param name="characteristic"> characteristic model </param>
        /// <returns></returns>
        Task<CharacteristicModel> PutCharacteristic(CharacteristicModel characteristic);

        /// <summary>
        /// Delete Characteristic
        /// </summary>
        /// <param name="characteristicId"> Characteristic Model </param>
        /// <returns></returns>
        Task DeleteCharacteristic(int characteristicId);
    }
}
