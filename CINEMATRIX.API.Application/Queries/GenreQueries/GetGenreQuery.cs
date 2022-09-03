using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.GenreQueries
{
    public class GetGenreQuery : IRequest<FoundGenreDTO>
    {
        public long Id { get; }

        public GetGenreQuery(long id)
        {
            Id = id;
        }
    }

    public class GetGenreQueryHandler : IRequestHandler<GetGenreQuery, FoundGenreDTO>
    {
        private readonly IGenreService _genreService;

        public GetGenreQueryHandler(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public async Task<FoundGenreDTO> Handle(GetGenreQuery request, CancellationToken cancellationToken)
        {
            return await _genreService.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
