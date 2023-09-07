using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Research_management.API.Data;
using Research_management.Shared.Entities;

namespace Research_management.API.Controllers
{
    [ApiController]
    [Route("api/InvestigationProjects")]

    public class InvestigationProjectsController : Controller
    {
        private readonly DataContext _context;

        public InvestigationProjectsController(DataContext context)
        {
            _context = context;
        }

        //Get a investigation project.
        [HttpGet("{Id}")]
        public async Task<ActionResult> Get(int Id)
        {
            var InvestigationProject = await _context.investigationProjects.FirstOrDefaultAsync(x => x.Id == Id);

            if(InvestigationProject == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(InvestigationProject);
            }           
        }

        //Get a list of investigation projects.
        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            var InvestigationProjectsList = await _context.investigationProjects.ToListAsync();

            if (InvestigationProjectsList.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(InvestigationProjectsList);
            }
        }

        //Insert a investigation project.
        [HttpPost]
        public async Task<ActionResult> Post(InvestigationProject InvestigationProject)
        {

            _context.Add(InvestigationProject);
            await _context.SaveChangesAsync();
            return Ok(InvestigationProject);
        }

        //Insert a investigation project.
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var InvestigationProject = await _context.investigationProjects.FirstOrDefaultAsync(x=>x.Id == Id);

            if(InvestigationProject == null) {

                return NotFound();
            }
            
            _context.Remove(InvestigationProject);

            await _context.SaveChangesAsync();
            return Ok(InvestigationProject);
        }
    }
}
