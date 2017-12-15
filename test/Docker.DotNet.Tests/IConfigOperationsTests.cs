using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet.Models;
using Docker.DotNet.Models.Swarm;
using Xunit;

namespace Docker.DotNet.Tests
{
    public class IConfigOperationsTests
    {
        private readonly DockerClient _client;

        public IConfigOperationsTests()
        {
            _client = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine")).CreateClient();
        }

        [Fact]
        public async Task ListAsync_Succeeds()
        {
            var options = new ConfigListOptions
            {
                Filters = new Dictionary<string, IDictionary<string, bool>>
                {
                    {
                    "name", 
                        new Dictionary<string, bool>
                        {
                            {"testconfig",true }
                        }
                    }   
                    
                }
            };

            var result = await _client.Configs.ListAsync(options);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateAsync_Succeeds()
        {
            var body = new ConfigSpec();
            body.Data = System.Text.Encoding.Default.GetBytes("HalloWorld");
            body.Name = "myhalloworld";
            var result = await _client.Configs.CreateAsync(body);
            Assert.NotNull(result);
        }


        [Fact]
        public async Task InspectAsync_Succeeds()
        {
            var result = await _client.Configs.InspectAsync("uzd83y96i9k0demztows9obt6");
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeleteAsync_Succeeds()
        {
            await _client.Configs.DeleteAsync("uzd83y96i9k0demztows9obt6");
        }
    }
}
