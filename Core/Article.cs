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

        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public double PricePerUnit { get; set; }
        public string UnitMeasurement { get; set; }
        public string ArticleCategory { get; set; }
        public int TaxRate { get; set; }

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
