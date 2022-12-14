using System.Threading;
using System.Threading.Tasks;
using Protein.Shared.Abstractions.Commands;
using Protein.Shared.Abstractions.Queries;

namespace Protein.Shared.Abstractions.Dispatchers
{
    internal sealed class InMemoryDispatcher : IDispatcher
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public InMemoryDispatcher(ICommandDispatcher commandDispatcher,
            IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        public Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand
            => _commandDispatcher.SendAsync(command, cancellationToken);

        public Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default)
            => _queryDispatcher.QueryAsync(query, cancellationToken);
    }
}