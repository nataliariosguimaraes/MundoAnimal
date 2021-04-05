using MundoAnimalModels;
using MundoAnimalRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MundoAnimalRepository
{
    public class AnimalRepository : IAnimalRepository
    {

        public void AdicionarAnimal(Animal animal)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ANIMAL (Nome, Idade) VALUES (@Nome, @Idade)";    

                cmd.Parameters.AddWithValue("nome", animal.Nome);
                cmd.Parameters.AddWithValue("Idade", animal.Idade);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }

   
    }
}
