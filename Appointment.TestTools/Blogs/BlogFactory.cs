using Appointment.Application.Services.Implementations;
using Appointment.Application.Services.Interfaces;
using Appointment.DataLayer;
using Appointment.DataLayer.Repositories.Blogs;

namespace Appointment.TestTools.Blogs
{
    public class BlogFactory
    {
        public static BlogService GenerateService(EFDataContext dbContext)
        {
            var blogRepository = new EFBlogRepository(dbContext);
            var unitOfWork = new EFUnitOfWork(dbContext);
            return new BlogAppService(blogRepository, unitOfWork);
        }
    }
}
