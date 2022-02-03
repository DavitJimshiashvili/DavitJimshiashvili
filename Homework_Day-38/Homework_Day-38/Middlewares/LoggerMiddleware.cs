using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Homework_Day_38.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<WeatherForecast> _logger;

        public LoggerMiddleware(RequestDelegate next, ILogger<WeatherForecast> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
            }
            finally
            {
                var statusCode = httpContext.Response.StatusCode;

                if (statusCode ==200)
                {
                    _logger.LogInformation("proccess is going without errors");
                }
                else if (statusCode >= 400 && statusCode < 500)
                {
                    _logger.LogWarning("warning");
                }
                else if (statusCode >= 500)
                {
                    _logger.LogError("error occured");
                }
            }
        }

      
    }
}
