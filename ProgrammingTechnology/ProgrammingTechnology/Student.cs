using System;

namespace ProgrammingTechnology
{
    public class Student
    {
        private string _name;
        private string _surName;
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

        public uint Score { get; protected set; }

        public Student(string Name, string SurName, uint Score)
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
        public Student(string Name, uint Score) : this(Name, "", Score)
        {
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя >> {Name}");
            Console.WriteLine($"Фамилия >> {SurName}");
            Console.WriteLine($"Кол-во баллов >> {Score}\n");
        }
        public void GetInfo(University university)
        {
            if (university.Students.IndexOf(this) != -1)
            {
                Console.WriteLine($"{this.Name} есть в {university.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} нет в {university.Name}");
            }
        }

        public string CompareChances()
        {
            string output = Score > 150 ? $"У {Name} {SurName} Высокие шансы поступить" : $"У {Name} {SurName} низкие шансы поступить";
            return output;
        }
        public string CompareChances(Student student)
        {
            string output = this >= student ?
                $"У {Name} {SurName} больше шансов поступить, чем у {student.Name} {student.SurName}" :
                $"У {student.Name} {student.SurName} больше шансов поступить, чем у {Name} {SurName}";
            return output;
        }


        public static Student operator ++(Student student)
        {
            student.Score += 10;
            return student;
        }
        public static bool operator >=(Student student1, Student student2)
        {
            return student1.Score >= student2.Score;
        }
        public static bool operator <=(Student student1, Student student2)
        {
            return student1.Score <= student2.Score;
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
    }
}
