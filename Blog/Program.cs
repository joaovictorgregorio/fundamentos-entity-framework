using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;

using (var context = new BlogDataContext())
{

    // var tag = new Tag { Name = "Git", Slug = "git" };
    // context.Tags.Add(tag);

    // var tag2 = new Tag { Name = "EF", Slug = "entity framework" };
    // context.Tags.Add(tag2);

    // var tag3 = new Tag { Name = "CSS", Slug = "estilo" };
    // context.Tags.Add(tag3);

    // context.SaveChanges(); 
    // System.Console.WriteLine("Tags adicionadas com sucesso!");

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
    // tag.Name = ".NET";
    // tag.Slug = "dotnet";

    // context.Update(tag);
    // context.SaveChanges();
    // Console.WriteLine("Atualização da TAG feita com sucesso!!!"); 

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 3);

    // context.Remove(tag);
    // context.SaveChanges(); */

    var tags = context
        .Tags
        .AsNoTracking()
        .ToList();

    foreach (var tag in tags)
    {
        Console.WriteLine($"{tag.Name} - {tag.Slug}");
    }
}
