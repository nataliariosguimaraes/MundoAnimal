using MundoAnimalModels;
using MundoAnimalRepository.Interfaces;
using System;

namespace MundoAnimalService.Servicos
{
    public abstract class AnimalService 
    {

        private readonly IAnimalRepository _aninalRepository;

        public AnimalService(IAnimalRepository animaleRepository)
        {
            _aninalRepository = animaleRepository;
        }

        public void AdicionarAnimal(Animal animal)
        {
            _aninalRepository.AdicionarAnimal(animal);
        }
    }
}
