using System;
namespace Garage
{
	public class Reservewiel:AutoDecorator
	{
		public Reservewiel(IAuto decorateAuto):base(decorateAuto)
		{

		}
        public override decimal GetPrijs()
        {
            return base.GetPrijs()+500;
        }
    }
}

