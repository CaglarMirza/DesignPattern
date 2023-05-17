using System;
namespace Kerstboom
{
	public class BallenDecorator:BoomDecorator
	{
		public BallenDecorator(IKerstBoom boom):base(boom)
		{
		}
		public override void Decorate()
		{
			base.Decorate();
			Console.WriteLine("Ballen");
		}
	}
}

