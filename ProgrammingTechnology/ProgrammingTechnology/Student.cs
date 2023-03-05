using System;

namespace ProgrammingTechnology
{
    public class Student
    {
        private string name;
        private string surName;
        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value >= 0)
                {
                    score = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string SurName
        {
            get
            {
                return surName;
            }
            set
            {
                surName = value;
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
            Console.WriteLine($"Имя >> {name}");
            Console.WriteLine($"Фамилия >> {surName}");
            Console.WriteLine($"Кол-во баллов >> {score}\n");
        }
        public bool IsChanceBigger(Student student)
        {
            return this.score > student.Score;
        }

    }
}