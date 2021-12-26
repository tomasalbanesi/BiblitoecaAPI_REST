using BiblitoecaAPI_REST.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiblitoecaAPI_REST.Utilities
{
    public class CategoryConfiguration
    {
        public CategoryConfiguration(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdCategory);
            entityTypeBuilder.HasIndex(x => x.IdCategory);
            entityTypeBuilder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
