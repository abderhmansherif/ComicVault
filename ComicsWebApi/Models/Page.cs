using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsWebApi.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string ComicId { get; set; }
        public decimal Size { get; set; }

        public Comic Comic { get; set; }
    }
}