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
            Console.WriteLine($"{Name} {SurName} - глупый абитуриент, никуда не поступит\n");
        }
        public void StartStudy()
        {
            Console.WriteLine($"{Name} {SurName} начал учиться\n");
            Random random = new Random();
            Score += random.Next(10, 150);
        }
    }
}
