using AutoMapper;
using CINEMATRIX.API.Application.Commands.Abstractions;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Commands.TicketCommands
{
    public class AddTicketCommand : CommandBase<long, TicketDTO>
    {
        public string UserName { get; set; }
        public AddTicketCommand(TicketDTO ticket, string username) : base(ticket)
        {
            UserName = username;
        }
    }

    public class AddTicketCommandHandler : IRequestHandler<AddTicketCommand, long>
    {
        private readonly ITicketService _ticketService;
        private readonly IUserService _userService;
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public AddTicketCommandHandler(ITicketService ticketService, IUserService userService, IProfileService profileService, IMapper mapper)
        {
            _ticketService = ticketService;
            _userService = userService;
            _profileService = profileService;
            _mapper = mapper;
        }

        public async Task<long> Handle(AddTicketCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByUserNameAsync(request.UserName);
            if (user == null)
            {
                throw new System.Exception("User wasn't finded");
            }

            var profile = await _profileService.GetByIdAsync(user.ProfileId);
            if (user == null)
            {
                throw new System.Exception("User profile wasn't finded");
            }

            var ticket = _mapper.Map<Ticket>(request.Entity);
            ticket.ProfileId = profile.Id;

            var insertedTicket = await _ticketService.InsertAsync(ticket);

            return insertedTicket.Id;
        }
    }
}
