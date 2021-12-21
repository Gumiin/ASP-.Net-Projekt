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
        public IActionResult AddBook([FromBody] Book)
        {
            //dodanie obiektu do repozytorium
            book.Id = 5;
            return new CreatedResult($"/api/books/{book.Id}", book);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook()
        {
            //pobieranie obiektu z repozytorium o danym id
            if (id < 5 && Id > 0)
            {
                return new OkObjectResult(new Book() { Id = id, Title = "tytu³" });
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