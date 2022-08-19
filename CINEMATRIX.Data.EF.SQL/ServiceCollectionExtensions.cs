using Microsoft.Extensions.DependencyInjection;

namespace CINEMATRIX.Data.EF.SQL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
        }
    }
}
