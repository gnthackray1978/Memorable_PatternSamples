using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invasionForce = new InvasionForce();

            invasionForce.SetAssaultStrategy(new FlankingManouevre());

            invasionForce.StartTheInvasion();

            Console.ReadKey();
        }
    }

    public abstract class AssaultStrategy
    {
        public abstract void Attack();
    }

    public class NightAttack : AssaultStrategy
    {
        public override void Attack()
        {
            Console.WriteLine("Its dark and we're attacking!");
        }
    }

    public class FrontalAttack : AssaultStrategy
    {
        public override void Attack()
        {
            Console.WriteLine("We're going over the top!");
        }
    }

    public class FlankingManouevre : AssaultStrategy
    {
        public override void Attack()
        {
            Console.WriteLine("We're launching a flanking attack!");
        }
    }


    public class InvasionForce
    {
        private AssaultStrategy _assaultStrategy;

        public void SetAssaultStrategy(AssaultStrategy assaultStrategy)
        {
            _assaultStrategy = assaultStrategy;
        }

        public void StartTheInvasion()
        {
            _assaultStrategy.Attack();
        }
    }



}
