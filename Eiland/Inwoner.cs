using System;
namespace Eiland
{
	abstract public class Inwoner:IObserver
	{
        public string Naam { get; protected set; }   

        public abstract void ReageerVulkaanuitbarsting(EiLand eiLand);




    }
}

