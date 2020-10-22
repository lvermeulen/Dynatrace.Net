using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class EventCreation
	{
		[JsonConverter(typeof(EventCreationEventTypesConverter))]
		public EventCreationEventTypes? EventType { get; set; }
		public int? Start { get; set; }
		public int? End { get; set; }
		public int? TimeoutMinutes { get; set; }
		public PushEventAttachRules AttachRules { get; set; }
		public object CustomProperties { get; set; }
		public string Source { get; set; }
		public string AnnotationType { get; set; }
		public string AnnotationDescription { get; set; }
		public string Description { get; set; }
		public string DeploymentName { get; set; }
		public string DeploymentVersion { get; set; }
		public IEnumerable<string> TimeseriesIds { get; set; }
		public string DeploymentProject { get; set; }
		public string CiBackLink { get; set; }
		public string RemediationAction { get; set; }
		public string Original { get; set; }
		public string Changed { get; set; }
		public string Configuration { get; set; }
		public string Title { get; set; }
		public bool? AllowDavisMerge { get; set; }
	}
}
