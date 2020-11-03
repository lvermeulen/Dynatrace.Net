namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DatabaseConnectionFailureDetectionConfig
	{
		public bool? Enabled { get; set; }
		public int? ConnectionFailsCount { get; set; }
		public int? TimePeriodMinutes { get; set; }
	}
}
