using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Page
    {
        public int Id { get; set; }
        public required string ComicId { get; set; }
        public decimal PageSize { get; set; }
        public string PagePath { get; set; } = string.Empty;
        public int PageNumber { get; set; }

        public required Comic Comic { get; set; }
        public ICollection<Bookmark>? Bookmarks { get; set; }
    }
}