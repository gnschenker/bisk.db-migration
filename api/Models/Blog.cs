using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bisk.model
{
    public class Blog
    {
        public int BlogId { get; set; }
        [Required,MaxLength(500)]
        public string Url { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        public List<Post> Posts { get; set; }
    }
}