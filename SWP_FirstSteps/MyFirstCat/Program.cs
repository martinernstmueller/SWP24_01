// See https://aka.ms/new-console-template for more information
using MyFirstCat;

Console.WriteLine("Hello, World!");
Cat myCat = new Cat("Kitty", "black", new DateTime(2022, 07, 13)); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu

Tierheim myTierheim = new Tierheim();
myTierheim.AddAnimal(myCat);
myTierheim.AddAnimal(new Cat("Kitty 2", "white", new DateTime(2023, 07, 13))); 
myTierheim.AddAnimal(new Dog("Lessi", "grey", new DateTime(2023, 07, 13)));

Console.WriteLine("In Tierheim befinden sich " + myTierheim.NumberOfAnimals + "Tiere...");
Console.WriteLine("davon sind " + myTierheim.NumberOfCats + " Katzen");


//Console.WriteLine("The color of my Cat " + myCat.Name + " is " + myCat.Color + " and she is " + myCat.Age + " years old...");
