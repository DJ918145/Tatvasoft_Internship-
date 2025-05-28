using BookApi.Model;
using BookApi.Serives;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService book)
        {
            this.bookService = book;
        }

        [HttpPost]
        [Route("Add")]
        public ActionResult AddBook(Book book)
        {
            this.bookService.AddBook(book);
            return Ok("Book Added Successfully");
        }

        [HttpGet]
        [Route("GetAdd")]
        public ActionResult GetAll()
        {
            return Ok(this.bookService.GetAll());
        }

        [HttpGet]
        [Route("GetbyId")]
        public ActionResult GetbyId(int id)
        {
            var res = this.bookService.GetBookbyId(id);
            if (res != null) { return Ok(res); };
            return NotFound("Book not found.");
        }

        [HttpGet]
        [Route("DeleteBook")]
        public ActionResult DeleteBook(int id)
        {
            var book = this.bookService.GetBookbyId(id);
            if (book != null)
            {
                this.bookService.DeleteBook(book);
                return Ok("Book Deleted Successfully");
            }
            return NotFound("Book not found.");
        }

        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult UpdateBook(Book book)
        {
            if (book == null || book.Id == 0)
            {
                return BadRequest("Invalid book data.");
            }

            var existingBook = this.bookService.GetBookbyId(book.Id);
            if (existingBook == null)
            {
                return NotFound("Book not found.");
            }

            this.bookService.UpdateBook(book); // Assuming this method exists
            return Ok("Book updated successfully.");
        }


    }
}
