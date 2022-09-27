using Appointment.Domain.Dtos.Blog;

namespace Appointment.Application.Services.Interfaces
{
    public interface BlogService
    {
        Task CreateBlog(CreateBlogDto dto);
    }
}
