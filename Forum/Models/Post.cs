using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public required Theme Theme { get; set; }
        public string Text { get; set; }
    }
}
