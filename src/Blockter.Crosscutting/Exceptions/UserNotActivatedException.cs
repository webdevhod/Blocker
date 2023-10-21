using System.Security.Authentication;

namespace Blockter.Crosscutting.Exceptions;

public class UserNotActivatedException : AuthenticationException
{
    public UserNotActivatedException(string message) : base(message)
    {
    }
}
