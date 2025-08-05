using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;

Console.Clear();

using var context = new BlogDataContext();

/*
context.Users.Add(new User
{
    Name = "Aleatorio Ferreira",
    Email = "aleatorio@hotmail.com",
    PasswordHash = "123456",
    Image = "https://aleatorio.io",
    Slug = "aleatorio-ferreira",
    Bio = "Estagiário Senior"
});
*/

var user = context.Users.FirstOrDefault(x => x.Id == 1);
var post = new Post
{
    Title = "Meu artigo",
    Summary = "Neste artigo vamos conferir...",
    Body = "Meu artigo",
    Slug = "meu-artigo",
    CreateDate = System.DateTime.Now,
    // LastUpdateDate = 
    Category = new Category
    {
        Name = "Backend",
        Slug = "back-end"
    },
    Author = user,
};

context.Posts.Add(post);
context.SaveChanges();

System.Console.WriteLine($"{post.Title} adicionado com sucesso!");

