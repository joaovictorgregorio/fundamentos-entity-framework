using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Clear();

        using var context = new BlogDataContext(); // Conexão com o banco de dados

        var post = await context.Posts.ToListAsync();
        var user = await context.Users.ToListAsync();

        var posts = await GetPosts(context);

        Console.WriteLine("Hello, World!");
    }

    // Exemplo de método para buscar posts
    public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
    {
        return await context.Posts.ToListAsync();
    }
}