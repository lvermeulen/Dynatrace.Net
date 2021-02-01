using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.ActiveGates.Models
{
	public class UpdateJob
	{
		public string JobId	{ get; set; }
		[JsonConverter(typeof(AutoUpdateJobStatesConverter))]
		public AutoUpdateJobStates? JobState	{ get; set; }
		[JsonConverter(typeof(AutoUpdateJobUpdateMethodsConverter))]
		public AutoUpdateJobUpdateMethods? UpdateMethod	{ get; set; }
		[JsonConverter(typeof(AutoUpdateJobUpdateTypesConverter))]
		public AutoUpdateJobUpdateTypes? UpdateType	{ get; set; }
		public bool? Cancelable	{ get; set; }
		public string StartVersion	{ get; set; }
		public string TargetVersion	{ get; set; }
		public int? Timestamp	{ get; set; }
		[JsonConverter(typeof(ActiveGatesTypesConverter))]
		public ActiveGatesTypes? AgType		{ get; set; }
		public IEnumerable<string> Environments	{ get; set; }
		public string Error	{ get; set; }
		public int? Duration	{ get; set; }
	}
}
