using System;
using System.Collections.Generic;
using System.IO;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 3
            List<Person> Persons = new List<Person>();
            Person person0 = new Teacher("Gen", 28, "St", "Travel");
            Person person1 = new Teacher("Bob", 30, "Dr", "Geografy");
            Person person2 = new Teacher("Sam", 32, "St", "Math");
            Person person3 = new Teacher("Jack", 34, "Mg", "Phisics");
            Person person4 = new Teacher("Jim", 36, "St", "Geometry");
            Person person5 = new Teacher("Tom", 38, "Dr", "Geografy");
            Persons.Add(person0);
            Persons.Add(person1);
            Persons.Add(person2);
            Persons.Add(person3);
            Persons.Add(person4);
            Persons.Add(person5);
            Person person6 = new Developer("Bobby", 40, "Tr", "C#");
            Person person7 = new Developer("Sammy", 42, "Ju", "C++");
            Person person8 = new Developer("Jack", 44, "Mi", "JS");
            Person person9 = new Developer("Jimmy", 46, "Se", "Java");
            Person person10 = new Developer("Tommy", 48, "Ex", "Go");
            Persons.Add(person6);
            Persons.Add(person7);
            Persons.Add(person8);
            Persons.Add(person9);
            Persons.Add(person10);
            Person person11 = new Staff("Bo", 50, "Jule");
            Person person12 = new Staff("Sa", 52, "June");
            Person person13 = new Staff("Ja", 54, "May");
            Person person14 = new Staff("Ji", 56, "April");
            Person person15 = new Staff("To", 58, "March");
            Persons.Add(person11);
            Persons.Add(person12);
            Persons.Add(person13);
            Persons.Add(person14);
            Persons.Add(person15);
            foreach (Person person in Persons)
            {
                person.Print();
            }
            //Console.ReadLine();
            //Part 4
            Console.Write("Enter name:\t");
            string name = Console.ReadLine();
            foreach (Person person in Persons)
            {
                if (person.Name == name)
                {
                    person.Print();
                }
            }
            Console.ReadLine();
            //Part 5
            foreach (Person person in Persons)
            {
                   
            }
            Console.ReadLine();
        }
    }
}
