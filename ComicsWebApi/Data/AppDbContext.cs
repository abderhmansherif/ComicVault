using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsWebApi.Config;
using ComicsWebApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ComicsWebApi.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Comic> Comics { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<FavoriteComics> FavoriteComics { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<ReadingHistory> ReadingHistories { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComicConfiguration).Assembly);
        }
    }
}