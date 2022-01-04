using Lab_5_2.Models;
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
        private ICRUDBookRepository books;

        public ApiBookController(ICRUDBookRepository books)
        {
            this.books = books;
        }

        //deklaracja zmiennej repozytorium
        [HttpGet]

        public IList<Book> GetBooks()
        {
            return books.FindAll();
        }
        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book book)
        {
            Book book1 = books.Add(book);
            return new CreatedResult($"/api/books/{book.Id}", book);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook()
        {
            Book book = books.FindById(id);
            if (book != null)
            {
                return new OkObjectResult(book);
            }
            else
            {
                return new NotFoundResult();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<Book> EditBook(int id, [FromBody] Book book)
        {
            //wywo³anie metody z repozytorium zmieniaj¹cej wartoœci w obiekcie
            //testujemy czy obiekt jest inny od null
            if (id < 5 && id > 0)
            {


                return new OkObjectResult(book);
            }
            else
            {

                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            //wywo³anie metody z repozytorium zmieniaj¹cej wartoœci w obiekcie
            //testujemy czy obiekt jest inny od null
            if (id < 5 && id > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}