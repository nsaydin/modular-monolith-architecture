using System.Threading;
using System.Threading.Tasks;
using Protein.Shared.Abstractions.Commands;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Shared.Abstractions.Dispatchers
{
    public interface IDispatcher
    {
        Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
    }
}