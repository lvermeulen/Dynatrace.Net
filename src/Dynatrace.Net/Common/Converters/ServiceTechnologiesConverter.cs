﻿using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ServiceTechnologiesConverter : JsonEnumConverter<ServiceTechnologies>
	{
		private static readonly Dictionary<ServiceTechnologies, string> s_pairs = new Dictionary<ServiceTechnologies, string>
		{
			[ServiceTechnologies.ActiveMq] = "ACTIVE_MQ",
			[ServiceTechnologies.ActiveMqArtemis] = "ACTIVE_MQ_ARTEMIS",
			[ServiceTechnologies.AdoNet] = "ADO_NET",
			[ServiceTechnologies.Aix] = "AIX",
			[ServiceTechnologies.Akka] = "AKKA",
			[ServiceTechnologies.AmazonRedshift] = "AMAZON_REDSHIFT",
			[ServiceTechnologies.Amqp] = "AMQP",
			[ServiceTechnologies.ApacheCamel] = "APACHE_CAMEL",
			[ServiceTechnologies.ApacheCassandra] = "APACHE_CASSANDRA",
			[ServiceTechnologies.ApacheCouchDb] = "APACHE_COUCH_DB",
			[ServiceTechnologies.ApacheDerby] = "APACHE_DERBY",
			[ServiceTechnologies.ApacheHttpClientAsync] = "APACHE_HTTP_CLIENT_ASYNC",
			[ServiceTechnologies.ApacheHttpClientSync] = "APACHE_HTTP_CLIENT_SYNC",
			[ServiceTechnologies.ApacheHttpServer] = "APACHE_HTTP_SERVER",
			[ServiceTechnologies.ApacheKafka] = "APACHE_KAFKA",
			[ServiceTechnologies.ApacheSolr] = "APACHE_SOLR",
			[ServiceTechnologies.ApacheStorm] = "APACHE_STORM",
			[ServiceTechnologies.ApacheSynapse] = "APACHE_SYNAPSE",
			[ServiceTechnologies.ApacheTomcat] = "APACHE_TOMCAT",
			[ServiceTechnologies.Apparmor] = "APPARMOR",
			[ServiceTechnologies.ApplicationInsightsSdk] = "APPLICATION_INSIGHTS_SDK",
			[ServiceTechnologies.AspDotnet] = "ASP_DOTNET",
			[ServiceTechnologies.AspDotnetCore] = "ASP_DOTNET_CORE",
			[ServiceTechnologies.AspDotnetCoreSignalr] = "ASP_DOTNET_CORE_SIGNALR",
			[ServiceTechnologies.AspDotnetSignalr] = "ASP_DOTNET_SIGNALR",
			[ServiceTechnologies.AsyncHttpClient] = "ASYNC_HTTP_CLIENT",
			[ServiceTechnologies.AwsLambda] = "AWS_LAMBDA",
			[ServiceTechnologies.AwsRds] = "AWS_RDS",
			[ServiceTechnologies.AwsService] = "AWS_SERVICE",
			[ServiceTechnologies.Axis] = "AXIS",
			[ServiceTechnologies.AzureFunctions] = "AZURE_FUNCTIONS",
			[ServiceTechnologies.AzureServiceBus] = "AZURE_SERVICE_BUS",
			[ServiceTechnologies.AzureServiceFabric] = "AZURE_SERVICE_FABRIC",
			[ServiceTechnologies.AzureStorage] = "AZURE_STORAGE",
			[ServiceTechnologies.Boshbpm] = "BOSHBPM",
			[ServiceTechnologies.Citrix] = "CITRIX",
			[ServiceTechnologies.CitrixCommon] = "CITRIX_COMMON",
			[ServiceTechnologies.CitrixDesktopDeliveryControllers] = "CITRIX_DESKTOP_DELIVERY_CONTROLLERS",
			[ServiceTechnologies.CitrixDirector] = "CITRIX_DIRECTOR",
			[ServiceTechnologies.CitrixLicenseServer] = "CITRIX_LICENSE_SERVER",
			[ServiceTechnologies.CitrixProvisioningServices] = "CITRIX_PROVISIONING_SERVICES",
			[ServiceTechnologies.CitrixStorefront] = "CITRIX_STOREFRONT",
			[ServiceTechnologies.CitrixVirtualDeliveryAgent] = "CITRIX_VIRTUAL_DELIVERY_AGENT",
			[ServiceTechnologies.CitrixWorkspaceEnvironmentManagement] = "CITRIX_WORKSPACE_ENVIRONMENT_MANAGEMENT",
			[ServiceTechnologies.Cloudfoundry] = "CLOUDFOUNDRY",
			[ServiceTechnologies.CloudfoundryAuctioneer] = "CLOUDFOUNDRY_AUCTIONEER",
			[ServiceTechnologies.CloudfoundryBosh] = "CLOUDFOUNDRY_BOSH",
			[ServiceTechnologies.CloudfoundryGorouter] = "CLOUDFOUNDRY_GOROUTER",
			[ServiceTechnologies.Coldfusion] = "COLDFUSION",
			[ServiceTechnologies.Containerd] = "CONTAINERD",
			[ServiceTechnologies.CoreDns] = "CORE_DNS",
			[ServiceTechnologies.Couchbase] = "COUCHBASE",
			[ServiceTechnologies.Crio] = "CRIO",
			[ServiceTechnologies.Cxf] = "CXF",
			[ServiceTechnologies.Datastax] = "DATASTAX",
			[ServiceTechnologies.Db2] = "DB2",
			[ServiceTechnologies.DiegoCell] = "DIEGO_CELL",
			[ServiceTechnologies.Docker] = "DOCKER",
			[ServiceTechnologies.Dotnet] = "DOTNET",
			[ServiceTechnologies.DotnetRemoting] = "DOTNET_REMOTING",
			[ServiceTechnologies.ElasticSearch] = "ELASTIC_SEARCH",
			[ServiceTechnologies.Envoy] = "ENVOY",
			[ServiceTechnologies.Erlang] = "ERLANG",
			[ServiceTechnologies.Etcd] = "ETCD",
			[ServiceTechnologies.F5Ltm] = "F5_LTM",
			[ServiceTechnologies.Fsharp] = "FSHARP",
			[ServiceTechnologies.Garden] = "GARDEN",
			[ServiceTechnologies.Glassfish] = "GLASSFISH",
			[ServiceTechnologies.Go] = "GO",
			[ServiceTechnologies.GraalTruffle] = "GRAAL_TRUFFLE",
			[ServiceTechnologies.Grpc] = "GRPC",
			[ServiceTechnologies.Grsecurity] = "GRSECURITY",
			[ServiceTechnologies.Hadoop] = "HADOOP",
			[ServiceTechnologies.HadoopHdfs] = "HADOOP_HDFS",
			[ServiceTechnologies.HadoopYarn] = "HADOOP_YARN",
			[ServiceTechnologies.Haproxy] = "HAPROXY",
			[ServiceTechnologies.Heat] = "HEAT",
			[ServiceTechnologies.Hessian] = "HESSIAN",
			[ServiceTechnologies.HornetQ] = "HORNET_Q",
			[ServiceTechnologies.IbmCicsRegion] = "IBM_CICS_REGION",
			[ServiceTechnologies.IbmCicsTransactionGateway] = "IBM_CICS_TRANSACTION_GATEWAY",
			[ServiceTechnologies.IbmImsConnectRegion] = "IBM_IMS_CONNECT_REGION",
			[ServiceTechnologies.IbmImsControlRegion] = "IBM_IMS_CONTROL_REGION",
			[ServiceTechnologies.IbmImsMessageProcessingRegion] = "IBM_IMS_MESSAGE_PROCESSING_REGION",
			[ServiceTechnologies.IbmImsSoapGateway] = "IBM_IMS_SOAP_GATEWAY",
			[ServiceTechnologies.IbmIntegrationBus] = "IBM_INTEGRATION_BUS",
			[ServiceTechnologies.IbmMq] = "IBM_MQ",
			[ServiceTechnologies.IbmMqClient] = "IBM_MQ_CLIENT",
			[ServiceTechnologies.IbmWebshprereApplicationServer] = "IBM_WEBSHPRERE_APPLICATION_SERVER",
			[ServiceTechnologies.IbmWebshprereLiberty] = "IBM_WEBSHPRERE_LIBERTY",
			[ServiceTechnologies.Iis] = "IIS",
			[ServiceTechnologies.IisAppPool] = "IIS_APP_POOL",
			[ServiceTechnologies.Istio] = "ISTIO",
			[ServiceTechnologies.Java] = "JAVA",
			[ServiceTechnologies.JaxWs] = "JAX_WS",
			[ServiceTechnologies.Jboss] = "JBOSS",
			[ServiceTechnologies.JbossEap] = "JBOSS_EAP",
			[ServiceTechnologies.JdkHttpServer] = "JDK_HTTP_SERVER",
			[ServiceTechnologies.Jersey] = "JERSEY",
			[ServiceTechnologies.Jetty] = "JETTY",
			[ServiceTechnologies.Jruby] = "JRUBY",
			[ServiceTechnologies.Jython] = "JYTHON",
			[ServiceTechnologies.Kubernetes] = "KUBERNETES",
			[ServiceTechnologies.Libvirt] = "LIBVIRT",
			[ServiceTechnologies.Linkerd] = "LINKERD",
			[ServiceTechnologies.Mariadb] = "MARIADB",
			[ServiceTechnologies.Memcached] = "MEMCACHED",
			[ServiceTechnologies.MicrosoftSqlServer] = "MICROSOFT_SQL_SERVER",
			[ServiceTechnologies.Mongodb] = "MONGODB",
			[ServiceTechnologies.MssqlClient] = "MSSQL_CLIENT",
			[ServiceTechnologies.MuleEsb] = "MULE_ESB",
			[ServiceTechnologies.Mysql] = "MYSQL",
			[ServiceTechnologies.MysqlConnector] = "MYSQL_CONNECTOR",
			[ServiceTechnologies.NetflixServo] = "NETFLIX_SERVO",
			[ServiceTechnologies.Netty] = "NETTY",
			[ServiceTechnologies.Nginx] = "NGINX",
			[ServiceTechnologies.NodeJs] = "NODE_JS",
			[ServiceTechnologies.OkHttpClient] = "OK_HTTP_CLIENT",
			[ServiceTechnologies.OneagentSdk] = "ONEAGENT_SDK",
			[ServiceTechnologies.Opencensus] = "OPENCENSUS",
			[ServiceTechnologies.Openshift] = "OPENSHIFT",
			[ServiceTechnologies.OpenstackCompute] = "OPENSTACK_COMPUTE",
			[ServiceTechnologies.OpenstackController] = "OPENSTACK_CONTROLLER",
			[ServiceTechnologies.Opentelemetry] = "OPENTELEMETRY",
			[ServiceTechnologies.Opentracing] = "OPENTRACING",
			[ServiceTechnologies.OpenLiberty] = "OPEN_LIBERTY",
			[ServiceTechnologies.OracleDatabase] = "ORACLE_DATABASE",
			[ServiceTechnologies.OracleWeblogic] = "ORACLE_WEBLOGIC",
			[ServiceTechnologies.Owin] = "OWIN",
			[ServiceTechnologies.Perl] = "PERL",
			[ServiceTechnologies.Php] = "PHP",
			[ServiceTechnologies.PhpFpm] = "PHP_FPM",
			[ServiceTechnologies.Play] = "PLAY",
			[ServiceTechnologies.PostgreSql] = "POSTGRE_SQL",
			[ServiceTechnologies.PostgreSqlDotnetDataProvider] = "POSTGRE_SQL_DOTNET_DATA_PROVIDER",
			[ServiceTechnologies.PowerDns] = "POWER_DNS",
			[ServiceTechnologies.Progress] = "PROGRESS",
			[ServiceTechnologies.Python] = "PYTHON",
			[ServiceTechnologies.RabbitMq] = "RABBIT_MQ",
			[ServiceTechnologies.Redis] = "REDIS",
			[ServiceTechnologies.Resteasy] = "RESTEASY",
			[ServiceTechnologies.Restlet] = "RESTLET",
			[ServiceTechnologies.Riak] = "RIAK",
			[ServiceTechnologies.Ruby] = "RUBY",
			[ServiceTechnologies.SagWebmethodsIs] = "SAG_WEBMETHODS_IS",
			[ServiceTechnologies.Sap] = "SAP",
			[ServiceTechnologies.SapHanadb] = "SAP_HANADB",
			[ServiceTechnologies.SapHybris] = "SAP_HYBRIS",
			[ServiceTechnologies.SapMaxdb] = "SAP_MAXDB",
			[ServiceTechnologies.SapSybase] = "SAP_SYBASE",
			[ServiceTechnologies.Scala] = "SCALA",
			[ServiceTechnologies.Selinux] = "SELINUX",
			[ServiceTechnologies.Sharepoint] = "SHAREPOINT",
			[ServiceTechnologies.Spark] = "SPARK",
			[ServiceTechnologies.Spring] = "SPRING",
			[ServiceTechnologies.Sqlite] = "SQLITE",
			[ServiceTechnologies.Thrift] = "THRIFT",
			[ServiceTechnologies.Tibco] = "TIBCO",
			[ServiceTechnologies.TibcoBusinessWorks] = "TIBCO_BUSINESS_WORKS",
			[ServiceTechnologies.TibcoEms] = "TIBCO_EMS",
			[ServiceTechnologies.VarnishCache] = "VARNISH_CACHE",
			[ServiceTechnologies.Vim2] = "VIM2",
			[ServiceTechnologies.VirtualMachineKvm] = "VIRTUAL_MACHINE_KVM",
			[ServiceTechnologies.VirtualMachineQemu] = "VIRTUAL_MACHINE_QEMU",
			[ServiceTechnologies.Wildfly] = "WILDFLY",
			[ServiceTechnologies.WindowsContainers] = "WINDOWS_CONTAINERS",
			[ServiceTechnologies.Wink] = "WINK",
			[ServiceTechnologies.ZeroMq] = "ZERO_MQ"
		};

		protected override Dictionary<ServiceTechnologies, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "service technology";
	}
}