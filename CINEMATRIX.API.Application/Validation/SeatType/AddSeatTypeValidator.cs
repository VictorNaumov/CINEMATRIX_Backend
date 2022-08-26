using CINEMATRIX.API.Application.Commands.SeatTypeCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;

namespace CINEMATRIX.API.Application.Validation.SeatType
{
    public class AddSeatTypeValidator : SeatTypeValidatorBase<AddSeatTypeCommand, long>
    {
        public AddSeatTypeValidator() : base() { }
    }
}
