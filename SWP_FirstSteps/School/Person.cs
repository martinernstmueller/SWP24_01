using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public enum Gender
    {
        female = 0,
        male = 1,
        diverse = 2
    }
    public class Person
    {
        public string Name { get;  }
        public Gender Gender { get; }
        private DateTime birthdate;
        public Person(Gender gender, string name, DateTime birthdate)
        {
            this.Gender = gender;
            this.Name = name;
            this.birthdate = birthdate;
        }
    }
}
