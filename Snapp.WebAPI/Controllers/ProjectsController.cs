using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core;
using Entity;
using System.Text.Json;

namespace Snapp.WebAPI.Controllers
{
    [Route("api/projects/")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly CoreContext _context;
        private BillsController _BillsController;

        public ProjectsController(CoreContext context)
        {
            _context = context;

            _BillsController = new BillsController(context);

        }

        // GET: api/Projects
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectList()
        {
            return await _context.ProjectList.ToListAsync();
        }

        // GET: api/Projects/5
        [HttpGet("getprojectbyid/{id}")]
        public async Task<ActionResult<Project>> GetProjectbyId(string id)
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

        // Genearte Bill with ProjectID
        [HttpPost("generatebill/{id}")]
        public async Task<ActionResult<Project>> GenerateProjectBill(string id)
        {

            Project currentProject = GetProjectbyId(id).Result.Value;

            List<ArticleHistory> articleList = await _context.ArticleHistory.Where(s => s.ProjectId == id).ToListAsync();

            double netCost = 0.00;
            double totalCost = 0.00;

            foreach (var article in articleList)
            {
                netCost += (article.ArticlePricePerUnit * article.Amount);
                totalCost += (article.ArticlePricePerUnit * article.Amount * article.ArticleTaxRate);
            }

            Bill Bill = new Bill
            {
                ProjectName = currentProject.Name,
                EndDate = Convert.ToDateTime(currentProject.EndDate),
                Customer = currentProject.Customer,
                CustomerId = currentProject.CustomerId,
                NetCost = netCost,
                TotalCost = totalCost,
                ProjectId = currentProject.Id,
                Articles = articleList,
            };

            _context.Bill.Add(Bill);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectExists(id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(Bill);
        }

        //Check project exists
        private bool ProjectExists(string id)
        {
            return _context.ProjectList.Any(e => e.Id == id);
        }
    }
}