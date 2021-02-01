namespace Dynatrace.Net.Configuration.KubernetesCredentials.Models
{
	public class KubernetesEventPattern
	{
		public string Label { get; set; }
		public string FieldSelector { get; set; }
		public bool? Active { get; set; }
	}
}
