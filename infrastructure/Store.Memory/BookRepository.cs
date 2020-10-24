using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art of Programming", "Description 1", 7.19m), 
            new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring", "Description 2", 12.3m), 
            new Book(3, "ISBN 12312-31232", "B. Kerning, D. Richie", "C Programming Language", "Description 3", 15.05m), 
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(book => book.Title.Contains(titleOrAuthor) || book.Author.Contains(titleOrAuthor)).ToArray();
        }

        public Book GetById(int id)
        {
            return books.First(b => b.Id == id);
        }
    }
}
