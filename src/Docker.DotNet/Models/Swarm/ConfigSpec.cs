using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models.Swarm
{
    /// <summary>
    /// Source: swarm/config.go/ConfigSpec
    /// </summary>
    [DataContract]
    public class ConfigSpec
    {
        public ConfigSpec()
        {
            
        }

        public ConfigSpec(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        [DataMember(Name = "Data", EmitDefaultValue = false)]
        public byte[] Data { get; set; }
    }
}