using System;
using System.Collections.Generic;

namespace ProgrammingTechnology
{

    internal class University : Building
    {
        List<Student> Students { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine(Name + Description);
        }
    }
}
