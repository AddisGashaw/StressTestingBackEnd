
namespace Cbe.DomainException;

public class CmsException:Exception
{
    private String message;

    public CmsException(string message):base(message)
    {
        this.message = message;
    }
}