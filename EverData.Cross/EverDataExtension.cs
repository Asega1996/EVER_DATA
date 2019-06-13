using EverData.Models.Contracts;
using EverData.Repository;
using EverData.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EverData.Cross
{
    public static class EverDataExtension
    {
        public static IServiceCollection AddEverDataServices(this IServiceCollection services) {

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
