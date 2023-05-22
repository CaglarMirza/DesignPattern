using System;
namespace Eiland
{
	public class Zoogdier:Inwoner
	{
		public Zoogdier(string naam)
		{
			Naam = naam;
		}
        public override void ReageerVulkaanuitbarsting(EiLand eiLand)
        {
			Console.WriteLine($"{Naam} reageren door in hun hol te schuilen.");
        }
    }
}

