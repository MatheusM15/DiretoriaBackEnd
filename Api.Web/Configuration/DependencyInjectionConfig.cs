using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Infra.Repository;
using Services.Services;

namespace Api.Web.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISisterServices, SisterServices>();
            services.AddScoped<IMemberServices, MemberServices>();
            services.AddScoped<ISisterRepository, SisterRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
        }
    }
}
