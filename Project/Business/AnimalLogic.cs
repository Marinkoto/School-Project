using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class AnimalLogic
    {
        private AnimalsContext animalsContext = new AnimalsContext();
        public Animal Get(int id)
        {
            Animal foundAnimal = animalsContext.Animals.Find(id);
            if (foundAnimal != null)
            {
                animalsContext.Entry(foundAnimal).Reference(n => n.Breed).Load();
            }
            return foundAnimal;
        }
        public List<Animal> GetAll()
        {
            return animalsContext.Animals.Include("Breed").ToList();
        }
        public void Create(Animal animal)
        {
            animalsContext.Animals.Add(animal);
            animalsContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Animal foundAnimal = animalsContext.Animals.Find(id);
            animalsContext.Animals.Remove(foundAnimal);
            animalsContext.SaveChanges();
        }
        public void Update(int id,Animal animal)
        {
            Animal foundAnimal = animalsContext.Animals.Find(id);
            if(foundAnimal == null)
            {
                return;
            }
            foundAnimal.Name = animal.Name;
            foundAnimal.Age = animal.Age;
            foundAnimal.BreedId = animal.BreedId;
            animalsContext.SaveChanges();
        }
    }
}
