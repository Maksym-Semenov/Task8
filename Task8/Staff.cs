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

        public int CompareTo(Staff staff)
        {
            Staff d = staff as Developer;
            Staff t = staff as Teacher;
            if (d != null && t != null)
            {
                return this.Age.CompareTo(d.Age);
                return this.Age.CompareTo(t.Age);
            }
            throw new Exception("Uncorrect staff value!");
        }
        
    }
}
