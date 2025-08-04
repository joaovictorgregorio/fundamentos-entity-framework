using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;

Console.Clear();

using var context = new BlogDataContext();
var post = context
    .Posts
    // .AsNoTracking()
    .Include(x => x.Author)
    .Include(x => x.Category)
    .OrderByDescending(x => x.LastUpdateDate)
    .FirstOrDefault();

post.Author.Name = "João G.";
context.Posts.Update(post);
context.SaveChanges();










/* var user = new User
{
    Name = "João Silva",
    Email = "joao.silva@gmail.com",
    PasswordHash = "12345678910",
    Image = "https://joao.io",
    Slug = "joaosilva",
    Bio = "Estagiario Premium"
};

var category = new Category
{
    Name = "Full-stack",
    Slug = "fullstack"
};

var Post = new Post
{
    Author = user,
    Category = category,
    Title = "Iniciando no EF",
    Summary = "Neste artigo vamos aprender sobre EF Core",
    Body = "<p>Olá, mundo!</p>",
    Slug = "iniciando-no-ef",
    CreateDate = DateTime.Now,
    LastUpdateDate = DateTime.Now
};

context.Posts.Add(Post);
context.SaveChanges();
*/