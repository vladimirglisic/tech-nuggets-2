using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nugget2.Middelware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ActivityMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ActivityMiddleware> logger;

        public ActivityMiddleware(RequestDelegate next, ILogger<ActivityMiddleware> logger)
        {
            _next = next;
            this.logger = logger;
        }

        public Task Invoke(HttpContext httpContext)
        {
            logger.LogDebug("Middleware invoked.");

            string requestId = httpContext.Request.Headers["X-Request-ID"].FirstOrDefault();

            Activity.Current?.SetTag("SRO-Request-ID", requestId);

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ActivityMiddlewareExtensions
    {
        public static IApplicationBuilder UseActivityMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ActivityMiddleware>();
        }
    }
}
