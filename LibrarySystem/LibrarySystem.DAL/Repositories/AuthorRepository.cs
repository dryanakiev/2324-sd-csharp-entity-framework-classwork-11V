using LibrarySystem.DAL.Data;
using LibrarySystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.DAL.Repositories;

public class AuthorRepository
{
    public static LibraryContext context = new LibraryContext();

    public List<Author> GetAllAuthors()
    {
        return context.Authors.ToList();
    }

    public Author GetAuthorByName(string name)
    {
        // Querry syntax
        /*IEnumerable<Author> author;

        author = from queryAuthor in context.Authors
        where queryAuthor.Name == name
        select queryAuthor;

        return author.First();*/
        
        // Method syntax
        return context.Authors.FirstOrDefault(x => x.Name == name)!;
    }
    
    public Author GetAuthorById(int id)
    {
        return context.Authors.FirstOrDefault(x => x.Id == id)!;
    }

    public void UpdateAuthor(Author newAuthor)
    {
        context.Authors.Update(newAuthor);
    }

    public void DeleteAuthor(Author author)
    {
        context.Authors.Remove(author);
    }
}