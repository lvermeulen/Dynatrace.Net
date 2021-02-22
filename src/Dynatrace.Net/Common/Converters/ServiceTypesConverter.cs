using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ServiceTypesConverter : JsonEnumConverter<ServiceTypes>
	{
		private static readonly Dictionary<ServiceTypes, string> s_pairs = new Dictionary<ServiceTypes, string>
		{
			[ServiceTypes.Amp] = "AMP",
			[ServiceTypes.Cics] = "Cics",
			[ServiceTypes.CicsInteraction] = "CicsInteraction",
			[ServiceTypes.CustomApplication] = "CustomApplication",
			[ServiceTypes.Database] = "Database",
			[ServiceTypes.EnterpriseServiceBus] = "EnterpriseServiceBus",
			[ServiceTypes.External] = "External",
			[ServiceTypes.Ims] = "Ims",
			[ServiceTypes.ImsInteraction] = "ImsInteraction",
			[ServiceTypes.Messaging] = "Messaging",
			[ServiceTypes.Method] = "Method",
			[ServiceTypes.Mobile] = "Mobile",
			[ServiceTypes.Process] = "Process",
			[ServiceTypes.QueueInteraction] = "QueueInteraction",
			[ServiceTypes.QueueListener] = "QueueListener",
			[ServiceTypes.RemoteCall] = "RemoteCall",
			[ServiceTypes.Rmi] = "Rmi",
			[ServiceTypes.SaasVendor] = "SaasVendor",
			[ServiceTypes.Unknown] = "Unknown",
			[ServiceTypes.WebRequest] = "WebRequest",
			[ServiceTypes.WebService] = "WebService",
			[ServiceTypes.WebSite] = "WebSite"
		};

		protected override Dictionary<ServiceTypes, string> Pairs => s_pairs;

		protected override string EntityString => "service type";
	}
}
