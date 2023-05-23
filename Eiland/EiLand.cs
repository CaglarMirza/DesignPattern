using System;
namespace Eiland
{
	public class EiLand
	{
        private static EiLand? uniekeInstantie;
		

        private static readonly Lazy<EiLand> lazy = new Lazy<EiLand>(() => new EiLand());


        private List<IObserver> observers = new List<IObserver>();
        private List<Inwoner> inwoners = new();


        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }




        //private EiLand() {}

        public static EiLand GetuniekeInstantie
        {get
            {
                //if (uniekeInstantie == null)
                //    uniekeInstantie = new EiLand();
                //return uniekeInstantie;
                return lazy.Value;
            }
        }





        public void ToevoegInwoner(Inwoner inwoner)
        {
            inwoners.Add(inwoner);
            observers.Add(inwoner);
            
            
        }

        public void Vulkaanuitbarsting()
        {
            Console.WriteLine("Er vindt een vulkaanuitbarsting plaats!");

            foreach (Inwoner inwoner in inwoners)
            {
                inwoner.ReageerVulkaanuitbarsting(this);
            }
        }


 



    }
}

