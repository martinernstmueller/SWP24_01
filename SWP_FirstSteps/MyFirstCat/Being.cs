namespace MyFirstCat
{
    class Being
    {
        public string Color { get; set; }
        public string Name { get; set; }
        private DateTime BirthDate { get; set; }
        public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }

        public Being(string name, string color, DateTime birthDate)
        {
            Color = color;
            BirthDate = birthDate;
            Name = name;
        }

        public override string ToString()
        {
            return "I am a Being ";
        }


    }
}
