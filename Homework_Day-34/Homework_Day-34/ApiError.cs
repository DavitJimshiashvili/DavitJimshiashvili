using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesService.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Homework_Day_34
{
    
        public class ApiError : ProblemDetails
        {
            public const string UnhandledError = "UnhandledException";
            private HttpContext _context;
            private Exception _exception;

            public LogLevel LogLevel { get; set; }
            public string Code { get; set; }
            public string TraceId
            {
                get
                {
                    if (Extensions.TryGetValue("TraceId", out var traceId))
                    {
                        return (string)traceId;
                    }

                    return null;
                }
                set => Extensions["TraceId"] = value;
            }

            public ApiError(HttpContext context, Exception exception)
            {
                _context = context;
                _exception = exception;

                TraceId = context.TraceIdentifier;
                Code = "UnhandledErrorCode";
                Title = exception.Message;
                LogLevel = LogLevel.Error;
                Instance = context.Request.Path;

                HandleException((dynamic)exception);
            }

            private void HandleException(MovieDoesnotExsists exception)
            {
                Code = exception.Code;
                Status = (int)HttpStatusCode.NotFound;
                Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
                Title = exception.Message;
                LogLevel = LogLevel.Trace;
            }

            private void HandleException(MovieAlreadyExists exception)
            {
                Code = exception.Code;
                Status = (int)HttpStatusCode.Conflict;
                Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
                Title = exception.Message;
                LogLevel = LogLevel.Information;
            }

            private void HandleException(InputMovieInvalid exception)
            {
                Code = exception.Code;
                Status = (int)HttpStatusCode.BadRequest;
                Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
                Title = exception.Message;
                LogLevel = LogLevel.Information;
            }

        }
    }

