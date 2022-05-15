using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>() 
            {
                new Book
                {
                    Id=1,Title="C# Programming",
                    Description="No Description",
                    author=new Author(),
                    ImageUrl="image.png"
                },
                new Book
                {
                    Id=2,Title="Java Programming",
                    Description="Not found",
                    author=new Author(),
                    ImageUrl="image.png"
                },
                new Book
                {
                    Id=3,Title="Paython Programming",
                    Description="Description",
                    author=new Author(),
                    ImageUrl="image.png"
                },

            };

        }
        public void Add(Book entity)
        {
            entity.Id = books.Max(b => b.Id) + 1;
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id ,Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.author = newBook.author;
            book.ImageUrl = newBook.ImageUrl;
        }
    }
}
