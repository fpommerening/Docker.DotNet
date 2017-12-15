using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: client.go/ServiceListOptions 
    /// Source: filters/parse.go/Args 
    /// </summary>
    [DataContract]
    public class ServicesListOptions
    {
        [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
        public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
    }
}
