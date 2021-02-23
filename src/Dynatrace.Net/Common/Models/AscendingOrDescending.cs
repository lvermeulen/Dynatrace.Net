using System.ComponentModel;

namespace Dynatrace.Net.Common.Models
{
	public class AscendingOrDescending<T>
	{
		public static string With(T t, StringConverter converter = null)
		{
			converter ??= new StringConverter();

			return $"+{converter.ConvertToInvariantString(t)}";
		}

		public static string Without(T t, StringConverter converter = null)
		{
			converter ??= new StringConverter();

			return $"-{converter.ConvertToInvariantString(t)}";
		}

		protected AscendingOrDescending()
		{ }
	}
}
