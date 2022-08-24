using CINEMATRIX.API.Application.Commands.ProfileCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;

namespace CINEMATRIX.API.Application.Validation.Profile
{
    public class AddProfileValidator : ProfileValidatorBase<AddProfileCommand, long>
    {
        public AddProfileValidator() : base() { }
    }
}
