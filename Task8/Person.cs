using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    abstract class Person : IComparable<Person>
    {
        //Part 1
        private string name;
        private int age;
        public string Name { get { return name; } }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Print()
        {
            Console.WriteLine(name);
        }

        public int CompareTo(Person other)
        {
            throw new NotImplementedException();
        }
    }
}
