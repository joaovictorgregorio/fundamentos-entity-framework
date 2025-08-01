using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string? Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(200)]
        [Column("Email", TypeName = "VARCHAR")]
        public string? Email { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(20)]
        [Column("PasswordHash", TypeName = "VARCHAR")]
        public string? PasswordHash { get; set; }

        [Required]
        [MaxLength(2000)]
        [Column("Image", TypeName = "VARCHAR")]
        public string? Image { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Bio", TypeName = "VARCHAR")]
        public string? Bio { get; set; }
    }
}