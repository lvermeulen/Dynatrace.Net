using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ActiveGates.Models
{
	public class UpdateJobsAll
	{
		public IEnumerable<UpdateJobList> AllUpdateJobs { get; set; }
	}
}
