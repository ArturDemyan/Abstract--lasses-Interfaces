using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__and_Interfaces_Lesson_8
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string SetName(string name) 
        { 
          Name = name;
           return Name;
        }
        public string GetName()
        {
            return Name;
        }

        public virtual void Eat(string whatEat) => Console.WriteLine($"Your friend is eating {whatEat}");
   

    }
}
