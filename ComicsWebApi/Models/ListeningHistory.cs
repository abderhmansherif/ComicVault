using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class ListeningHistory
    {
        public string ComicId { get; set; }
        public string UserId { get; set; }
        public DateTime ListenedAt { get; set; }
        public Comic Comic { get; set; }
        public User User { get; set; }
    }
}