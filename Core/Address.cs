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

    public class Address : IAddress
    {

        #region Public Properties

        /// <summary>
        /// the unique id of the position
        /// </summary>
        [Key]
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// describes the street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// describes the country
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// The ZipCode of the project-adress
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// describes the country
        /// </summary>
        public string Country { get; set; }

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
