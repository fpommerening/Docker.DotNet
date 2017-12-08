using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: swarm/config.go/ConfigReference
    /// </summary>
    [DataContract]
    public class ConfigReference
    {
        [DataMember(Name = "File", EmitDefaultValue = false)]
        public ConfigReferenceFileTarget File { get; set; }

        [DataMember(Name = "ConfigID", EmitDefaultValue = false)]
        public string ConfigID { get; set; }

        [DataMember(Name = "ConfigName", EmitDefaultValue = false)]
        public string ConfigName { get; set; }
    }
}
