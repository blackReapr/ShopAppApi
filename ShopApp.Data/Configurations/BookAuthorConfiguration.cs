﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Data.Entities;

namespace ShopApp.Data.Configurations;

internal class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.HasOne(ba => ba.Book).WithMany(b => b.BookAuthors).HasForeignKey(ba => ba.BookId);
        builder.HasOne(ba => ba.Author).WithMany(b => b.BookAuthors).HasForeignKey(ba => ba.AuthorId);
        builder.HasKey(ba => new { ba.BookId, ba.AuthorId });
    }
}