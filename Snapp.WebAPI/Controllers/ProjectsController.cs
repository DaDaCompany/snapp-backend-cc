using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core;
using Entity;

namespace Snapp.WebAPI.Controllers
{
    [Route("api/projects/")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly CoreContext _context;

        public ProjectsController(CoreContext context)
        {
            _context = context;
        }

        // GET: api/Projects
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectList()
        {
            return await _context.ProjectList.ToListAsync();
        }

        // GET: api/Projects/5
        [HttpGet("getprojectbyid")]
        public async Task<ActionResult<Project>> GetProject(string id)
        {
            var project = await _context.ProjectList.FindAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return project;
        }

        // PUT: api/Projects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("updateprojectbyid/{id}")]
        public async Task<IActionResult> PutProject(string id, Project project)
        {
            if (id != project.Id)
            {
                return BadRequest();
            }

            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Project updated successfully!");
        }

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("add")]
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
            _context.ProjectList.Add(project);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectExists(project.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Project added successfully!");
        }

        // DELETE: api/Projects/5
        [HttpDelete("deleteprojectbyid/{id}")]
        public async Task<IActionResult> DeleteProject(string id)
        {
            var project = await _context.ProjectList.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            _context.ProjectList.Remove(project);
            await _context.SaveChangesAsync();

            return Ok("Project deleted successfully!");
        }

        private bool ProjectExists(string id)
        {
            return _context.ProjectList.Any(e => e.Id == id);
        }
    }
}
