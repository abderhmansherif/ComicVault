using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class ReadingHistory
    {
        public required string ComicId { get; set; }
        public required string UserId { get; set; }
        public DateTime ReadingAt { get; set; }
        public required Comic Comic { get; set; }
        public required User User { get; set; }
    }
}