using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.AuthQueries
{
    public class GetCurrentUserQuery : CommandBase<FoundUserDTO, string>
    {
        public string UserName { get; set; }
        public GetCurrentUserQuery(string userName) : base(userName)
        {
            UserName = userName;
        }
    }

    public class GetCurrentUserQueryHandler : IRequestHandler<GetCurrentUserQuery, FoundUserDTO>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public GetCurrentUserQueryHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<FoundUserDTO> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var currentUser = await _userService.GetByUserNameAsync(request.UserName);
            if (currentUser == null)
            {
                return null;
            }

            var mappedUser = _mapper.Map<FoundUserDTO>(currentUser);

            return mappedUser;
        }

    }
}
