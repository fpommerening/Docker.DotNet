using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: swarm/config.go/ConfigReferenceFileTarget
    /// </summary>
    [DataContract]
    public class ConfigReferenceFileTarget
    {
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "UID", EmitDefaultValue = false)]
        public string UID { get; set; }

        [DataMember(Name = "GID", EmitDefaultValue = false)]
        public string GID { get; set; }

        [DataMember(Name = "Mode", EmitDefaultValue = false)]
        public uint Mode { get; set; }
    }
}
