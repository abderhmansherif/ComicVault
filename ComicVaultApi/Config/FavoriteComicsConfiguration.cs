using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicsWebApi.Config
{
    public class FavoriteComicsConfiguration : IEntityTypeConfiguration<FavoriteComics>
    {
        public void Configure(EntityTypeBuilder<FavoriteComics> builder)
        {
            builder.HasKey(x => new { x.UserId, x.ComicId });

            builder.HasOne(x => x.Comic)
                .WithMany(c => c.FavoriteComics)
                .HasForeignKey(x => x.ComicId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x => x.User)
                .WithMany(c => c.FavoriteComics)
                .HasForeignKey(x => x.UserId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}