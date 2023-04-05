using Ecomm.Data;
using Ecomm.Helper;
using Ecomm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoversController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CoversController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] BookCover cover)
        {
            cover.ImageUrl = await FileHelper.UploadImage(cover.ImageFile);
            await context.BookCovers.AddAsync(cover);
            await context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
