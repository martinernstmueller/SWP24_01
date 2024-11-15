// See https://aka.ms/new-console-template for more information
using MyFirstCat;

Console.WriteLine("Hello, World!");
Cat myCat = new Cat(new DateTime(2022, 07, 13)); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
myCat.Color = "black";


Console.WriteLine("The color of my Cat is " + myCat.Color + " and she is " + myCat.Age + " years old...");
