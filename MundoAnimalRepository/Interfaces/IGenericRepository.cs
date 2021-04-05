using System;
using System.Collections.Generic;
using System.Text;

namespace MundoAnimalRepository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Adicionar(T obj);
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Adicionar(T obj)
        {
            // Faz algo
        }
    }
}
