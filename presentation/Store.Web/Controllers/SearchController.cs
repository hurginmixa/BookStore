using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly BookService _bookService;

        public SearchController(ILogger<SearchController> logger, BookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public IActionResult Index(string query)
        {
            _logger.LogInformation($"Index enter, query : {query}");

            try
            {
                var book = _bookService.GetAllByQuery(query);

                return View(book);
            }
            finally
            {
                _logger.LogInformation($"Index exit");
            }
        }
    }
}
