using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstCat
{
    class Cat(string name, DateTime birthDate) : Animal(name)
    {
        private string? _Color = null;
        DateTime _BirthDate = birthDate;
        public string Color {
            get { return _Color; }
            set {
                if (_Color == value) return;
                _Color = value;
                } 
        }

        public int Age { get { return (DateTime.Now.Year - _BirthDate.Year); } }
    }
}
