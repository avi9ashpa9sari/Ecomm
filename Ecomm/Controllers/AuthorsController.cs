using Ecomm.Data;
using Ecomm.Helper;
using Ecomm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AuthorsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] BookAuthor author)
        {
            author.ImageUrl = await FileHelper.UploadImage(author.ImageFile);
            await context.BookAuthors.AddAsync(author);
            await context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
