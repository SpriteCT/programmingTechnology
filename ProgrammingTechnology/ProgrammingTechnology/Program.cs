using System;

namespace ProgrammingTechnology
{
    internal class Program
    {
        static private Student CreateStudent()
        {
            Console.Write("Введите имя >> ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию >> ");
            string surName = Console.ReadLine();
            Console.Write("Введите баллы >> ");
            uint score = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            return new Student(name, surName, score);
        }
        static void Main(string[] args)
        {

        }
    }
}
