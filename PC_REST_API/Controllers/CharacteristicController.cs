using Microsoft.AspNetCore.Mvc;
using PC_REST_API.Models;
using PC_REST_API.Services.Interfaces;

namespace PC_REST_API.Controllers
{
    [Route("/PCCharacteristics")]
    [ApiController]
    public class CharacteristicController : ControllerBase

    {
        //DOCUMENTADO POR SI ACASO
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ICharacteristicService _characteristicService;

        public CharacteristicController(ICharacteristicService characteristicService)
        {
            _characteristicService = characteristicService;
        }

        //public CharacteristicController(CharacteristicContext context) {_Context= context;}

        [HttpGet]
        public async Task<ActionResult<CharacteristicModel>> GetCharacteristic(int characteristicId)
        {

            return await _characteristicService.GetCharacteristic(characteristicId);


            //if (characteristic == null)
            //{
            //    return NotFound();
            //}

            //return characteristic;
        }

        [HttpPost]
        public async Task<ActionResult<CharacteristicModel>> PostCharacteristic(CharacteristicModel characteristic)
        {
            return await _characteristicService.PostCharacteristic(characteristic);
        }

        [HttpPut]
        public async Task<ActionResult<CharacteristicModel>> PutCharacteristic(CharacteristicModel characteristic)
        {
            return await _characteristicService.PutCharacteristic(characteristic);

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCharacteristic(int characteristicId)
        {
            await _characteristicService.DeleteCharacteristic(characteristicId);
            return Ok();


            //var characteristic = await _Context.Characteristics.FindAsync(id);

            //if (characteristic == null)
            //{
            //    return NotFound("Try something else pls 😒");
            //}

            //_Context.Characteristics.Remove(characteristic);
            //await _Context.SaveChangesAsync();

            //return Ok("Deleted successfully 😂");
        }
    }


}

