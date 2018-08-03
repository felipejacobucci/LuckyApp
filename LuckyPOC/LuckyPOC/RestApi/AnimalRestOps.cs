using LuckyPOC.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyPOC.RestApi
{
    public static class AnimalRestOps
    {
        public static List<Animal> GetLostAnimals()
        {
            List<Animal> list = new List<Animal>()
            {
                new Animal()
                {
                    CreateDate = DateTime.Now,
                    Description = "Papagaio encontrado",
                    Type = AnimalType.Passaro,
                    Latitude = -23.611573,
                    Longitude = -46.691556
                },
                new Animal()
                {
                    CreateDate = DateTime.Now,
                    Description = "cachorro atropelado",
                    Type = AnimalType.Cachorro,
                    Latitude = -23.614129,
                    Longitude = -46.693004
                },
                new Animal()
                {
                    CreateDate = DateTime.Now,
                    Description = "gato preto",
                    Type = AnimalType.Gato,
                    Latitude = -23.532636,
                    Longitude = -46.760308
                }
            };

            return list;
        }
    }
}
