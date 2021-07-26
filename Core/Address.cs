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
    /// <summary>
    /// describes the address, no Interface "IAddress" needed
    /// </summary>
    public class Address : IAddress
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// describes the street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// describes the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// describes the country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// describes the PostalCode
        /// </summary>
        public int PostalCode { get; set; }

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
