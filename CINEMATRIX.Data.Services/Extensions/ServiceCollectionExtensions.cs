using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace CINEMATRIX.Data.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationDbContext();
            services.AddServices();
        }
        private static void AddServices(this IServiceCollection services)
        {
            var currentAssembly = typeof(ServiceCollectionExtensions);

            services.Scan(scan => scan.FromAssembliesOf(currentAssembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IBaseService<>)))
                .AsImplementedInterfaces()
                .WithTransientLifetime()
            );

        }
    }
}
