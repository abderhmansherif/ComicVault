using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ComicsWebApi.Models
{
    public class User : IdentityUser
    {
        public DateOnly JoinedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<Folder>? Folders { get; set; }
        public ICollection<Comic>? Comics { get; set; }
        public ICollection<ReadingHistory>? ReadingHistory { get; set; }
        public ICollection<FavoriteComics>? FavoriteComics { get; set; } 
        public ICollection<Bookmark>? Bookmarks { get; set; }
    }
}