using System;

namespace ProgrammingTechnology
{
    internal class University : Building
    {
        public override void GetInfo()
        {
            Console.WriteLine(Name + Description);
        }
    }
}
