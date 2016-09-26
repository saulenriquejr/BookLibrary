using Contracts;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBooksOperations _booksOperations;

        public HomeController(IBooksOperations booksOperations)
        {
            _booksOperations = booksOperations;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<string> GetAllBooks()
        {
            var result = await _booksOperations.GetAllBooks();

            return JsonConvert.SerializeObject(result);
        }

        [HttpGet]
        public async Task<string> GetBooksByCategory(string category)
        {
            var result = await _booksOperations.GetBooksByCategory(category);

            return JsonConvert.SerializeObject(result);
        }

        [HttpGet]
        public async Task<string> GetBooksByAuthor(string author)
        {
            var result = await _booksOperations.GetBooksByAuthor(author);

            return JsonConvert.SerializeObject(result);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBook(int Id)
        {
            await _booksOperations.Delete(Id);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}