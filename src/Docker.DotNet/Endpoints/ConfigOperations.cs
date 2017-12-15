using System;
using System.Collections.Generic;
using System.Net.Http;
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

        public async Task<IList<Config>> ListAsync(ConfigListOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            IQueryString queryParameters = new QueryString<ConfigListOptions>(options);

            var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, "configs", queryParameters, cancellationToken).ConfigureAwait(false);
            return this._client.JsonSerializer.DeserializeObject<IList<Config>>(response.Body);
        }

        public async Task<ConfigCreateResponse> CreateAsync(ConfigSpec body, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            var data = new JsonRequestContent<ConfigSpec>(body, this._client.JsonSerializer);
            var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Post, "configs/create", null, data, cancellationToken).ConfigureAwait(false);
            return this._client.JsonSerializer.DeserializeObject<ConfigCreateResponse>(response.Body);
        }

        public async Task<Config> InspectAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            var response = await this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Get, $"configs/{id}", cancellationToken).ConfigureAwait(false);
            return this._client.JsonSerializer.DeserializeObject<Config>(response.Body);
        }

        public Task DeleteAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return this._client.MakeRequestAsync(this._client.NoErrorHandlers, HttpMethod.Delete, $"configs/{id}", cancellationToken);
        }
    }
}
