using ICore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Article : IArticle
    {

        #region Public Properties

        /// <summary>
        /// unique id of the article
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// The name of the article
        /// </summary>
        public string Name { get; set;}

        /// <summary>
        /// description of the article
        /// </summary>
        public string Description { get; set;}

        /// <summary>
        /// the price per unit for each article
        /// </summary>
        public double PricePerUnit { get; set;}

        /// <summary>
        /// the measurment per unit for each article
        /// </summary>
        public string UnitMeasurement { get; set;}

        /// <summary>
        /// the article category
        /// </summary>
        public string ArticleCategory { get; set;}

        /// <summary>
        /// the taxrate for each article
        /// </summary>
        public int TaxRate { get; set;}

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        #endregion

        #region Private Methods


        #endregion

        #region Constructor

        public Article()
        {

        }

        #endregion


    }
}
