using PC_REST_API.Models;
using PC_REST_API.Repositories.Interfaces;
using PC_REST_API.Services.Interfaces;

namespace PC_REST_API.Services.Classes
{
    public class CharacteristicService : ICharacteristicService
    {


        //En Studget se declara una variable tipo MODELO. Preguntar para qué se utiliza
        //private CharacteristicModel _characteristic = null!;

        //Porqué estoy declarando la interfaz aquí y no la clase directamente como en el repositorio con el contexto
        private readonly ICharacteristicRepository _characteristicRepository;

        public CharacteristicService(ICharacteristicRepository characteristicRepository)
        {
            _characteristicRepository = characteristicRepository;
        }

        public async Task<CharacteristicModel> GetCharacteristic(int characteristicId)
        {
            //Validación con repositorio de si el id de characteristic existe mandando a llamar
            //el método GET del Repository. Pero aquí convierte el resultado en un CharacteristicModel
            CharacteristicModel characteristicModel = await _characteristicRepository.GetCharacteristic(characteristicId);

            return characteristicModel ?? throw new Exception("NotFound");

        }

        public async Task<CharacteristicModel> PostCharacteristic(CharacteristicModel characteristic)
        {
            return await _characteristicRepository.PostCharacteristic(characteristic);

        }

        public async Task<CharacteristicModel> PutCharacteristic(CharacteristicModel characteristic)
        {
            return await _characteristicRepository.PutCharacteristic(characteristic);
        }

        public async Task DeleteCharacteristic(int characteristicId)
        {
            await _characteristicRepository.DeleteCharacteristic(characteristicId);
        }
    }
}
