using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    /// <summary>
    /// describes the contactdata
    /// </summary>
    public interface IContactdata
    {

        #region Public Properties

        /// <summary>
        /// unique id of the contactdata
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// describes the address
        /// </summary>
        public IEnumerable<IAddress> IAddress { get; }

        /// <summary>
        /// describes the phonenumber
        /// </summary>
        public string PhoneNumber { get; }

        /// <summary>
        /// describes the Mobilephonenumber
        /// </summary>
        public string MobileNumber { get; }

        /// <summary>
        /// describes the Email
        /// </summary>
        public string Email { get; }

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
