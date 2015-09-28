using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreddsGun_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var bullets = new Stack<IWeaponInterface>();

            for (var i = 0; i < 15; i++)
            {
                bullets.Push(new Bullet());
            }


            var lawGiver = new LawGiver(bullets);


            lawGiver.PullTrigger(4);

            Console.ReadKey();

        }
    }


    public interface IWeaponInterface
    {
        void Fire();

        bool Live { get; set; }
    }

    public class LawGiver
    {
        readonly Stack<IWeaponInterface> _magazine = new Stack<IWeaponInterface>();

        public LawGiver(Stack<IWeaponInterface> bullets)
        {
            _magazine = bullets;
        }

        public void PullTrigger(int burstLength)
        {
            var idx = 0;
            while (idx < burstLength)
            {
                if (_magazine.Count > 0)
                {
                    _magazine.Pop().Fire();
                }
                    

                idx++;
            }

        }



    }


    public class Bullet : IWeaponInterface
    {
        private bool _spent = false;

   
        public Bullet()
        {
            _spent = false;
        }

        public void Fire()
        {
            _spent = true;

            Console.WriteLine(" Bang");
        }

        public bool Live { get; set; }
    }
}


//receiver
//invoker
//command
