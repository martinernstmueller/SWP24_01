using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstCat
{
    class Cat(string name, string color, DateTime birthDate) : Animal(name, color, birthDate) 
    {
        public override string gibTypischenLautVonDir()
        {
            return "Miau";
        }
    }
}
