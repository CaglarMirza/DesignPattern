using System;
namespace Leger
{
	public class Legerac :ISubject
	{
        private List<IObserver> observers = new List<IObserver>();
        private bool isFighting;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        public void StartFighting()
        {
            isFighting = true;
            Notify();
        }

        public void InvokePeace()
        {
            isFighting = false;
            Notify();
        }
        public bool IsFighting()
        {
            return isFighting;
        }
    }






}

