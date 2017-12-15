using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: client.go/SecretListOptions  
    /// Source: filters/parse.go/Args 
    /// </summary>
    public class SecretListOptions
    {
        [QueryStringParameter("filters", false, typeof(MapQueryStringConverter))]
        public IDictionary<string, IDictionary<string, bool>> Filters { get; set; }
    }
}
