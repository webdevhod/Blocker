using Blockter.Crosscutting.Constants;

namespace Blockter.Crosscutting.Exceptions;

public class LoginAlreadyUsedException : BadRequestAlertException
{
    public LoginAlreadyUsedException() : base(ErrorConstants.LoginAlreadyUsedType, "Login name is already in use!",
        "userManagement", "userexists")
    {
    }
}
