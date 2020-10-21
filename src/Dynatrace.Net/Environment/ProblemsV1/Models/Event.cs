using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class Event
	{
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
		public string EntityId { get; set; }
		public string EntityName { get; set; }
		public string SeverityLevel { get; set; }
		public string ImpactLevel { get; set; }
		public string EventType { get; set; }
		public string ResourceId { get; set; }
		public string ResourceName { get; set; }
		public string Status { get; set; }
		public IEnumerable<EventSeverity> Severities { get; set; }
		public bool? IsRootCause { get; set; }
		public string DeploymentProject { get; set; }
		public int? CpuLimitInMhz { get; set; }
		public string DeploymentParamAdded { get; set; }
		public IEnumerable<string> AffectedPrivateSyntheticLocations { get; set; }
		public bool? IsClusterWide { get; set; }
		public string Source { get; set; }
		public string EffectiveEntity { get; set; }
		public string OperatingSystem { get; set; }
		public string Artifact { get; set; }
		public decimal? CpuLoad { get; set; }
		public decimal? AffectedRequestsPerMinute { get; set; }
		public string AnnotationDescription { get; set; }
		public string Browser { get; set; }
		public IEnumerable<string> AffectedSyntheticLocations { get; set; }
		public string DeploymentName { get; set; }
		public string DeploymentParamRemoved { get; set; }
		public string CorrelationId { get; set; }
		public decimal? UserDefined50ThPercentileThreshold { get; set; }
		public string ServiceMethodGroup { get; set; }
		public decimal? ReferenceResponseTime90ThPercentile { get; set; }
		public string UserAction { get; set; }
		public int? MinimumProcessGroupInstanceCountThreshold { get; set; }
		public decimal? ReferenceResponseTime50ThPercentile { get; set; }
		public string Original { get; set; }
		public decimal? UserDefined90ThPercentileThreshold { get; set; }
		public string DeploymentVersion { get; set; }
		public string AnnotationType { get; set; }
		public IEnumerable<string> AffectedSyntheticActions { get; set; }
		public decimal? AffectedUserActionsPerMinute { get; set; }
		public IEnumerable<EntityShortRepresentation> ActiveMaintenanceWindows { get; set; }
		public string MobileAppVersion { get; set; }
		public decimal? UserDefinedFailureRateThreshold { get; set; }
		public string Percentile { get; set; }
		public object CustomProperties { get; set; }
		public string RemediationAction { get; set; }
		public string Service { get; set; }
		public string CiBackLink { get; set; }
		public string GeoLocation { get; set; }
		public string ServiceMethod { get; set; }
		public string Changed { get; set; }
	}
}
