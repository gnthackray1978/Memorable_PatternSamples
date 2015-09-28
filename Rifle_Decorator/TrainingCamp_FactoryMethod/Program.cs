using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdReichTrainingCamp_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var camps = new List<TrainingCamp>();
            camps.Add(new ArmyTrainingCamp());

            Soldier s = camps.First().Train();

            var w = (WehrMacht) s;

            Console.WriteLine("is army: " + w.IsArmy);

            Console.ReadKey();

        }
    }
}
