using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.DataPrivacy.Models
{
	public class DataPrivacyAndSecurity
	{
		public ConfigurationMetadata Metadata { get; set; }
		public bool? MaskIpAddressesAndGpsCoordinates { get; set; }
		public bool? MaskUserActionNames { get; set; }
		public bool? MaskPersonalDataInUris { get; set; }
		public bool? LogAuditEvents { get; set; }
	}
}
