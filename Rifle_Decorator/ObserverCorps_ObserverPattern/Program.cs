using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCorps_ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var spotter = new AircraftSpotter();

            var rafStation = new RAFStation();

            spotter.Add(rafStation);

            spotter.Notify();

            Console.ReadKey();
        }
    }

    //iobservable
    //subject
    //observer
    //iobserver

    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);

        void Notify();
    }


    public interface IObserver
    {
        int ObserverId { get; set; }

        void Update(int number, int direction);
    }



    public class RAFStation : IObserver
    {

        public int ObserverId { get; set; }
 
        
        public void Update(int number, int direction)
        {
            Console.WriteLine("Aircraft: " + number.ToString());
        }
    }


    public class AircraftSpotter : IObservable
    {
        readonly List<IObserver> _observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
          var index = _observers.FindIndex(o => o.ObserverId == observer.ObserverId);
          
          _observers.RemoveAt(index);
        

        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update(1,1);
            }
        }
    }


}
