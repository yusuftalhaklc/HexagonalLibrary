using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Persistence.EFConfig
{
    public class BookTagConfiguration : IEntityTypeConfiguration<BookTag>
    {
        public void Configure(EntityTypeBuilder<BookTag> builder)
        {
            builder.ToTable("BookTags");

            builder.HasKey(bt => bt.Id);

            builder.Property(bt => bt.BookId)
                .IsRequired();

            builder.Property(bt => bt.TagId)
                .IsRequired();

            builder.Property(bt => bt.CreatedDate)
                .IsRequired();

            builder.Property(bt => bt.Status)
                .IsRequired();

            builder.HasOne(bt => bt.Book)
                .WithMany()
                .HasForeignKey(bt => bt.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(bt => bt.Tag)
                .WithMany()
                .HasForeignKey(bt => bt.TagId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(bt => new { bt.BookId, bt.TagId })
                .IsUnique();
        }
    }
}

