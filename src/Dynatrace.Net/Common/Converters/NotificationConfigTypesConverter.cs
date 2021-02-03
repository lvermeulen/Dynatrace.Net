using System.Collections.Generic;
using Dynatrace.Net.Configuration.Notifications.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class NotificationConfigTypesConverter : JsonEnumConverter<NotificationConfigTypes>
	{
		private static readonly Dictionary<NotificationConfigTypes, string> s_pairs = new Dictionary<NotificationConfigTypes, string>
		{
			[NotificationConfigTypes.AnsibleTower] = "ANSIBLETOWER",
			[NotificationConfigTypes.Email] = "EMAIL",
			[NotificationConfigTypes.HipChat] = "HIPCHAT",
			[NotificationConfigTypes.Jira] = "JIRA",
			[NotificationConfigTypes.OpsGenie] = "OPS_GENIE",
			[NotificationConfigTypes.PagerDuty] = "PAGER_DUTY",
			[NotificationConfigTypes.ServiceNow] = "SERVICE_NOW",
			[NotificationConfigTypes.Slack] = "SLACK",
			[NotificationConfigTypes.Trello] = "TRELLO",
			[NotificationConfigTypes.VictorOps] = "VICTOROPS",
			[NotificationConfigTypes.Webhook] = "WEBHOOK",
			[NotificationConfigTypes.XMatters] = "XMATTERS"
		};

		protected override Dictionary<NotificationConfigTypes, string> Pairs => s_pairs;

		protected override string EntityString => "notification config type";
	}
}
