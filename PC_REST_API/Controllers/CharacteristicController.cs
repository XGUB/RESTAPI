using Microsoft.AspNetCore.Mvc;
using PC_REST_API.General.Classes;
using PC_REST_API.Models;
using PC_REST_API.Services.Interfaces;

namespace PC_REST_API.Controllers;

/// <summary>
/// Characteristics Controller
/// </summary>
[Route("/characteristics")]
[ApiController]
public class CharacteristicController : ControllerBase

{
    /// <summary>
    /// Manage characteristic logic
    /// </summary>
    private readonly ICharacteristicService _characteristicService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="characteristicService"></param>
    public CharacteristicController(ICharacteristicService characteristicService) => _characteristicService = characteristicService;

    //public CharacteristicController(CharacteristicContext context) {_Context= context;}

    /// <summary>
    /// Get characteristic data
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<CharacteristicModel>> GetCharacteristic(int characteristicId)
    {
        try
        {
            return await _characteristicService.GetCharacteristic(characteristicId);
        }

        catch (CharacteristicException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Create a characteristic data
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<CharacteristicModel>> PostCharacteristic(CharacteristicModel characteristic)
    {
        try
        {

            return await _characteristicService.PostCharacteristic(characteristic);
        }

        catch (CharacteristicException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Update existing characteristic data
    /// </summary>
    /// <param name="characteristic"></param>
    /// <returns></returns>
    [HttpPut]
    public async Task<ActionResult<CharacteristicModel>> PutCharacteristic(CharacteristicModel characteristic)
    {
        try
        {
            return await _characteristicService.PutCharacteristic(characteristic);
        }
        catch (CharacteristicException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// Delete existing characteristic data
    /// </summary>
    /// <param name="characteristicId"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<ActionResult> DeleteCharacteristic(int characteristicId)
    {
        try
        {
            await _characteristicService.DeleteCharacteristic(characteristicId);
            return Ok(Constants.ExceptionResponses.characteristicDelete);
        }
        catch (CharacteristicException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

