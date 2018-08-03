using LuckyPOC.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyPOC.Repositories
{
    public class AnimalRepository
    {
        private SQLiteConnection _conn;
        public string StatusMessage { get; set; }
        
        public AnimalRepository(string dbPath)
        {
            _conn = new SQLiteConnection(dbPath);
            _conn.CreateTable<Animal>();
        }

        public void AddNewAnimal(Animal animal)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (animal == null)
                    throw new Exception("Valid animal required");

                result = _conn.Insert(animal);

                StatusMessage = $"{result} record(s) added [Id: {animal.Id}";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to add animal. Error: {ex.Message}";
            }
        }

        public List<Animal> GetAllAnimals()
        {
            try
            {
                return _conn.Table<Animal>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Animal>();
        }

    }
}
