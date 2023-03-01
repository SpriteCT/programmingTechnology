using System;

namespace ProgrammingTechnology
{
    internal class FoolishStudent : Student
    {
        public FoolishStudent(string Name) : this(Name, "") { }
        public FoolishStudent(string Name, string SurName) : base(Name, SurName)
        {
            Score = int.MinValue;
        }
        public new void GetInfo()
        {
            Console.WriteLine($"{Name} - глупый абитуриент, никуда не поступит\n");
        }
    }
}
