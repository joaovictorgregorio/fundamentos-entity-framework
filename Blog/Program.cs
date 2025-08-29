using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;

Console.Clear();

var user = new User
{
    Name = "Josenildo",
    Slug = "josenildo",
    Email = "josenildo@gmail.com",
    Bio = "Programador .NET",
    GitHub = "josenildo.github.io"
};

using var context = new BlogDataContext();
context.Users.Add(user);
context.SaveChanges();