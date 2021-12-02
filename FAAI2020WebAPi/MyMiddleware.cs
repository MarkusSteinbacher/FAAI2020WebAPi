using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FAAI2020WebAPi
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MyMiddleware> _logger;

        public MyMiddleware(RequestDelegate next, ILogger<MyMiddleware> logger)
        {
            this._next = next;
            this._logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            this._logger.Log("Test");
            await this._next(httpContext);
        } 
    }
}
