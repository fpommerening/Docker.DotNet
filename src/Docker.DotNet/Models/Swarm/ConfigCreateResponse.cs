using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: types.go/ConfigCreateResponse
    /// </summary>
    [DataContract]
    public class ConfigCreateResponse 
    {
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }
    }
}
