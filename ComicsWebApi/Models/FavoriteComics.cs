using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class FavoriteComics
    {
        public string UserId { get; set; }
        public string ComicId { get; set; }
        public DateOnly AddedAt { get; set; }

        public Comic Comic { get; set; }
        public User User { get; set; }
    }
}