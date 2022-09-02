using CINEMATRIX.API.Application.Commands.SeatCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.Data.Services;

namespace CINEMATRIX.API.Application.Validation.Seat
{
    public class AddSeatValidator : SeatValidatorBase<AddSeatCommand, long>
    {
        public AddSeatValidator(ISeatTypeService seatTypeService, IHallService hallService)
            : base(seatTypeService, hallService) { }
    }
}
