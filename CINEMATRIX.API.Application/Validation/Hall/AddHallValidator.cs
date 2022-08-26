using CINEMATRIX.API.Application.Commands.HallCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;

namespace CINEMATRIX.API.Application.Validation.Hall
{
    public class AddHallValidator : HallValidatorBase<AddHallCommand, long>
    {
        public AddHallValidator() : base() { }
    }
}
