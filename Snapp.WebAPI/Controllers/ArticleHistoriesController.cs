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
    [Route("api/articlehistory/")]
    [ApiController]
    public class ArticleHistoriesController : ControllerBase
    {
        private readonly CoreContext _context;

        public ArticleHistoriesController(CoreContext context)
        {
            _context = context;
        }

        // GET: api/ArticleHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleHistory>>> GetArticleHistory()
        {
            return await _context.ArticleHistory.ToListAsync();
        }

        // GET: api/ArticleHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleHistory>> GetArticleHistory(string id)
        {
            var articleHistory = await _context.ArticleHistory.FindAsync(id);

            if (articleHistory == null)
            {
                return NotFound();
            }

            return articleHistory;
        }

        // PUT: api/ArticleHistories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticleHistory(string id, ArticleHistory articleHistory)
        {
            if (id != articleHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(articleHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleHistoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ArticleHistories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArticleHistory>> PostArticleHistory(ArticleHistory articleHistory)
        {
            _context.ArticleHistory.Add(articleHistory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ArticleHistoryExists(articleHistory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetArticleHistory", new { id = articleHistory.Id }, articleHistory);
        }

        // DELETE: api/ArticleHistories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleHistory(string id)
        {
            var articleHistory = await _context.ArticleHistory.FindAsync(id);
            if (articleHistory == null)
            {
                return NotFound();
            }

            _context.ArticleHistory.Remove(articleHistory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleHistoryExists(string id)
        {
            return _context.ArticleHistory.Any(e => e.Id == id);
        }
    }
}
