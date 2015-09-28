using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Rifle_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            SA80 sa80 = new SA80();

            Bayonet bayonet = new Bayonet();
            bayonet.SetRifle(sa80);

            Console.WriteLine("Lethality: " + sa80.Lethality());

            Console.WriteLine("Bayonet: " + bayonet.Lethality());

            Console.ReadKey();
        }

        public abstract class BaseRifle
        {
            private string _weaponDescription = "generic rifle";

            public abstract int Lethality();

            public string GetDescription()
            {
                return _weaponDescription;
            }
        }

        public class SA80 : BaseRifle
        {
            private int _lethality = 100;

            public override int Lethality()
            {
                return _lethality;
            }
        }

        public abstract class RifleEnhancement : BaseRifle
        {
            public new abstract string GetDescription();

            public abstract void SetRifle(BaseRifle rifle);
        }

        public class Bayonet : RifleEnhancement
        {
            private BaseRifle _baseRifle;
            private string _description = "Bayonet";

            public override string GetDescription()
            {
                return _description;
            }

            public override int Lethality()
            {
                return _baseRifle.Lethality() + 100;
            }

            public override void SetRifle(BaseRifle rifle)
            {
                _baseRifle = rifle;
            }
        }


    }
}
