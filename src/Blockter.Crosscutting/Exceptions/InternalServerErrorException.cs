using Blockter.Crosscutting.Constants;

namespace Blockter.Crosscutting.Exceptions;

public class InternalServerErrorException : BaseException
{
    public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
    {
    }
}
