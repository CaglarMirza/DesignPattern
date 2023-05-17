using System;
namespace Garage
{
	public class Radio:AutoDecorator
	{
		public Radio(IAuto decorateAuto):base(decorateAuto)
		{
		}
        public override decimal GetPrijs()
        {
            return base.GetPrijs()+200;
        }
    }
}

