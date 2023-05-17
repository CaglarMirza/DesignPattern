using System;
namespace Garage
{
	public class Trekhaak :AutoDecorator
	{
		public Trekhaak(IAuto	decorateAuto):base(decorateAuto)
		{
		}
        public override decimal GetPrijs()
        {
            return base.GetPrijs() + 600;
        }
    }
}

