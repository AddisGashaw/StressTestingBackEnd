namespace Cbe.DomainException;

public class DataNotFoundException:CmsException
{
    public DataNotFoundException(string message) : base(message)
    {
    }
}