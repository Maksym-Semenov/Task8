using System;

namespace Task8
{
    internal class Staff : Person, IComparable<Staff>
    {
        //Part 1
        string position;
        public string Position { get { return position; } set { position = value; } }
        public Staff(string name, int age, string position) : base(name, age)
        {
            this.position = position;
        }
        public override void Print()
        {
            Console.WriteLine($"Staff's name is {Name}, position is {Position}");
        }

        public int CompareTo(Staff other)
        {
            throw new NotImplementedException();
        }
    }
}
