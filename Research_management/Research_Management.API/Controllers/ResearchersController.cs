using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research_management.API.Data;
using Research_management.Shared.Entities;

namespace Research_management.API.Controllers
{
    [ApiController]
    [Route("api/researchers")]
    public class ResearchersController:ControllerBase
    {
        private readonly DataContext _dataContext = null!;

        public ResearchersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Get a list of researchers.
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.Researchers.ToListAsync());
        }

        //Insert a researchers.
        [HttpPost]
        public async Task<ActionResult> Post(Researcher researcher)
        {
            _dataContext.Researchers.Add(researcher);
                await _dataContext.SaveChangesAsync();
            return Ok(researcher);
        }

        //Get a researchers for id.
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var Researcher = await _dataContext.Researchers.FirstOrDefaultAsync(x => x.Id == id);

            if (Researcher == null)
            {
                return NotFound();
            }

            return Ok(Researcher);
        }

        //Insert a researchers for id.
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var Researcher = await _dataContext.Researchers.FirstOrDefaultAsync(x => x.Id == Id);

            if (Researcher == null)
            {

                return NotFound();
            }

            _dataContext.Remove(Researcher);

            await _dataContext.SaveChangesAsync();
            return Ok(Researcher);
        }
    }
}
