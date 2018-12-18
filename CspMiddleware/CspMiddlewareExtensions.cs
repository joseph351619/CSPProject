using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CSPProject
{
    public static class CspMiddlewareExtensions
    {
        public static IApplicationBuilder UseCsp(this IApplicationBuilder application, CspOptions options)
        {
            return application.UseMiddleware<CspMiddleware>(options);
        }
        public static IApplicationBuilder UseCsp(this IApplicationBuilder app, Action<CspOptions> optionsDelegate)
        {
            var options = new CspOptions();
            optionsDelegate(options);
            return app.UseMiddleware<CspMiddleware>(options);
        }
    }
}