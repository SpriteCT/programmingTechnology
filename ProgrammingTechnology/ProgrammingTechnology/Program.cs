using System;

namespace ProgrammingTechnology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Vasya = new Student("Vasya", "Pupkin", 300);
            Vasya.GetInfo();
            Student Dasha = new Student("Dasha", "Anonimka", 270);
            Dasha.GetInfo();
            Student Grisha = new Student("Grisha", 130);
            Grisha.GetInfo();
            Console.WriteLine($"У Даши шансов поступить больше, чем у Васи >> {Dasha.IsChanceBigger(Vasya)}");
            Console.WriteLine($"У Васи шансов поступить больше, чем у Гриши >> {Vasya.IsChanceBigger(Grisha)}");
            Console.ReadKey();
        }
    }
}
