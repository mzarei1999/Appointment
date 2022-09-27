using Appointment.Application.Services.Interfaces;
using Appointment.Domain.Dtos.Blog;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.RestApi.Controllers.Blogs
{
    public class BlogsController: ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogsController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost("add-blog")]
        public async Task AddBlog(CreateBlogDto dto)
        {
            await _blogService.CreateBlog(dto);
        }
    }
}
