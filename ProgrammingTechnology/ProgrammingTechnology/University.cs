using System;
using System.Collections.Generic;

namespace ProgrammingTechnology
{

    public class University : Building
    {
        public List<Student> Students { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine(Name + Description);
        }
    }
}
