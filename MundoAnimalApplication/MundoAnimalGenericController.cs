using Microsoft.AspNetCore.Mvc;
using MundoAnimalModels;
using MundoAnimalRepository.Interfaces;

namespace MundoAnimalApplication
{

    public class MundoAnimalGenericController : Controller
    {
        private readonly IGenericRepository<Animal> _animalRepository;

        public MundoAnimalGenericController(IGenericRepository<Animal> animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void Index()
        {

            //    var Animal = new Animal
            //    {
            //        Nome = Faker.Name.First(),
            //        Idade = Faker.RandomNumber.Next(100)
            //};

            _animalRepository.Adicionar(new Animal());
        }
    }
}
