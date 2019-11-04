using System.ComponentModel.DataAnnotations;

namespace bisk.model
{
    public class Post
    {
        public int PostId { get; set; }
        [Required,MaxLength(25)]
        public string ShortTitle { get; set; }
        [Required,MaxLength(255),MinLength(20)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}