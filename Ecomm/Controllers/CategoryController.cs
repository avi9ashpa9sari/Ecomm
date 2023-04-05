using Ecomm.Data;
using Ecomm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoriesController>
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _context.categories.ToListAsync());
        //}

        //// GET api/<CategoriesController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await _context.categories.FirstOrDefaultAsync(x => x.Id == id));
        //}

        //// POST api/<CategoriesController>
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Category category)
        //{
        //    await _context.categories.AddAsync(category);
        //    await _context.SaveChangesAsync();
        //    return StatusCode(StatusCodes.Status201Created);
        //}

        //// PUT api/<CategoriesController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] Category category)
        //{
        //    var catUpdate = await _context.categories.FirstOrDefaultAsync(x => x.Id == id);
        //    if (catUpdate != null)
        //    {
        //        catUpdate.Title = category.Title;
        //        catUpdate.DisplayOrder = category.DisplayOrder;
        //        _context.categories.Update(catUpdate);
        //        await _context.SaveChangesAsync();
        //        return Ok("Category Updated");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //// DELETE api/<CategoriesController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var catDelete = await _context.categories.FirstOrDefaultAsync(x => x.Id == id);
        //    if (catDelete != null)
        //    {
        //        _context.categories.Remove(catDelete);
        //        await _context.SaveChangesAsync();
        //        return Ok("Category Deleted");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
    }
}
