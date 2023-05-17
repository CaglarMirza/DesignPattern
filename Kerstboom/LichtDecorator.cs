using System;
namespace Kerstboom
{
	public class LichtDecorator:BoomDecorator
	{
		public LichtDecorator(IKerstBoom boom):base(boom)
		{
		}
        public override void Decorate()
        {
            base.Decorate();
            Console.WriteLine("Lichtjes");
        }


    }
}

