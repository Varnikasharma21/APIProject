using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentConnect.Models;
using AssignmentConnect.Models.RequestMODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BOOKSController : ControllerBase
    {
        // GET: api/BOOKS
        private readonly BOOKSContext _booksContext;
            public BOOKSController(BOOKSContext books)
        {
            _booksContext = books;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var getDetails = _booksContext.Details.ToList();
            return Ok(getDetails);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get2(int id)
        {
            try
            {
                var last = _booksContext.Details.First(obj => obj.BookId == id);
                if (last == null)
                    return NotFound();
                return Ok(last);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Id Not Found");
            }
        }


        // GET: api/BOOKS/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //return "value";
        //}

        // POST: api/BOOKS
        // POST: api/CustomerAddress
        [HttpPost]
        public void Post([FromBody] BookRequest value)
        {
            Details obj = new Details();
            obj.BookName = value.BookName;
            obj.BookAuthor = value.BookAuthor;
            obj.BookSeller = value.BookSeller;
            obj.BookCode = value.BookCode;
            obj.TotalPages = value.TotalPages;
            obj.BookPrice = value.BookPrice;
            _booksContext.Details.Add(obj);
            _booksContext.SaveChanges();
        }

[HttpGet("{value}")]
public IActionResult Get(string value)
        {
            var result = _booksContext.Details.Where(obj => obj.BookName.Contains(value));
            return Ok(result);
        }





        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
