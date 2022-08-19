using CINEMATRIX.API.Application.Validation;
using CINEMATRIX.Data.Services.Extensions;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CINEMATRIX.API.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddValidators();
            services.AddApplicationServices();
        }

        private static void AddValidators(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.Scan(x =>
                    {
                        var entryAssembly = Assembly.GetEntryAssembly();
                        IEnumerable<Assembly> referencedAssemblies = entryAssembly.GetReferencedAssemblies().Select(Assembly.Load);
                        IEnumerable<Assembly> assemblies = new List<Assembly> { entryAssembly }.Concat(referencedAssemblies);

                        x.FromAssemblies(assemblies)
                            .AddClasses(classes => classes.AssignableTo(typeof(IValidator<>)))
                            .AsImplementedInterfaces()
                            .WithScopedLifetime();
                    });
        }
    }
}
