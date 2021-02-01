using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ActiveGates.Models
{
	public class UpdateJobList
	{
		public string AgId { get; set; }
		public IEnumerable<UpdateJob> UpdateJobs { get; set; }
	}
}
