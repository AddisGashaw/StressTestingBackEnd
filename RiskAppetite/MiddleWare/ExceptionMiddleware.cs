using System.Net;
using Cbe.DomainException;
using Newtonsoft.Json;

namespace Cbe.MiddleWare;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (DataNotFoundException ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;
            await HandleExceptionAsync(context, ex);
        }
        catch (DomainValidationException ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            await HandleExceptionAsync(context, ex);
        }
        catch (UnAuthorized ex)
        {

            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            await HandleExceptionAsync(context, ex);
        }
        catch (Exception ex)
        {

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await HandleExceptionAsync(context, ex);
        }
       
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        

        // Create and return the error response
        var errorResponse = new ErrorResponseModel
        {
            Message = exception.Message,
            StatusCode = context.Response.StatusCode
        };

        // You can log the exception here if needed

        return context.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
    }

}