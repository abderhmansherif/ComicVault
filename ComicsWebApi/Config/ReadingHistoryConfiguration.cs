using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicsWebApi.Config
{
    public class ReadingHistoryConfiguration : IEntityTypeConfiguration<ReadingHistory>
    {
        public void Configure(EntityTypeBuilder<ReadingHistory> builder)
        {
            builder.ToTable("ReadingHistories");

            builder.HasKey(x => new { x.UserId, x.ComicId });

            builder.HasOne(x => x.Comic)
                .WithMany(c => c.ReadingHistory)
                .HasForeignKey(x => x.ComicId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x => x.User)
                .WithMany(c => c.ReadingHistory)
                .HasForeignKey(x => x.UserId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}