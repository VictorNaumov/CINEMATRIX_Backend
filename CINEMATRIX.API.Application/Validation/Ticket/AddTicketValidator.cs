using CINEMATRIX.API.Application.Commands.TicketCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.Data.Services;

namespace CINEMATRIX.API.Application.Validation.Ticket
{
    public class AddTicketValidator : TicketValidatorBase<AddTicketCommand, long>
    {
        public AddTicketValidator(ISessionService sessionService, ISeatService seatService) : base(sessionService, seatService) { }
    }
}
