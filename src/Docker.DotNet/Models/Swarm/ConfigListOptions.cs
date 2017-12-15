using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: types.go/ConfigListOptions 
    /// Source: filters/parse.go/Args
    /// </summary>

    [DataContract]
    public class ConfigListOptions { 

        [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
        public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
    }
}
