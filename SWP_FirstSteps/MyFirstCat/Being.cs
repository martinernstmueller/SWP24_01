﻿namespace MyFirstCat
{
    class Being
    {
        public string ColorOfAnimal { get; set; }
        public string AnimalsColor { get; set; }
        public string Name { get; set; }
        private DateTime _birthDate { get; set; }
        public int Age { get { return (DateTime.Now.Year - _birthDate.Year); } }

        public Being(string name, string color, DateTime birthDate)
        {
            AnimalsColor = color;
            _birthDate = birthDate;
            Name = name;
        }

        public override string ToString()
        {
            return "I am a Being ";
        }
    }
}
