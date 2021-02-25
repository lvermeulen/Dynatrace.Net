using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class IpDetectionHeaders
	{
		[JsonProperty("ipDetectionHeaders")]
		// ReSharper disable once InconsistentNaming
		public IEnumerable<string> _IpDetectionHeaders { get; set; }
	}
}
