using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyPOC.Entities
{
    [Table("Animals")]
    public class Animal
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Column("Latitude")]
        public double Latitude { get; set; }

        [Column("Longitude")]
        public double Longitude { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("AnimalTypeId")]
        public int AnimalTypeId { get; set; }

        [Ignore]
        public AnimalType Type { get; set; }
    }

    public class AnimalTypeItem
    {
        public string Name { get; set; }
        public AnimalType Type { get; set; }
    }

    public enum AnimalType
    {
        Cachorro = 1,
        Gato = 2,
        Reptil = 3,
        Roedor = 4,
        Passaro = 5
    }
}
