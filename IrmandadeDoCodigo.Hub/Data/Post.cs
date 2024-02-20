using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrmandadeDoCodigo.Hub.Data
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ApplicationUser User { get; set; }
    }
}
