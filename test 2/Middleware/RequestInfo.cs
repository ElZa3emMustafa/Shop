using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace test_2.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestInfo
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public RequestInfo(RequestDelegate next, LoggerFactory logFactory)
        {
            _next = next;
            _logger = logFactory.CreateLogger<RequestInfo>();
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("Handle request: " + httpContext.Request.Path); // MIDDLE WARE
            await _next.Invoke(httpContext);
            _logger.LogInformation("Middleware finished");


            // return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestInfoExtensions
    {
        public static IApplicationBuilder UseRequestInfo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestInfo>();


        }
    }
}
