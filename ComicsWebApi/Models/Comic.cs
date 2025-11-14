using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Comic
    {
        public string Id { get; set; }
        public required string Title { get; set; }
        public string? Descreption { get; set; }
        public decimal FileSize { get; set; }
        public string? FolderId { get; set; }
        public int ViewCount { get; set; }
        public required string FilePath { get; set; }
        public bool IsDeleted { get; set; }
        public DateOnly AddedAt { get; set; }
        public string? UserId { get; set; }

        public Folder? Folder { get; set; }
        public User? User { get; set; }
        public ICollection<Page> Pages { get; set; }
        public ICollection<ReadingHistory>? ReadingHistory { get; set; }
        public ICollection<FavoriteComics> FavoriteComics { get; set; }
        public ICollection<Bookmark>? Bookmarks { get; set; }

        public Comic()
        {
            Id = Guid.NewGuid().ToString();
            IsDeleted = false;
        }
    }
}