using Microsoft.AspNetCore.Mvc;
using MundoAnimalModels;
using MundoAnimalService.Interfaces;

namespace MundoAnimalApplication
{
    public class MundoAnimalController : Controller
    {
        private readonly IGatoService _gatoService;

        public MundoAnimalController(IGatoService gatoService)
        {
            _gatoService = gatoService;
        }

        public void Index()
        {

        //    var Animal = new Animal
        //    {
        //        Nome = Faker.Name.First(),
        //        Idade = Faker.RandomNumber.Next(100)
        //};

            _gatoService.AdicionarAnimal(new Animal());
        }
    }
}
