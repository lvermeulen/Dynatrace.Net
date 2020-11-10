using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class IibNodeTypesConverter : JsonEnumConverter<IibNodeTypes>
	{
		private static readonly Dictionary<IibNodeTypes, string> s_pairs = new Dictionary<IibNodeTypes, string>
		{
			[IibNodeTypes.AggregateControlNode] = "AGGREGATE_CONTROL_NODE",
			[IibNodeTypes.AggregateReplyNode] = "AGGREGATE_REPLY_NODE",
			[IibNodeTypes.AggregateRequestNode] = "AGGREGATE_REQUEST_NODE",
			[IibNodeTypes.CallableFlowReplyNode] = "CALLABLE_FLOW_REPLY_NODE",
			[IibNodeTypes.CollectorNode] = "COLLECTOR_NODE",
			[IibNodeTypes.ComputeNode] = "COMPUTE_NODE",
			[IibNodeTypes.DatabaseNode] = "DATABASE_NODE",
			[IibNodeTypes.DecisionServiceNode] = "DECISION_SERVICE_NODE",
			[IibNodeTypes.DotNetComputeNode] = "DOT_NET_COMPUTE_NODE",
			[IibNodeTypes.FileReadNode] = "FILE_READ_NODE",
			[IibNodeTypes.FilterNode] = "FILTER_NODE",
			[IibNodeTypes.FlowOrderNode] = "FLOW_ORDER_NODE",
			[IibNodeTypes.GroupCompleteNode] = "GROUP_COMPLETE_NODE",
			[IibNodeTypes.GroupGatherNode] = "GROUP_GATHER_NODE",
			[IibNodeTypes.GroupScatterNode] = "GROUP_SCATTER_NODE",
			[IibNodeTypes.HttpHeader] = "HTTP_HEADER",
			[IibNodeTypes.JavaComputeNode] = "JAVA_COMPUTE_NODE",
			[IibNodeTypes.JmsClientReceive] = "JMS_CLIENT_RECEIVE",
			[IibNodeTypes.JmsClientReplyNode] = "JMS_CLIENT_REPLY_NODE",
			[IibNodeTypes.JmsHeader] = "JMS_HEADER",
			[IibNodeTypes.MqGetNode] = "MQ_GET_NODE",
			[IibNodeTypes.MqOutputNode] = "MQ_OUTPUT_NODE",
			[IibNodeTypes.PassthruNode] = "PASSTHRU_NODE",
			[IibNodeTypes.ResetContentDescriptorNode] = "RESET_CONTENT_DESCRIPTOR_NODE",
			[IibNodeTypes.ReSequenceNode] = "RE_SEQUENCE_NODE",
			[IibNodeTypes.RouteNode] = "ROUTE_NODE",
			[IibNodeTypes.SapReplyNode] = "SAP_REPLY_NODE",
			[IibNodeTypes.ScaReplyNode] = "SCA_REPLY_NODE",
			[IibNodeTypes.SecurityPep] = "SECURITY_PEP",
			[IibNodeTypes.SequenceNode] = "SEQUENCE_NODE",
			[IibNodeTypes.SoapExtractNode] = "SOAP_EXTRACT_NODE",
			[IibNodeTypes.SoapReplyNode] = "SOAP_REPLY_NODE",
			[IibNodeTypes.SoapWrapperNode] = "SOAP_WRAPPER_NODE",
			[IibNodeTypes.SrRetrieveEntityNode] = "SR_RETRIEVE_ENTITY_NODE",
			[IibNodeTypes.SrRetrieveItServiceNode] = "SR_RETRIEVE_IT_SERVICE_NODE",
			[IibNodeTypes.ThrowNode] = "THROW_NODE",
			[IibNodeTypes.TraceNode] = "TRACE_NODE",
			[IibNodeTypes.TryCatchNode] = "TRY_CATCH_NODE",
			[IibNodeTypes.ValidateNode] = "VALIDATE_NODE",
			[IibNodeTypes.WsReplyNode] = "WS_REPLY_NODE",
			[IibNodeTypes.XslMqsiNode] = "XSL_MQSI_NODE"
		};

		protected override Dictionary<IibNodeTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "node type";
	}
}
