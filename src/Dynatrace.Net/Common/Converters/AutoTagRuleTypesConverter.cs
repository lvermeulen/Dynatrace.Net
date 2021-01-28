using System.Collections.Generic;
using Dynatrace.Net.Configuration.AutoTags.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AutoTagRuleTypesConverter : JsonEnumConverter<AutoTagRuleTypes>
	{
		private static readonly Dictionary<AutoTagRuleTypes, string> s_pairs = new Dictionary<AutoTagRuleTypes, string>
		{
			[AutoTagRuleTypes.Application] = "APPLICATION",
			[AutoTagRuleTypes.AwsApplicationLoadBalancer] = "AWS_APPLICATION_LOAD_BALANCER",
			[AutoTagRuleTypes.AwsClassicLoadBalancer] = "AWS_CLASSIC_LOAD_BALANCER",
			[AutoTagRuleTypes.AwsNetworkLoadBalancer] = "AWS_NETWORK_LOAD_BALANCER",
			[AutoTagRuleTypes.AwsRelationalDatabaseService] = "AWS_RELATIONAL_DATABASE_SERVICE",
			[AutoTagRuleTypes.Azure] = "AZURE",
			[AutoTagRuleTypes.CustomApplication] = "CUSTOM_APPLICATION",
			[AutoTagRuleTypes.CustomDevice] = "CUSTOM_DEVICE",
			[AutoTagRuleTypes.DcrumApplication] = "DCRUM_APPLICATION",
			[AutoTagRuleTypes.EsxiHost] = "ESXI_HOST",
			[AutoTagRuleTypes.ExternalSyntheticTest] = "EXTERNAL_SYNTHETIC_TEST",
			[AutoTagRuleTypes.Host] = "HOST",
			[AutoTagRuleTypes.HttpCheck] = "HTTP_CHECK",
			[AutoTagRuleTypes.MobileApplication] = "MOBILE_APPLICATION",
			[AutoTagRuleTypes.ProcessGroup] = "PROCESS_GROUP",
			[AutoTagRuleTypes.Service] = "SERVICE",
			[AutoTagRuleTypes.SyntheticTest] = "SYNTHETIC_TEST"
		};

		protected override Dictionary<AutoTagRuleTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "auto-tag rule type";
	}
}
