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

            SuperStudent SuperVasya = new SuperStudent("SuperVasya");
            SuperVasya.GetInfo();

            FoolishStudent NotVasya = new FoolishStudent("NotVasya", "NotPupkin");
            NotVasya.GetInfo();

            Console.WriteLine("\n\n");
            Dasha.PrintChances(Vasya);
            Dasha.PrintChances(Grisha);
            SuperVasya.PrintChances(Grisha);
            NotVasya.PrintChances(Grisha);

            Console.ReadKey();
        }
    }
}
