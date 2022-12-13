using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using PC_REST_API.Classes;
using PC_REST_API.Context;

namespace PC_REST_API.Controllers
{
    [Route("/PCCharacteristics")]
    [ApiController]
    public class CharacteristicsController : ControllerBase

    {
        //DOCUMENTADO POR SI ACASO
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly CharacteristicsContext _Context;

        public CharacteristicsController(CharacteristicsContext context) {_Context= context;}

        [HttpGet]
        public async Task<ActionResult<Characteristic>> Get(int id) 
        {
            var characteristic = await _Context.Characteristics.FindAsync(id);

            if (characteristic == null)
            {
                return NotFound();
            }

            return characteristic;
        }

        [HttpPost]
        public async Task<ActionResult<Characteristic>> Post(Characteristic characteristic)
        {

            _Context.Characteristics.Add(characteristic);
            await _Context.SaveChangesAsync();
            //Prueba de no añadir un "characteristic después del characteristic.id
            return CreatedAtAction(nameof(Get), new { id = characteristic.id }); 
        }

        [HttpPut]
        public async Task<ActionResult<Characteristic>> Put(Characteristic characteristic, int id)
        {
            _Context.Entry(characteristic).State= EntityState.Modified;
            await _Context.SaveChangesAsync();
            //return Ok();
            return CreatedAtAction(nameof(Get), new { id = characteristic.id });
            

            
        }

        [HttpDelete]
        public async Task<ActionResult<Characteristic>> Delete(int id)
        {
            var characteristic = await _Context.Characteristics.FindAsync(id);
            
            if (characteristic == null)
            {
                return NotFound("Try something else pls 😒");
            }
            
            _Context.Characteristics.Remove(characteristic);
            await _Context.SaveChangesAsync();

            return Ok("Deleted successfully 😂");
        }
    }
}
