using Ecomm.Data;
using Ecomm.Helper;
using Ecomm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public BooksController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Book book)
        {
            book.ImageUrl = await FileHelper.UploadImage(book.ImageFile);
            book.BookUrl = await FileHelper.UploadUrl(book.BookFile);
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
