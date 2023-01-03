using PC_REST_API.Models;

namespace PC_REST_API.Repositories.Interfaces
{
    public interface ICharacteristicRepository
    {
        /// <summary>
        /// Get Characteristic
        /// </summary>
        /// <param name="characteristic"> characteristic id </param>
        /// <returns>Products</returns>
        Task<CharacteristicModel> GetCharacteristic(int characteristic);

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
        /// <param name="characteristic"> characteristic id </param>
        /// <returns></returns>
        Task DeleteCharacteristic(int characteristicId);
    }
}
