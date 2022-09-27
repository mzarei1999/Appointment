using Appointment.Domain.Dtos.Blog;

namespace Appointment.TestTools.Blogs
{
    public class BlogDtoBuilder
    {
        private readonly CreateBlogDto _createBlogDto;

        public BlogDtoBuilder()
        {
            _createBlogDto = new CreateBlogDto();
        }

        public BlogDtoBuilder WithTitle(string title)
        {
            _createBlogDto.Title = title;
            return this;
        }

        public BlogDtoBuilder WithBody(string body)
        {
            _createBlogDto.Body = body;
            return this;
        }

        public CreateBlogDto Build()
        {
            return _createBlogDto;
        }
    }
}
