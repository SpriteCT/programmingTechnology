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
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {SurName} - глупый абитуриент, никуда не поступит\n");
        }
        public void StartStudy()
        {
            Console.WriteLine($"{Name} {SurName} начал учиться\n");
            Random random = new Random();
            Score += random.Next(10, 150);
        }
        public void StartStudy(int score)
        {
            Console.WriteLine($"{Name} {SurName} начал учиться и получил + {score} баллов\n");
            Score += score;
        }
    }
}