using System;
namespace Leger
{
	public interface IObserver
	{
		void Update(ISubject subject);
	}
}

