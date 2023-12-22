using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Newtonsoft.Json;
using System.Net;
using VirtualPetCare.Core.Services;
using VirtualPetCare.Service.Exceptions;

namespace VirtualPetCare.API.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        //private readonly ILoggerService _loggerService;
        public CustomExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger("VirtualPetCare.API");
            //_loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context, ILoggerService loggerService)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                context.Response.ContentType = "application/json";
                var statusCode = ex switch
                {
                    ClientSideException => HttpStatusCode.BadRequest,
                    NotFoundException => HttpStatusCode.NotFound,
                    _ => HttpStatusCode.InternalServerError
                };

                _logger.LogError(ex.Message);

                await loggerService.AddErrorLog(ex, context.Request.Path, context.GetEndpoint().DisplayName);

                context.Response.StatusCode = (int)statusCode;

                

                await context.Response.WriteAsJsonAsync(ex.Message);
            }
        }
    }
}

