using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphisAbstractHidingObjectInitializationCompositionCasting
{
    internal class Developer : Employee
    {
        private string ProgrammingLanguage {  get; set; }

        public Developer(int id, string name, double salary, string programmingLanguage): base(id,name,salary) {

            ProgrammingLanguage = programmingLanguage;
        }

        public override double CalculateBonus() 
        {
            return Salary * 10 / 100;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"ProgrammingLanguage : {ProgrammingLanguage}");            
            Console.WriteLine($"Bonus : {CalculateBonus()}");
        }

        public new void Work()
        {

            Console.WriteLine("Developer is working...");
        }
    }
}
