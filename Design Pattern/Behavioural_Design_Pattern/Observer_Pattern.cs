using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Behavioural_Design_Pattern
{
    //Observer_Pattern


    public interface Observer
    {
        void Update();
    }

    public class Subscriber : Observer
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }


    public class subject
    {
        private List<Observer> observers = new List<Observer>();

        public subject(List<Observer> observers)
        {
            this.observers = observers;
        }

        public void registerObserve(Observer observer)
        {
            observers.Add(observer);
        }

        public void unregisterObserve(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }

}
