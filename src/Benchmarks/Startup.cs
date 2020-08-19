using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Benchmarks
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Request.Body.DrainAsync(CancellationToken.None);
                context.Response.StatusCode = StatusCodes.Status200OK;
            });
        }
    }
}
