using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the article
    /// </summary>
    public interface IArticle
    {

        #region Public Properties

        /// <summary>
        /// unique id of the contactdata
        /// </summary>
        public string Id { get;  }
        
        /// <summary>
        /// The name of the article
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// description of the Article
        /// </summary>
        public string Description { get;  }

        /// <summary>
        /// the price per unit
        /// </summary>
        public double PricePerUnit { get;  }
        
        /// <summary>
        /// the measurment per unit
        /// </summary>
        public string UnitMeasurement { get;  }

        /// <summary>
        /// the article category
        /// </summary>
        public string ArticleCategory { get;  }

        /// <summary>
        /// the taxrate for each article
        /// </summary>
        public int TaxRate { get;  }

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
