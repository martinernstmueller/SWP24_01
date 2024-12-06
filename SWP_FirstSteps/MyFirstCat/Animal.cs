namespace MyFirstCat
{
    class Animal : Being
    {
        public Animal(string name, string color, DateTime birthDate) : base(name, color, birthDate) 
        {
            
        }

        public virtual string gibTypischenLautVonDir()
        {
            return "bein Tier gibt keinen Laut von sich";
        }
    }
}
