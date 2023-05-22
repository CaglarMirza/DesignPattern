using System;
namespace Eiland
{
	public class Vogel:Inwoner
	{
		public Vogel(string naam)
		{
			Naam = naam;
		}
        public override void ReageerVulkaanuitbarsting(EiLand eiLand)
        {
			Console.WriteLine($"{Naam} reageren hierop door hoger op te vliegen. "); 
        }
    }
}

