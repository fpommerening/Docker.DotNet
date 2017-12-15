using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet.Models.Swarm;
using Xunit;

namespace Docker.DotNet.Tests
{
    public class ISwarmOperationsTests
    {
        private readonly DockerClient _client;

        public ISwarmOperationsTests()
        {
            _client = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine")).CreateClient();
        }

        [Fact]
        public async Task GetListServicesAsync_Succeeds()
        {
            var options = new ServicesListOptions();
            options.Filters = new Dictionary<string, IDictionary<string, bool>>
            {
                {
                    "name", new Dictionary<string, bool>
                    {
                        {"myfaas_alertmanager", false }
                    }
                }
            };

            var result = await _client.Swarm.ListServicesAsync(options);
            
        }
    }
}
