using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using VirtualPetCare.Service.Exceptions;

namespace VirtualPetCare.API.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public CustomExceptionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger("VirtualPetCare.API");
        }

        public async Task Invoke(HttpContext context)
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

                context.Response.StatusCode = (int)statusCode;

                await context.Response.WriteAsJsonAsync(ex.Message);
            }
        }
    }
}

