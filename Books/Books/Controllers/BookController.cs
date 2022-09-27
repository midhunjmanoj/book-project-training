using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Books.Models;


namespace Books.Controllers
{
    public class BookController : ApiController
    {
        private IBookRepository repository;

    public BookController()
    {
        repository = new BookSqlImp();
    }

    [HttpGet]
    public IHttpActionResult Get()
    {
        var data = repository.GetAllBook();
        return Ok(data);
    }

    [HttpGet]
    public IHttpActionResult Get(string id)
    {
        var data = repository.GetBookById(id);
        if (data == null)
            return NotFound();
        return Ok(data);
    }

    [HttpPost]
    public IHttpActionResult Post(Book book)
    {
        var data = repository.AddBook(book);
        return Ok(data);
    }
}
}
