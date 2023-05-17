using System;
namespace Garage
{
	public class AutoDecorator :IAuto
	{
		protected IAuto decorateAuto{get;set;}

		public AutoDecorator(IAuto decorateAuto)
		{
			this.decorateAuto = decorateAuto;
		}

		public virtual decimal GetPrijs()
		{
			return decorateAuto.GetPrijs();
		}
	}
}

