using System;
namespace Soldaten
{
	public class Groep : ILeger
	{
		private List<ILeger> groepen = new List<ILeger>();

		public void TrekTenStrijde()
		{
			//Console.WriteLine("Ten Strijde");
			foreach (ILeger item in groepen)
			{
				item.TrekTenStrijde();
			}
		}

		public void Add(ILeger groep)
		{
			groepen.Add(groep);
		}
		public void Remove(ILeger groep)
		{
			groepen.Remove(groep);
		}






	}
}
