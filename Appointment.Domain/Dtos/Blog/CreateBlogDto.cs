using System.ComponentModel.DataAnnotations;

namespace Appointment.Domain.Dtos.Blog
{
    public class CreateBlogDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Body { get; set; }
    }
}
