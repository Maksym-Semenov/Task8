using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Teacher : Staff
    {
        //Part 2
        string subject;
        public string Subject { get { return subject; } set { subject = value; } }
        public Teacher(string name, int age, string position, string subject) : base(name, age, position)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine($"Teacher's name is {Name}, subject is {Subject}");
        }
    }
}
