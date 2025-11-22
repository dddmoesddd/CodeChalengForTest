using CodeChalengeForTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeChalengeForTest.Infrustrcture.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        { 
            builder.HasData(new
            {
               Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), 
                FirstName = "Admin",
                LastName = "User",
                Phone = "0000000000",
                Email = "admin@example.com",
                UserName = "admin",
                Password = "admin",
                Address_Street = "Admin Street",
                Address_City = "Admin City",
                Address_ZipCode = "00000",
                CreatedAt = new DateTime(2025, 10, 18, 0, 0, 0), 
                UpdatedAt = new DateTime(2025, 10, 18, 0, 0, 0),
            });
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired();
            builder.OwnsOne(u => u.Address, a =>
            {
                a.Property(ad => ad.Street).HasMaxLength(100);
                a.Property(ad => ad.City).HasMaxLength(50);
                a.Property(ad => ad.State).HasMaxLength(50);
                a.Property(ad => ad.PostalCode).HasMaxLength(20);
                a.Property(ad => ad.Country).HasMaxLength(50);
            });

        }
    }
}
