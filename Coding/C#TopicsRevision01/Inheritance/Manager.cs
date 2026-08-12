using System;

namespace Inheritance
{
    internal class Manager : Employee
    {

        public int TeamSize { get; set; }

        public Manager(int id, string name, double salary, int teamSize) : base(id,name,salary) { 
            TeamSize = teamSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"TeamSize: {TeamSize}");
        }
    }
}
