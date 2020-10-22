using System;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of Programming"), 
            new Book(2, "Refactoring"), 
            new Book(3, "C programming Language"), 
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            throw new NotImplementedException();
        }
    }
}
