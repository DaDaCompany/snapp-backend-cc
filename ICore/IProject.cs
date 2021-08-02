using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICore
{
    public interface IProject
    {

        #region Public Properties

        /// <summary>
        /// describes the position information on the Bill
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// the "created at" timestamp
        /// </summary>
        public DateTime CreatedAt { get; }

        /// <summary>
        /// the "updated at" timestamp
        /// </summary>
        public DateTime UpdatedAt { get; }

        /// <summary>
        /// the id of the associated bill
        /// </summary>
        public IBill IBill { get; }

        /// <summary>
        /// the startdate of the project
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// the enddate of the project
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// The associated Customer of the project
        /// </summary>
        public IEnumerable<ICustomer> ICustomers { get; }

        /// <summary>
        /// describes the id of the customer
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// the leader/responsible Person of the project
        /// </summary>
        //public IUser ILeader { get; }

        /// <summary>
        /// the leader/responsible Person of the project
        /// </summary>
        //public IUser IUser { get; }
        public IEnumerable<IUser> IUsers { get; }

        /// <summary>
        /// the status of the project/bill
        /// </summary>
        public ProjectStatusType Status { get; }

        /// <summary>
        /// describes the street
        /// </summary>
        public string Street { get; }

        /// <summary>
        /// describes the country
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

        //print the Bill
        public void PrintBill();

        //add an article to the project
        public void AddArticle();

        //Delete an article from the project
        public void DeleteArticle();

        #endregion

        #region Private Methods


        #endregion

        #region Constructor


        #endregion


    }
}
