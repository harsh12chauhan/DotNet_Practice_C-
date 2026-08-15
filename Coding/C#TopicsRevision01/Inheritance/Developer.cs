using System;

namespace Inheritance
{
    internal class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(int id, string name, double salary, string programmingLanguage) : base(id,name,salary) {

            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"ProgrammingLanguage : {ProgrammingLanguage}");
        }
    }
}
