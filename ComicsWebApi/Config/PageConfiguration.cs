using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.EntityFrameworkCore;
using ComicsWebApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicsWebApi.Config
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Pages");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PagePath)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200)
                .IsRequired(true);  

            builder.HasOne(x => x.Comic)
                .WithMany(c => c.Pages)
                .HasForeignKey(x => x.ComicId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.PageSize)
                .HasColumnType("DECIMAL")
                .HasPrecision(2, 1)
                .IsRequired(true);
 
        }
    }
}