using Blog.Data;
using Blog.Models;
using System;

using (var context = new BlogDataContext())
{
    /*
    var tag = new Tag { Name = "Git", Slug = "git" };
    context.Tags.Add(tag);
    context.SaveChanges(); */

    var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
    tag.Name = ".NET";
    tag.Slug = "dotnet";

    context.Update(tag);
    context.SaveChanges();
    Console.WriteLine("Atualização da TAG feita com sucesso!!!");
}
