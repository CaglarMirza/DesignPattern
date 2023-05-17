using System;
namespace Leger
{
	public class Vijand :IObserver
	{
		public void Update(ISubject subject)
		{
			Legerac leger = (Legerac)subject;
            if (leger.IsFighting())
            {
                Console.WriteLine("Vijand: raketten af te vuren.");
            }
            else
            {
                Console.WriteLine("Vijand: onderhandelingen te starten");
            }
        }
	}
}

