using Appointment.Application.Services.Interfaces;
using Appointment.TestTools.Blogs;
using FluentAssertions;
using Xunit;

namespace Appointment.Tests.Unit.BlogsTests
{
    public class BlogServiceTests: PersistentTest
    {
        private readonly BlogService _sut;

        public BlogServiceTests()
        {
            _sut = BlogFactory.GenerateService(_context);
        }

        [Fact]
        private async Task CreateBlog_creates_blog_properly()
        {
            var blog = new BlogDtoBuilder()
                            .WithTitle("dummy-title")
                            .WithBody("dummy-body")
                            .Build();

            await _sut.CreateBlog(blog);

            var expected = _readDataContext.Blogs.ToList();
            expected.Count.Should().Be(1);
            expected.First().Title.Should().Be(blog.Title);
            expected.First().Body.Should().Be(blog.Body);
            expected.First().IsDeleted.Should().Be(false);
        }
    }
}
