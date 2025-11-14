using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicsWebApi.Config
{
    public class ComicConfiguration : IEntityTypeConfiguration<Comic>
    {
        public void Configure(EntityTypeBuilder<Comic> builder)
        {
            builder.ToTable("Comics");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200)
                .IsRequired(true);

            builder.Property(x => x.Descreption)
                .HasColumnType("VARCHAR")
                .HasMaxLength(600)
                .IsRequired(false);

            builder.Property(x => x.FileSize)
                .HasColumnType("DECIMAL")
                .HasPrecision(10, 2)
                .IsRequired(true);

            builder.Property(x => x.FilePath)
                .HasColumnType("VARCHAR")
                .IsRequired(true);
                

            builder.HasOne(x => x.User)
                .WithMany(u => u.Comics)
                .HasForeignKey(x => x.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Folder)
                .WithMany(f => f.Comcis)
                .HasForeignKey(x => x.FolderId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}