using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the position information on the Bill
    /// </summary>
    public interface IArticleHistory
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Project ID in which the article is used
        /// </summary>
        public IEnumerable<IProject> IProjects { get; }
        public string ProjectId { get; }

        /// <summary>
        /// the base article list from the company article list
        /// </summary>
        public IEnumerable<IArticle> IBaseArticles { get; }

        /// <summary>
        /// the base article id from the company article list
        /// </summary>
        public string BaseArticleId { get; }

        /// <summary>
        /// the name of the article when added to the project
        /// </summary>
        public string ArticleName { get; }

        /// <summary>
        /// description of the article when added to the project
        /// </summary>
        public string ArticleDescription { get; }

        /// <summary>
        /// the price per unit when added to the project
        /// </summary>
        public double ArticlePricePerUnit { get; }

        /// <summary>
        /// the measurment per unit when added to the project
        /// </summary>
        public string ArticleUnitMeasurement { get; }

        /// <summary>
        /// the article catergory at the projects bill date
        /// </summary>
        public int ArticleCategory { get; }

        /// <summary>
        /// the taxrate of each article when added to the project
        /// </summary>
        public int ArticleTaxRate { get; }

        /// <summary>
        /// the amount of each article
        /// </summary>
        public double Amount { get; }

        /// <summary>
        /// the optional discount for the whole bill
        /// </summary>
        public double Discount { get; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods


        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion

    }
}
