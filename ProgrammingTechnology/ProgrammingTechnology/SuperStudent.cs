using System;

namespace ProgrammingTechnology
{
    internal class SuperStudent : Student
    {
        public SuperStudent(string Name) : this(Name, "") { }
        public SuperStudent(string Name, string SurName) : base(Name, SurName)
        {
            Score = int.MaxValue;
        }
        public new void GetInfo()
        {
            Console.WriteLine($"{Name} - супер абитуриент, поступит везде, где хочет\n");
        }
    }
}
