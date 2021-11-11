using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ConsultaProcessualAPI.Configurations
{
    public static class ApiBehaviorOptionsConfig
    {
        public static IServiceCollection AddApiBehaviorOptionsConfiguration(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
                options.SuppressModelStateInvalidFilter = true);

            return services;
        }
    }
}
