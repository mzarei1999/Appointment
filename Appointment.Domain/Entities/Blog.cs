namespace Appointment.Domain.Entities
{
    public class Blog
    {
        public Blog()
        {
            IsDeleted = false;
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
