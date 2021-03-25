using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesConsoleApp.Models;

namespace RecipesConsoleApp.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.Name);

            builder
                .Property(c => c.Name)
                .IsRequired();

            builder
                .Property(c => c.Description)
                .IsRequired(false);

            builder
                .HasMany(c => c.Recipes)
                .WithOne(r => r.Category);
        }
    }
}
