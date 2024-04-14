using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class AuthorFactory
{
    public static List<AuthorEntity> Create(List<Author> authors)
    {
        return authors.Select(a => new AuthorEntity
        {
            LastName = a.LastName,
            FirstName = a.FirstName
        }).ToList();
       
    }

    public static AuthorEntity Create(Author author)
    {
        return new AuthorEntity
        {
            LastName = author.LastName,
            FirstName = author.FirstName
        };

    }

    public static List<Author> Create(ICollection<AuthorEntity> authors)
    {
        return authors.Select(a => new Author
        {
            LastName = a.LastName,
            FirstName = a.FirstName
        }).ToList();
    }
}
