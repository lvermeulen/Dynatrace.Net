using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AwsPrivateLink.Models
{
	public class WhitelistedAwsAccountList
	{
		public IEnumerable<WhitelistedAwsAccount> Values { get; set; }
	}
}
