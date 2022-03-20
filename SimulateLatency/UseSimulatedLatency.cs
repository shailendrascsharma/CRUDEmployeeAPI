using Microsoft.AspNetCore.Builder;
using System;

namespace CRUDEmployeeAPI.SimulateLatency
{
    public static class UseSimulatedLatencyExtensions
    {
        public static IApplicationBuilder UseSimulatedLatency(this IApplicationBuilder app, TimeSpan min, TimeSpan max)
        {
            return app.UseMiddleware(typeof(SimulatedLatencyMiddleware), min, max);
        }
    }
}
