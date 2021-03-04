using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationDataPrivacyList
	{
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<ApplicationDataPrivacy> Values { get; set; }
	}
}
