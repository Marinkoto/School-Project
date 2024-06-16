using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int BreedId { get; set; }
        public Breed Breed { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
