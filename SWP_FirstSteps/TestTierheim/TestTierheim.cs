using MyFirstCat;

namespace TestTierheim
{

    public class TestTierheim
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddAnimal_()
        {
            var myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat("Kitty 2", "white", new DateTime(2023, 07, 13)));
            myTierheim.AddAnimal(new Dog("Lessi", "grey", new DateTime(2023, 07, 13)));
            Assert.IsTrue(myTierheim.NumberOfAnimals == 2);

        }
    }
}