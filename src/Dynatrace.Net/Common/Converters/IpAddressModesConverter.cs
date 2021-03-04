using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class IpAddressModesConverter : JsonEnumConverter<IpAddressModes>
	{
		private static readonly Dictionary<IpAddressModes, string> s_pairs = new Dictionary<IpAddressModes, string>
		{
			[IpAddressModes.Exclude] = "EXCLUDE",
			[IpAddressModes.Include] = "INCLUDE"
		};

		protected override Dictionary<IpAddressModes, string> Pairs => s_pairs;

		protected override string EntityString => "IP address mode";
	}
}
