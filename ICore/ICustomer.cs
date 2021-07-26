using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{

    /// <summary>
    /// describes the Customer
    /// </summary>
    public interface ICustomer
    {

        #region Public Properties

        /// <summary>
        /// unique id of the contactdata
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Firstname of the Customer
        /// </summary>
        public string Firstname { get; }

        /// <summary>
        /// Lastname of the Customer
        /// </summary>
        public string Lastname { get; }

        /// <summary>
        /// The contactdata of the customer
        /// </summary>
        public IContactdata IContactdata { get; }

        #endregion

        #region Private Properties


        #endregion

        #region Public Methods

        //create a new Customer
        public void CreateCustomer();

        //find/get a specific Customer
        public void GetCustomer();

        //Update Customer information
        public void UpdateCustomer();

        //delete a Customer from the database
        public void DeleteCustomer();

        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion



    }
}
