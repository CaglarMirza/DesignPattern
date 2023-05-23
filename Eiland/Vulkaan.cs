using System;
namespace Eiland
{
	public class Vulkaan
	{
        public event Action BarstUit;

        public void StartUitbarsting()
        {
            Console.WriteLine("Er vindt een vulkaanuitbarsting plaats!");
            BarstUit?.Invoke();
        }
    }
}

