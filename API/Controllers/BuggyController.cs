using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;

        }
        [HttpGet("notfound")]
        public async Task<ActionResult> GetNotFoundRequest()
        {
            var thing =await _context.Products.FindAsync(42);
            if(thing == null)
            return NotFound(new ApiResponse(404));
            else
            return Ok();
        }
        [HttpGet("servererror")]
        public async Task<ActionResult> GetServerError()
        {
            var thing = await _context.Products.FindAsync(42);
            var respo  = thing.ToString();

            return Ok(respo);
        }
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }
        [HttpGet("badrequest/{id}")]
        public ActionResult GetNotFoundRequest(int id)
        {
            return Ok();
        }
    }
}