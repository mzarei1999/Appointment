using Appointment.Application.Infrastructure;
using Appointment.Application.Services.Implementations;
using Appointment.Application.Services.Interfaces;
using Appointment.DataLayer;
using Appointment.DataLayer.Repositories.Blogs;
using Appointment.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Appointment.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            #region Services

            services.AddScoped<BlogService, BlogAppService>();

            #endregion

            #region Repositories

            services.AddScoped<UnitOfWork, EFUnitOfWork>();
            services.AddScoped<BlogRepository, EFBlogRepository>();

            #endregion
        }
    }
}
