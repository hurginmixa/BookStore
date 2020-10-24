using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class BookDetailsController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookDetailsController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index(int id)
        {
            Book book = _bookRepository.GetById(id);

            return View("Index", book);
        }
    }
}
