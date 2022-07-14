using System;

namespace Task8
{
    internal class Developer : Staff
    {
        //Part 2
        string level;
        public string Level { get { return level; } set { level = value; } }
        public Developer(string name, int age, string position, string level) : base(name, age, position)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine($"Developer's name is {Name}, level is {Level}");
        }
    }
}
