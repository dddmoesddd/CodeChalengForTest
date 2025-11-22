using CodeChalengeForTest.Domain.IRepository;
using CodeChalengeForTest.Infrustrcture.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeChalengeForTest.Infrustrcture
{
    public static class InfrustrctureRegisterDependency
    {

        public static IServiceCollection AddInfrustrctureservices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("MyDb")));

            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
