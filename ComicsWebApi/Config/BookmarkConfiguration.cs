using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicsWebApi.Config
{
    public class BookmarkConfiguration : IEntityTypeConfiguration<Bookmark>
    {
        public void Configure(EntityTypeBuilder<Bookmark> builder)
        {
            builder.ToTable("Bookmarks");

            builder.HasKey(x => new { x.PageId, x.ComicId, x.UserId });

            builder.HasOne(x => x.Comic)
               .WithMany(c => c.Bookmarks)
               .HasForeignKey(x => x.ComicId)
               .IsRequired(true)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Page)
                .WithMany(c => c.Bookmarks)
                .HasForeignKey(x => x.PageId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Bookmarks)
                .HasForeignKey(x => x.UserId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}