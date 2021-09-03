using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
