using Appointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Appointment.DataLayer.Repositories.Blogs
{
    public class BlogEntityMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> _)
        {
            _.ToTable("Blogs");

            _.HasKey(_ => _.Id);

            _.Property(_ => _.Id)
                .ValueGeneratedNever()
                .HasMaxLength(450);

            _.Property(_ => _.Title)
                .IsRequired()
                .HasMaxLength(150);

            _.Property(_ => _.Body)
                .IsRequired()
                .HasMaxLength(1500);

            _.Property(_ => _.CreatedDate)
                .IsRequired();

            _.Property(_ => _.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
