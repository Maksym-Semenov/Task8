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
            List<Person> People = new List<Person>();
            Person person0 = new Teacher("Gen", 28, "St", "Travel");
            Person person1 = new Teacher("Bob", 30, "Dr", "Geografy");
            Person person2 = new Teacher("Sam", 32, "St", "Math");
            Person person3 = new Teacher("Jack", 34, "Mg", "Phisics");
            Person person4 = new Teacher("Jim", 36, "St", "Geometry");
            Person person5 = new Teacher("Tom", 38, "Dr", "Geografy");
            People.Add(person0);
            People.Add(person1);
            People.Add(person2);
            People.Add(person3);
            People.Add(person4);
            People.Add(person5);
            Person person6 = new Developer("Bobby", 40, "Tr", "C#");
            Person person7 = new Developer("Sammy", 42, "Ju", "C++");
            Person person8 = new Developer("Jack", 44, "Mi", "JS");
            Person person9 = new Developer("Jimmy", 46, "Se", "Java");
            Person person10 = new Developer("Tommy", 48, "Ex", "Go");
            People.Add(person6);
            People.Add(person7);
            People.Add(person8);
            People.Add(person9);
            People.Add(person10);
            Person person11 = new Staff("Bo", 50, "Jule");
            Person person12 = new Staff("Sa", 52, "June");
            Person person13 = new Staff("Ja", 54, "May");
            Person person14 = new Staff("Ji", 56, "April");
            Person person15 = new Staff("To", 58, "March");
            People.Add(person11);
            People.Add(person12);
            People.Add(person13);
            People.Add(person14);
            People.Add(person15);
            foreach (Person person in People)
            {
                person.Print();
            }
            //Console.ReadLine();
            //Part 4
            Console.Write("Enter person's name:\t");
            string name = Console.ReadLine();
            foreach (Person person in People)
            {
                if (person.Name == name)
                {
                    person.Print();
                }
            }
            //Part 5
            People.Sort();
            string sortName = @"D:\Sort name.txt";
            using (StreamWriter sw = new StreamWriter(sortName, false))
            {
                sw.WriteLine("List of sorted names");
                foreach (Person person in People)
                {
                    sw.WriteLine(person.Name);
                }
            }
            //Part 6
            List<Staff> Employees = new List<Staff>();
            foreach (Staff people in People)
            {
                if (people.GetType() == typeof(Developer))
                {
                    Employees.Add(people);
                }
                if (people.GetType() == typeof(Teacher))
                {
                    Employees.Add(people);
                }
            }
            foreach (Staff staff in Employees)
            {
                staff.Print();
            }
            string staffList = @"D:\Staff list.txt";
            using (StreamWriter sw = new StreamWriter(staffList, false))
            {
                sw.WriteLine("\tStaff list");
                foreach (Staff staff in Employees)
                {
                    sw.WriteLine(staff.Name);
                }
            }
            Employees.Sort();
            string sortAge = @"D:\Sort age.txt";
            using (StreamWriter sw = new StreamWriter(sortAge, false))
            {
                foreach (Staff staff in Employees)
                {
                    sw.WriteLine(staff.Age);
                }
            }
        Console.ReadLine();
        }
    }
}
