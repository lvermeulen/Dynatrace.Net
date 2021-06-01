using System;
using Dynatrace.Net.Common.Extensions;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dynatrace.Net
{
    public partial class DynatraceClient
    {
        private ISerializer _serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
        });

        private readonly Url _url;
        private readonly string _apiToken;

        private DynatraceClient(string url)
        {
            _url = url;
        }

        public DynatraceClient(string url, string apiToken)
            : this(url)
        {
            _apiToken = apiToken;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        private IFlurlRequest GetBaseUrl() => new Url(_url)
            .AppendPathSegment("api")
            .ConfigureRequest(settings => settings.JsonSerializer = _serializer)
            .WithApiToken(_apiToken);
    }
}
