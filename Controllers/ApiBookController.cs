using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class ApiBookController : ControllerBase
    {
        //deklaracja zmiennej repozytorium
        [HttpGet]

        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Title="AAAA"
                },
                new Book()
                {
                    Title="BBBB"
                }
            };
        }
        [HttpPost]
        public IActionResult AddBook ([FromBody] Book)
        {
            //dodanie obiektu do repozytorium
            book.Id = 5;
            return new CreatedResult($"/api/books/{book.Id}", book);
        }
    }
}