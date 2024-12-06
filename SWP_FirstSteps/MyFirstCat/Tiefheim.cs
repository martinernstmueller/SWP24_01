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
