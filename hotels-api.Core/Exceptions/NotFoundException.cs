using System;
namespace hotels_api.Exceptions
{
	public class NotFoundException : ApplicationException
	{
		public NotFoundException(string name, object key) : base($"{name} ({key}) was not found")
		{
		}
	}
}
