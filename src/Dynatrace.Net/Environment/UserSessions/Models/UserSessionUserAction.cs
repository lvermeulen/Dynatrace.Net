using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class UserSessionUserAction
	{
		public string Name { get; set; }
		public string Domain { get; set; }
		public string TargetUrl { get; set; }
		[JsonConverter(typeof(UserSessionUserActionTypesConverter))]
		public UserSessionUserActionTypes? Type { get; set; }
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
		public int? Duration { get; set; }
		public string Application { get; set; }
		public string InternalApplicationId { get; set; }
		public string InternalKeyUserActionId { get; set; }
		public int? SpeedIndex { get; set; }
		public int? ErrorCount { get; set; }
		[JsonConverter(typeof(ApdexTypesConverter))]
		public ApdexTypes? ApdexCategory { get; set; }
		public IEnumerable<string> MatchingConversionGoals { get; set; }
		public int? NetworkTime { get; set; }
		public int? ServerTime { get; set; }
		public int? FrontendTime { get; set; }
		public int? DocumentInteractiveTime { get; set; }
		public int? FailedImages { get; set; }
		public int? FailedXhrRequests { get; set; }
		public int? HttpRequestsWithErrors { get; set; }
		public int? ThirdPartyResources { get; set; }
		public int? ThirdPartyBusyTime { get; set; }
		public int? CdnResources { get; set; }
		public int? CdnBusyTime { get; set; }
		public int? FirstPartyResources { get; set; }
		public int? FirstPartyBusyTime { get; set; }
		public bool? HasCrash { get; set; }
		public int? DomCompleteTime { get; set; }
		public int? DomContentLoadedTime { get; set; }
		public int? LoadEventStart { get; set; }
		public int? LoadEventEnd { get; set; }
		public int? NavigationStart { get; set; }
		public int? RequestStart { get; set; }
		public int? ResponseStart { get; set; }
		public int? ResponseEnd { get; set; }
		public int? VisuallyCompleteTime { get; set; }
		public string SyntheticEvent { get; set; }
		public string SyntheticEventId { get; set; }
		public bool? KeyUserAction { get; set; }
		public IEnumerable<StringProperty> StringProperties { get; set; }
		public IEnumerable<LongProperty> LongProperties { get; set; }
		public IEnumerable<DoubleProperty> DoubleProperties { get; set; }
		public IEnumerable<DateProperty> DateProperties { get; set; }
		public int? UserActionPropertyCount { get; set; }
		public int? CustomErrorCount { get; set; }
		public int? JavascriptErrorCount { get; set; }
		public int? RequestErrorCount { get; set; }
	}
}
