//using AutoMapper;
//using CINEMATRIX.API.Contracts.IncomingOutgoing;
//using CINEMATRIX.Data.Services;
//using MediatR;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CINEMATRIX.API.Application.Queries.GenreQueries
//{
//    public class GetGenreQuery : IRequest<GenreDTO>
//    {
//        public long Id { get; }

//        public GetGenreQuery(long id)
//        {
//            Id = id;
//        }
//    }

//    public class GetProductQueryHandler : IRequestHandler<GetGenreQuery, GenreDTO>
//    {
//        private readonly IGenreService _foodService;
//        private readonly IMapper _mapper;

//        public GetProductQueryHandler(IGenreService foodService, IMapper mapper)
//        {
//            _foodService = foodService;
//            _mapper = mapper;
//        }

//        public async Task<GenreDTO> Handle(GetGenreQuery request, CancellationToken cancellationToken)
//        {
//            var food = await _foodService.GetAsync(request.Id, cancellationToken);

//            if (food == null)
//            {
//                return null;
//            }

//            var mappedGenre = _mapper.Map<GenreDTO>(food);

//            return mappedGenre;
//        }
//    }
//}
