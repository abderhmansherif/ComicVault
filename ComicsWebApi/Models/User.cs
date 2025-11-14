using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class User
    {
        public int FoldersCount { get; set; }
        public int ComicsCount { get; set; }
        public DateOnly JoinedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<Folder> Folders { get; set; }
        public ICollection<Comic> Comics { get; set; }        
    }
}