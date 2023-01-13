using PC_REST_API.General.Classes;
using PC_REST_API.Models;
using PC_REST_API.Repositories.Interfaces;
using PC_REST_API.Services.Interfaces;

namespace PC_REST_API.Services.Classes;

/// <summary>
/// To manage characteristic service
/// </summary>
public class CharacteristicService : ICharacteristicService
{

    //En Studget se declara una variable tipo MODELO. Preguntar para qué se utiliza
    //private CharacteristicModel _characteristic = null!;

    /// <summary>
    /// To manage Characteristic's table data
    /// </summary>
    private readonly ICharacteristicRepository _characteristicRepository;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="characteristicRepository"></param>
    public CharacteristicService(ICharacteristicRepository characteristicRepository) => _characteristicRepository = characteristicRepository;

    /// <summary>
    /// Get Characteristic Data
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    /// <exception cref="CharacteristicException"></exception>
    public async Task<CharacteristicModel> GetCharacteristic(int characteristicId)
    {
        //Validación con repositorio de si el id de characteristic existe mandando a llamar
        //el método GET del Repository. Pero aquí convierte el resultado en un CharacteristicModel
        CharacteristicModel characteristicModel = await _characteristicRepository.GetCharacteristic(characteristicId);

        return characteristicModel ?? throw new CharacteristicException(Constants.ExceptionResponses.characteristicNotFound);

    }

    /// <summary>
    /// Create a new Characteristic
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    /// <exception cref="CharacteristicException"></exception>
    public async Task<CharacteristicModel> PostCharacteristic(CharacteristicModel characteristic)
    {
        try
        {
            return await _characteristicRepository.PostCharacteristic(characteristic);
        }

        catch
        {
            throw new CharacteristicException(Constants.ExceptionResponses.characteristicAlreadyExists);
        }
    }

    /// <summary>
    /// Update an existing Characteristic
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    /// <exception cref="CharacteristicException"></exception>
    public async Task<CharacteristicModel> PutCharacteristic(CharacteristicModel characteristic)
    {
        try
        {
            return await _characteristicRepository.PutCharacteristic(characteristic);
        }
        catch
        {
            throw new CharacteristicException(Constants.ExceptionResponses.characteristicNotModify);
        }
    }

    /// <summary>
    /// Delete an existing characteristic
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    /// <exception cref="CharacteristicException"></exception>
    public async Task DeleteCharacteristic(int characteristicId)
    {
        try
        {
            await _characteristicRepository.DeleteCharacteristic(characteristicId);
        }
        catch
        {
            throw new CharacteristicException(Constants.ExceptionResponses.characteristicNotDelete);
        }
    }
}
