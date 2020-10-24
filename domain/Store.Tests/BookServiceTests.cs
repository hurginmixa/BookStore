using Xunit;
using Moq;

namespace Store.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallGetAllByIsbn()
        {
            Mock<IBookRepository> bookRepositoryStub = new Mock<IBookRepository>();
            
            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>())).Returns(new[] {new Book(1, "", "", "", "", 0m),});

            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(new[] {new Book(2, "", "", "", "", 0m),});

            BookService bookService = new BookService(bookRepositoryStub.Object);

            var validIsbn = "ISBN 12345-67890";
            var actual = bookService.GetAllByQuery(validIsbn);

            Assert.Collection(actual, book => Assert.Equal(1, book.Id));
        }

        [Fact]
        public void GetAllByQuery_WithAuthor_CallGetAllByIsbn()
        {
            Mock<IBookRepository> bookRepositoryStub = new Mock<IBookRepository>();
            
            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>())).Returns(new[] {new Book(1, "", "", "", "", 0m),});

            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>())).Returns(new[] {new Book(2, "", "", "", "", 0m),});

            BookService bookService = new BookService(bookRepositoryStub.Object);

            var invalidIsbn = "12345-67890";
            var actual = bookService.GetAllByQuery(invalidIsbn);

            Assert.Collection(actual, book => Assert.Equal(2, book.Id));
        }
    }
}
