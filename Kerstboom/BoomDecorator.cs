using System;
namespace Kerstboom
{
	public class BoomDecorator :IKerstBoom
	{
        protected IKerstBoom boom;

        public BoomDecorator(IKerstBoom tree)
        {
            this.boom = tree;
        }

        public virtual void Decorate()
        {
            boom.Decorate();
        }
    }
}

