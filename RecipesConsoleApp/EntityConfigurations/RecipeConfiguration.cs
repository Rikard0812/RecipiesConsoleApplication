using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesConsoleApp.Models;

namespace RecipesConsoleApp.EntityConfigurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder
                .HasKey(r => r.RecipeId);
            builder
                .Property(r => r.Name)
                .IsRequired();
            builder
                .Property(r => r.Description)
                .IsRequired();
            builder
                .Property(r => r.Instructions)
                .IsRequired();
            builder
                .HasOne(c => c.Category)
                .WithMany(r => r.Recipes);

        }
    }
}
