using Fluid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using System;

namespace OrchardCore.Cms.Module1
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapRazorPages();
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "OrchardCore.Cms.Module1",
                pattern: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
