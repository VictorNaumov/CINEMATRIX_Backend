using CINEMATRIX.API.Application.Commands.SessionCommands;
using CINEMATRIX.API.Application.Validation.Abstractions;
using CINEMATRIX.Data.Services;

namespace CINEMATRIX.API.Application.Validation.Session
{
    public class AddSessionValidator : SessionValidatorBase<AddSessionCommand, long>
    {
        public AddSessionValidator(IHallService _hallService) : base(_hallService) { }
    }
}
