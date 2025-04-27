using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using GamesStoreWebApp.Core.Errors;

namespace GameStoreWebApp.Api.ActionHelpers;

public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext actionExecutedContext)
    {
        var code = 500;
        if (actionExecutedContext.Exception is NotFoundException)
        {
            code = 404; 
        }

        if (actionExecutedContext.Exception is NullReferenceException)
        {
            code = 400;
        }

        if (actionExecutedContext.Exception is ArgumentException)
        {
            code = 400;
        }


        actionExecutedContext.HttpContext.Response.StatusCode = code;
        actionExecutedContext.Result = new JsonResult(new
        {
            error = actionExecutedContext.Exception.Message
        });
    }
}
