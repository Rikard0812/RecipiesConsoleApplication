using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesConsoleApp.Models;

namespace RecipesConsoleApp.EntityConfigurations
{
    public class AmountTypeConfiguration : IEntityTypeConfiguration<AmountType>
    {
        public void Configure(EntityTypeBuilder<AmountType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
