using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBCrud.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
