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
    [Route("api/articles/")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly CoreContext _context;

        public ArticlesController(CoreContext context)
        {
            _context = context;
        }

        // GET: api/Articles
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Article>>> GetArticleList()
        {
            return await _context.ArticleList.ToListAsync();
        }

        // GET: api/Articles/5
        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<Article>> GetArticle(string id)
        {
            var article = await _context.ArticleList.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }
            return article;
        }

        //GET: api/Articles/5
        [HttpGet("description/{description}")]
        public async Task<ActionResult<List<Article>>> GetArticleByName(string description)
        {

            return await _context.ArticleList.Where(s => s.Description.IndexOf(description) >= 0).ToListAsync();

        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("updatebyid/{id}")]
        public async Task<IActionResult> PutArticle(string id, Article article)
        {

            //if (id != article.Id)
            //{
            //    return BadRequest();
            //}    

            var proofeArticle = _context.Entry(article).Entity;
            if (id != proofeArticle.Id)
            {
                return BadRequest("**Id does not match!**");
            }

            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Article successfully updated!");
        }

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("add/")]
        public async Task<ActionResult> PostArticle(Article article)
        {
            _context.ArticleList.Add(article);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetArticle", new { id = article.Id }, article);
            return Ok("Article successfully added!");
        }

        // DELETE: api/Articles/5
        [HttpDelete("deletebyid/{id}")]
        public async Task<IActionResult> DeleteArticle(string id)
        {
            var article = await _context.ArticleList.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.ArticleList.Remove(article);
            await _context.SaveChangesAsync();

            return Ok("Article deleted successfully!");
        }

        private bool ArticleExists(string id)
        {
            return _context.ArticleList.Any(e => e.Id == id);
        }
    }
}
