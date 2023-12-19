namespace Cbe.DomainException;

public class DomainValidationException:CmsException
{
    public DomainValidationException(string message) : base(message)
    {
    }
}