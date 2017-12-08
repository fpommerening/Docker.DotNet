using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet.Models.Swarm;

namespace Docker.DotNet
{
    public class ConfigOperations : IConfigOperations
    {
        private readonly DockerClient _client;
        public ConfigOperations(DockerClient client)
        {
            _client = client;
        }

        public Task<IList<Config>> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<ConfigCreateResponse> CreateAsync(ConfigSpec body, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<Config> InspectAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
