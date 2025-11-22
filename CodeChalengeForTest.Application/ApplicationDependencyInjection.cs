using CodeChalengeForTest.Application.Command;
using CodeChalengeForTest.Application.CommandHandler;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CodeChalengeForTest.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationDependencyInjection(this IServiceCollection services)
        {
  
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(
                    Assembly.GetExecutingAssembly(),                    // current project assembly
                    typeof(CodeChalengeForTest.Application.CommandHandler.LoginUserCommandHandler).Assembly // handler assembly
                );
            });
            return services;
        }
    }
}
