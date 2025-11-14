using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Bookmark
    {
        public required string ComicId { get; set; }
        public required int PageId { get; set; }
        public required string UserId { get; set; }
        public DateTime AddedAt { get; set; }

        public required Comic Comic { get; set; }
        public required Page Page { get; set; }
        public required User User { get; set; }
    }
}