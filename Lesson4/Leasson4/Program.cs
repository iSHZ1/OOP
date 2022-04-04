using System;

namespace Leasson4
{
    class Program
    {
        static void Main()
        {


            Building House1 = new Building(250, 12, 240, 5);

            Building House2 = new Building(250, 12, 2880, 6);
            Building House3 = new Building(250, 12, 288, 6);


            House1.PrintInfoBuilding();
            Console.WriteLine();
            Console.WriteLine();
            House2.PrintInfoBuilding();
            Console.WriteLine(Building.GenerateNumberBuild);
        }



    }
}
