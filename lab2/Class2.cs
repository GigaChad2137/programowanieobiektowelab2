using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        Person(string name, int age)
        {

            Name = name;
            Age = age;

        }
        public bool Equals(Person obj)
        {
            return obj.Name == this.Name && obj.Age == this.Age;
        }

        override public string ToString()
        {
            return this.Name + "(" + this.Age.ToString() + " y.o.)";
        }

    }
}
