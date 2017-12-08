using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using   Docker.DotNet.Models.Swarm;

namespace Docker.DotNet
{
    public interface IConfigOperations
    {
        Task<IList<Config>> ListAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<ConfigCreateResponse> CreateAsync(ConfigSpec body, CancellationToken cancellationToken = default(CancellationToken));

        Task<Config> InspectAsync(string id, CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
    }
}
