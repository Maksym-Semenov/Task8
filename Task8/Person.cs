using System;

namespace Task8
{
    abstract class Person : IComparable<Person>
    {
        //Part 1
        private string name;
        private int age;
        public string Name { get { return name; } }
        public int Age { get { return age; } }
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
            return name.CompareTo(other.name);
            throw new Exception("Uncorrect person value!");
        }
    }
}
