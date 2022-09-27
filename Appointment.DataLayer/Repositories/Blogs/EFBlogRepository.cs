using Appointment.Domain.Entities;
using Appointment.Domain.Interfaces;

namespace Appointment.DataLayer.Repositories.Blogs
{
    public class EFBlogRepository: BlogRepository
    {
        private readonly EFDataContext _context;
        public EFBlogRepository(EFDataContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Blog blog)
        {
            _context.Blogs.Add(blog);
        }
    }
}
