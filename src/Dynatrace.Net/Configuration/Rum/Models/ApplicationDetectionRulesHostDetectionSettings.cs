using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationDetectionRulesHostDetectionSettings
	{
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<string> HostDetectionHeaders { get; set; }
	}
}
