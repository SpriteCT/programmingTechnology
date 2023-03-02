using System;

namespace ProgrammingTechnology
{
    internal class Program
    {
        static private Student NewStudent()
        {
            Console.Write("Введите имя >> ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию >> ");
            string surName = Console.ReadLine();
            Console.Write("Введите баллы >> ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return new Student(name, surName, score);
        }
        static void Main(string[] args)
        {
            Student Vasya = new Student("Vasya", "Pupkin", 300);
            Vasya.GetInfo();

            Student Dasha = new Student("Dasha", "Anonimka", 270);
            Dasha.GetInfo();

            Student Grisha = new Student("Grisha", 10);
            Grisha.GetInfo();

            SuperStudent SuperVasya = new SuperStudent("SuperVasya");
            SuperVasya.GetInfo();

            FoolishStudent NotVasya = new FoolishStudent("NotVasya", "NotPupkin");
            NotVasya.GetInfo();

            Student user = NewStudent();
            user.PrintChances(Dasha);
            Dasha.PrintChances(Vasya);
            SuperVasya.PrintChances(Grisha);
            NotVasya.PrintChances(Grisha);

            NotVasya.StartStudy();
            NotVasya.PrintChances(Grisha);

            SuperVasya.StartFooling();
            SuperVasya.PrintChances(NotVasya);
            Console.ReadKey();
        }
    }
}
