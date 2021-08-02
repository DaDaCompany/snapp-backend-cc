using ICore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ArticleHistory : IArticleHistory
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// The projects in which the article is used
        /// </summary>
        //[Required]
        [NotMapped]
        public IEnumerable<IProject> IProjects => this.Projects;
        public List<Project> Projects { get; set; } = new List<Project>();

        /// <summary>
        /// The project ID in which the article is used
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// the base article from the companys article list
        /// </summary>
        [NotMapped]
        public IEnumerable<IArticle> IBaseArticles => this.BaseArticles;
        public List<Article> BaseArticles { get; set; } = new List<Article>();

        /// <summary>
        /// the base article id from the company
        /// </summary>
        public string BaseArticleId { get; set; }

        /// <summary>
        /// the name of the article when added to the project
        /// </summary>
        public string ArticleName { get; set; }

        /// <summary>
        /// description of the article when added to the project
        /// </summary>
        public string ArticleDescription { get; set; }

        /// <summary>
        /// the price per unit when added to the project
        /// </summary>
        public double ArticlePricePerUnit { get; set; }

        /// <summary>
        /// the measurment per unit when added to the project
        /// </summary>
        public string ArticleUnitMeasurement { get; set; }

        /// <summary>
        /// the article catergory at the projects bill date
        /// </summary>
        public int ArticleCategory { get; set; }

        /// <summary>
        /// the taxrate of each article when added to the project
        /// </summary>
        public int ArticleTaxRate { get; set; }

        /// <summary>
        /// the amount of each article
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// the optional discount for the whole bill
        /// </summary>
        public double Discount { get; set; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public ArticleHistory()
        {

        }

        #endregion


    }
}
