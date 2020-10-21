using System.ComponentModel;

namespace Dynatrace.Net.Common.Models
{
	public class WithOrWithout<T>
	{
		public static string With(T t, StringConverter converter = null)
		{
			if (converter == null)
			{
				converter = new StringConverter();
			}

			return $"+{converter.ConvertToInvariantString(t)}";
		}

		public static string Without(T t, StringConverter converter = null)
		{
			if (converter == null)
			{
				converter = new StringConverter();
			}

			return $"-{converter.ConvertToInvariantString(t)}";
		}

		protected WithOrWithout()
		{ }
	}
}
