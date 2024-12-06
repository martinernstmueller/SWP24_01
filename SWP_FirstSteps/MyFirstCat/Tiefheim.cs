using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstCat
{
    class Tierheim()
    {
        private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public int NumberOfAnimals { get { return _animals.Count;} }

        public int NumberOfCats { 
            get { return _animals.Where(a => a.GetType() == typeof(Cat)).Count(); }
         }
    }

    
}
