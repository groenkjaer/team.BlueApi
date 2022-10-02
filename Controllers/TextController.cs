using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team.BlueApi.Models;

namespace team.BlueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly WordsContext _context;
        public TextController(WordsContext ctx)
        {
            _context = ctx;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Words>>> Get()
        {
            return await _context.Words.ToListAsync();
        }
    }
}
