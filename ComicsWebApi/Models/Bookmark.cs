using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Bookmark
    {
        public string ComicId { get; set; }
        public string PageId { get; set; }
        public DateTime AddedAt { get; set; }

        public Comic Comic { get; set; }
        public Page Page { get; set; }
    }
}