using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    public class BreedLogic
    {
        private AnimalsContext animalsContext = new AnimalsContext();
        public List<Breed> GetAllBreeds()
        {
            return animalsContext.Breeds.ToList();
        }
        public string GetBreedById(int id)
        {
            return animalsContext.Breeds.Find(id).Name;
        }
    }
}
