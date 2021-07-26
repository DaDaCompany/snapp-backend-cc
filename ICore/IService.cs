using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    public interface IService
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// the description of the Service
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// the price for the service
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// the taxrate for the service
        /// </summary>
        public int TaxRate { get; }

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
