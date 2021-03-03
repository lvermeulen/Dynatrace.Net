using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MobileSessionUserActionPropertyList
	{
		public IEnumerable<MobileSessionUserActionPropertyShort> SessionProperties { get; set; }
		public IEnumerable<MobileSessionUserActionPropertyShort> UserActionProperties { get; set; }
	}
}
