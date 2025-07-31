using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        /* Não é possível utilizar, pois essas tabelas não tem chave primária e EF não entende. Será configurado posteriormente.
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<PostTag> PostTags { get; set; } note pessoal password=jmS052703@@ */
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User Id=sa;Password=j05m27S03@@@;TrustServerCertificate=True;");
    }
}