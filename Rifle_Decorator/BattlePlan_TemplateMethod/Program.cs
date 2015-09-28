using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePlan_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("old vs new armys");

            var aa = new AncientArmy();

            aa.Act();

            var ma = new ModernArmy()

            ma.Act();

            Console.ReadKey();

        }
    }

    public abstract class Plan
    {
       
        //choose ground
        //encampe
        //eat supper
        //wake up and get ready for battle
        //pin centre
        //flank
        //envelopment
        //winandcheer

        public void Act()
        {
            this.ChooseGround();
            this.Encamp();
            this.EatSupper();
            this.WakeAndReady();
            this.PinCentre();
            this.Flank();
            this.Envelopement();    
            this.WinAndCheer();
        }

        protected void ChooseGround()
        {
            Console.WriteLine("walk around choosing ground");
        }

        protected void EatSupper()
        {
            Console.WriteLine("eatting supper --- mm tastey");
        }

        protected void WakeAndReady()
        {
            Console.WriteLine("woken up and preparing");
        }

        protected abstract void Encamp();

        protected abstract void PinCentre();

        protected abstract void Flank();

        protected abstract void Envelopement();

        protected void WinAndCheer()
        {
            Console.WriteLine("hurrah we won!");
        }
    }

    public class AncientArmy : Plan
    {

        protected override void Encamp()
        {
            Console.WriteLine("build wooden camp");
        }

        protected override void PinCentre()
        {
            Console.WriteLine("infantry charges with shields and gladius");
        }

        protected override void Flank()
        {
            Console.WriteLine("cavalry charge");
        }

        protected override void Envelopement()
        {
            Console.WriteLine("central infantry fall back and cavalry swing around");
        }
    }

    public class ModernArmy : Plan
    {
        protected override void Encamp()
        {
            Console.WriteLine("helicopter in razor wire and land mines");
        }

        protected override void PinCentre()
        {
            Console.WriteLine("fire machine guns at enemy");
        }

        protected override void Flank()
        {
            Console.WriteLine("send a couple of guys out");
        }

        protected override void Envelopement()
        {
            Console.WriteLine("start shooting at them from the rear");
        }
    }

}
