using System;

namespace PolymorphisAbstractHidingObjectInitializationCompositionCasting
{
    internal class Manager : Employee
    {
        private int TeamSize { get; set; }

        public Manager(int id, string name, double salary, int teamSize) : base(id, name, salary){ 
        
            TeamSize = teamSize;
        }

        public override double CalculateBonus()
        {
            return Salary * 10 / 100; ;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"TeamSize : {TeamSize}");
            Console.WriteLine($"Bonus : {CalculateBonus()}");
        }

        public new void Work()
        {

            Console.WriteLine("Manager is working...");
        }

    }
}
