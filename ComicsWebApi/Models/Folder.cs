using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Folder
    {
        public string Id { get; set; }
        public required string Name { get; set; }
        public string? UserId { get; set; }
        public bool IsDeleted { get; set; }

        public User? User { get; set; }
        public ICollection<Comic>? Comcis { get; set; }

        public Folder()
        {
            Id = Guid.NewGuid().ToString();
            IsDeleted = false;
        }
    }
}