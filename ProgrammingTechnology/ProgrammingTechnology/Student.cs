using System;

namespace ProgrammingTechnology
{
    public class Student
    {

        private string _name;
        private string _surName;
        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }
            protected set
            {
                if (value >= 0)
                {
                    _score = value;
                }
                else
                {
                    _score = 0;
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                IsValidName(value);
                _name = value;
            }
        }
        public string SurName
        {
            get
            {
                return _surName;
            }
            private set
            {
                IsValidName(value);
                _surName = value;
            }
        }

        public Student(string Name, string SurName, int Score)
        {
            this.SurName = SurName;
            this.Name = Name ?? throw new ArgumentNullException(nameof(Name));
            this.Score = Score;
        }
        public Student(string Name, string SurName) : this(Name, SurName, 0)
        {
        }
        public Student(string Name) : this(Name, "")
        {
        }
        public Student(string Name, int Score) : this(Name, "", Score)
        {
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя >> {Name}");
            Console.WriteLine($"Фамилия >> {SurName}");
            Console.WriteLine($"Кол-во баллов >> {Score}\n");
        }

        public void PrintChances(Student student)
        {
            string output = IsChanceBigger(student) ?
                $"У {Name} {SurName} шансов поступить больше, чем у {student.Name} {student.SurName}\n" :
                $"У {student.Name} {student.SurName} шансов поступить больше, чем у {Name} {SurName}\n";

            Console.WriteLine(output);
        }
        static private void IsValidName(string name)
        {
            foreach (char letter in name)
            {
                if (!char.IsLetter(letter))
                {
                    throw new ArgumentException(nameof(Name));
                }
            }
        }
        private bool IsChanceBigger(Student student)
        {
            return this._score > student.Score;
        }
    }
}
