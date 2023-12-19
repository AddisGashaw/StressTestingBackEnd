namespace Cbe.DomainException;
public class UnAuthorized : CmsException
{
    public UnAuthorized(string message) : base(message)
    {
    }
}
