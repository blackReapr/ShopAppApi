﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Data.Entities;

namespace ShopApp.Data.Configurations;

internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
        builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
    }
}
