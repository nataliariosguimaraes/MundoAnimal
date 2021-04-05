
using MundoAnimalModels;
using MundoAnimalRepository.Interfaces;
using MundoAnimalService.Interfaces;
using System;

namespace MundoAnimalService.Servicos
{
    public class GatoService : IGatoService
    {

        private readonly IAnimalRepository _aninalRepository;


        public GatoService(IAnimalRepository gatoRepository)
        {
            _aninalRepository = gatoRepository;
        }


  

        public void AdicionarAnimal(Animal animal)
        {
            _aninalRepository.AdicionarAnimal(animal);
            RegistrarIGF();
        }




        public void RegistrarIGF()
        {
            throw new NotImplementedException();
        }


        private void AdicionarAnimalBanco()
        {


        }


    }
}
