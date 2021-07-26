using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the address, no Interface "IAddress" needed
    /// </summary>
    public interface IAddress
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// describes the street
        /// </summary>
        public string Street { get; }

        /// <summary>
        /// describes the city
        /// </summary>
        public string Town { get; }

        /// <summary>
        /// The ZipCode of the project-adress
        /// </summary>
        public string ZipCode { get; }

        /// <summary>
        /// describes the country
        /// </summary>
        public string Country { get; }


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
