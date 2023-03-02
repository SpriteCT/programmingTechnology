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
            protected set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }
        public string SurName
        {
            get
            {
                return _surName;
            }
            protected set
            {
                _surName = value;
            }
        }

        public Student(string Name, string SurName, int Score)
        {
            this.SurName = SurName;
            this.Name = Name;
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
            Console.WriteLine($"Имя >> {_name}");
            Console.WriteLine($"Фамилия >> {_surName}");
            Console.WriteLine($"Кол-во баллов >> {_score}\n");
        }
        private bool IsChanceBigger(Student student)
        {
            return this._score > student.Score;
        }

        public void PrintChances(Student student)
        {
            string output = IsChanceBigger(student) ? $"У {Name} шансов поступить больше, чем у {student.Name}\n" : $"У {student.Name} шансов поступить больше, чем у {Name}\n";
            Console.WriteLine(output);
        }

    }
}
