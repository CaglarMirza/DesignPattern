using System;
namespace Kerstboom
{
	public class SlingerDecorator:BoomDecorator
	{
		public SlingerDecorator(IKerstBoom boom):base(boom)
		{
		}
        public override void Decorate()
        {
            base.Decorate();
            Console.WriteLine("Slingers");
        }
    }
}

