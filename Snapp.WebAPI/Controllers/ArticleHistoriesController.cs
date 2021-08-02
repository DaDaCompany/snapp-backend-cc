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

        // GET: api/ArticleHistories/5
        [HttpGet("getbyprojectid/{id}")]
        public async Task<ActionResult<List<ArticleHistory>>> GetArticlesByProjectId(string id)
        {

            return await _context.ArticleHistory.Where(s => s.ProjectId == id).ToListAsync();

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
        [HttpPost("add")]
        public async Task<ActionResult> PostArticleHistory(ArticleHistory articleHistory)
        {

            // the articlelist which matched with the projectId
            var proofeArticles = await _context.ArticleHistory.Where(s => s.ProjectId == articleHistory.ProjectId).ToListAsync();

            //var proofeArticles = await _context.ArticleHistory.Where(s => s.BaseArticleId == articleHistory.BaseArticleId).ToListAsync();



            if (proofeArticles.Count > 0)
            {
                foreach (var proofeArticle in proofeArticles)
                {
                    if (proofeArticle.BaseArticleId == articleHistory.BaseArticleId)
                    {

                        // proofe the articlevalues
                        if (
                            proofeArticle.ArticleName == articleHistory.ArticleName &&
                            proofeArticle.ArticleDescription == articleHistory.ArticleDescription &&
                            proofeArticle.ArticlePricePerUnit == articleHistory.ArticlePricePerUnit &&
                            proofeArticle.ArticleUnitMeasurement == articleHistory.ArticleUnitMeasurement &&
                            proofeArticle.ArticleCategory == articleHistory.ArticleCategory &&
                            proofeArticle.ArticleTaxRate == articleHistory.ArticleTaxRate &&
                            proofeArticle.Discount == articleHistory.Discount)
                        {
                            proofeArticle.Amount += articleHistory.Amount;

                            //use the put-update-method to change the articlevalues
                            await PutArticleHistory(proofeArticle.Id, proofeArticle);
                            return Ok("Article updated successfully!");
                        }
                    }
                }
            }

            //add an article
            _context.ArticleHistory.Add(articleHistory);
                try
                {
                    await _context.SaveChangesAsync();
                    return Ok("Article added successfully!");
                
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
        }


        // DELETE: api/ArticleHistories/5
        [HttpDelete("deletebyid/{id}")]
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
