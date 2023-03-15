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
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {SurName} - супер абитуриент, поступит везде, где хочет\n");
        }
        public void StartFooling()
        {
            Console.WriteLine($"{Name} {SurName} перестал учиться\n");
            Score = 0;
        }
    }
}
