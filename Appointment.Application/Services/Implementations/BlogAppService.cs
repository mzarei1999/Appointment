using Appointment.Application.Infrastructure;
using Appointment.Application.Services.Interfaces;
using Appointment.Domain.Dtos.Blog;
using Appointment.Domain.Entities;
using Appointment.Domain.Interfaces;

namespace Appointment.Application.Services.Implementations
{
    public class BlogAppService: BlogService
    {
        private readonly BlogRepository _blogRepository;
        private readonly UnitOfWork _unitOfWork;

        public BlogAppService(BlogRepository blogRepository,
            UnitOfWork unitOfWork)
        {
            _blogRepository = blogRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateBlog(CreateBlogDto dto)
        {
            var blog = new Blog()
            {
                Id = Guid.NewGuid().ToString(),
                Title = dto.Title,
                Body = dto.Body,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
            };

            _blogRepository.Add(blog);

            await _unitOfWork.Complete();
        }
    }
}
