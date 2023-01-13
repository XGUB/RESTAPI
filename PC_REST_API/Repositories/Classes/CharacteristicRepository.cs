using PC_REST_API.Context.Context;
using PC_REST_API.Models;
using PC_REST_API.Repositories.Interfaces;

namespace PC_REST_API.Repositories.Classes;

/// <summary>
/// To manage characteristic database data
/// </summary>
public class CharacteristicRepository : ICharacteristicRepository
{
    /// <summary>
    /// To query characteristics' tables
    /// </summary>
    private readonly CharacteristicContext _characteristicContext;

    //Usar únicamente cuando se tenga un único atributo, con varios se tiene que abrir las llaves
    /// <summary>
    /// Parameters are passed via dependency injection to query tables
    /// </summary>
    /// <param name="characteristicContext"></param>
    public CharacteristicRepository(CharacteristicContext characteristicContext) => _characteristicContext = characteristicContext;

    /// <summary>
    /// Get Characteristic
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    public async Task<CharacteristicModel> GetCharacteristic(int characteristicId) => await _characteristicContext.Characteristics.FindAsync(characteristicId);

    /// <summary>
    /// Create Characteristic
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    public async Task<CharacteristicModel> PostCharacteristic(CharacteristicModel characteristic)
    {
        _ = await _characteristicContext.Characteristics.AddAsync(characteristic);
        _ = await _characteristicContext.SaveChangesAsync();
        return characteristic;
    }

    /// <summary>
    /// Update Characteristic
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    public async Task<CharacteristicModel> PutCharacteristic(CharacteristicModel characteristic)
    {
        //_= _characteristicContext.Characteristics.FindAsync(characteristic);
        //_ = await _characteristicContext.Characteristics.Update(characteristic);
        //await _characteristicContext.SaveChangesAsync();
        _ = _characteristicContext.Characteristics.Update(characteristic);
        _ = await _characteristicContext.SaveChangesAsync();

        return characteristic;

    }

    /// <summary>
    /// Delete Characteristic
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    public async Task DeleteCharacteristic(int characteristicId)
    {
        _ = _characteristicContext.Characteristics.Remove(new CharacteristicModel(characteristicId));
        _ = await _characteristicContext.SaveChangesAsync();

    }
}
