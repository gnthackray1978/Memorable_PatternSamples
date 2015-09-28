using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictator_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            dictator d= new Hitler();

          
            d.SetImplementor(new Hydrich());
            d.MassMurder();

            d.SetImplementor(new Goebels());
            d.MassMurder();


            Console.ReadKey();
        }

        public abstract class dictator
        {
            public abstract void SetImplementor(Implementor implementor);

            public abstract void MassMurder();


        }

        public abstract class Implementor
        {
            public abstract void MassMurder();
        }


        public class Hitler : dictator
        {
            private Implementor _implementor;

            public override void SetImplementor(Implementor implementor)
            {
                _implementor = implementor;
            }

            public override void MassMurder()
            {
                _implementor.MassMurder();
            }
        }

        public class Hydrich : Implementor
        {
            public override void MassMurder()
            {
                Console.WriteLine("gas chambers");
            }
        }

        public class Goebels : Implementor
        {
            public override void MassMurder()
            {
                Console.WriteLine("death squads");
            }
        }
    }
}
