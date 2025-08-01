using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        [Column("Title", TypeName = "VARCHAR")]
        public string? Title { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string? Summary { get; set; }

        [Required]
        [MinLength(3)]
        [Column("Body", TypeName = "VARCHAR")]
        public string? Body { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("LastUpdateDate", TypeName = "datetime")]
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User? Author { get; set; }
    }
}